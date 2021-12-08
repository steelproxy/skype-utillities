using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SKYPE4COMLib;

namespace SkypeUtillities
{
    public partial class MainForm : Form
    {
        private Skype skypeInstance = new Skype();
        public MainForm()
        {
            InitializeComponent();
            while(!skypeInstance.Client.IsRunning)
                if(MessageBox.Show("Skype client isn't running (as far as this program can tell). Attempt to attach?", "Error:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Process.GetCurrentProcess().Kill();
            commandsDropDown.SelectedIndex = 0;
            optionsAndRolesDropDown.SelectedIndex = 0;
            foreach (User user in skypeInstance.Friends)
                if(user.Handle != "echo123")
                    usernameBox.Items.Add(user.FullName);
        }

        public void Spam(string recipient, string message, int amount)
        {
            message.TrimStart(' ');
            spamProgressBar.Value = 0;
            for (var currentMessage = 0; currentMessage < amount; currentMessage++)
            {
                skypeInstance.SendMessage(recipient, message);
            }
            spamProgressBar.Value = spamProgressBar.Maximum;
        }

        private void Send(object sender, EventArgs e)
        {
            if (continuouslyCheckBox.Checked && messageBox.Text != "")
            {
                sendButton.Enabled = false;
                sendTimer.Interval = short.Parse(freqUpDown.Text);
                sendTimer.Start();
            }
            else
            {
                sendTimer.Stop();
            }
            if (messageBox.Text == "")
                return;
            var amount = short.Parse(amountUpDown.Text);
            foreach (string username in usernameBox.CheckedItems)
                foreach (User user in skypeInstance.Friends)
                    if(user.FullName == username)
                        Spam(user.Handle, messageBox.Text, amount);
            foreach (string username in nonContactsListBox.CheckedItems)
                Spam(username, messageBox.Text, amount);
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            sendButton.Text = (continuouslyCheckBox.Checked) ? "Start" : "Send";
            freqUpDown.Enabled = continuouslyCheckBox.Checked;
            stopButton.Enabled = continuouslyCheckBox.Checked;
        }

        private void UpdateNonContactTextBox(object sender, EventArgs e)
        {
            nonContactsListBox.Enabled = nonContactCheckBox.Checked;
            addUserTextBox.Enabled = nonContactCheckBox.Checked;
            addUserButton.Enabled = nonContactCheckBox.Checked;
            clearButton.Enabled = nonContactCheckBox.Checked;
            deleteButton.Enabled = nonContactCheckBox.Checked;
        }

        private void AddUser(object sender, EventArgs e)
        {
            if (addUserTextBox.Text == "" || addUserTextBox.Text.StartsWith(" ") ||
                nonContactsListBox.FindString(addUserTextBox.Text) == 0 || addUserTextBox.Text.EndsWith(" ") || addUserTextBox.Text == "echo123")
                MessageBox.Show(@"Invalid username!", @"Error:");
            else
                nonContactsListBox.Items.Add(addUserTextBox.Text);
        }

        private void ClearList(object sender, EventArgs e)
        {
            nonContactsListBox.Items.Clear();
        }

        private void DeleteSelected(object sender, EventArgs e)
        {
            foreach (Object item in nonContactsListBox.CheckedItems.OfType<object>().ToList())
                nonContactsListBox.Items.Remove(item);
        }

        private void GenerateQuote(object sender, EventArgs e)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var dateTime = new DateTime();
            if (!DateTime.TryParse(timeStampTextBox.Text, out dateTime))
            {
                MessageBox.Show(@"Invalid date!", @"Error:");
                return;
            }
            var user = authorTextBox.Text;
            var message = quoteMessageTextBox.Text;
            var skypeMessageFragment = string.Format("<quote author=\"{0}\" authorname=\"{0}\" timestamp=\"{1}\">{2}</quote>", user, (dateTime.ToUniversalTime() - epoch).TotalSeconds, message);
            var dataObject = new DataObject();
            dataObject.SetData(@"System.String", message);
            dataObject.SetData(@"Text", message);
            dataObject.SetData(@"UnicodeText", message);
            dataObject.SetData(@"OEMText", message);
            dataObject.SetData(@"SkypeMessageFragment", new MemoryStream(Encoding.UTF8.GetBytes(skypeMessageFragment)));
            dataObject.SetData(@"Locale", new MemoryStream(BitConverter.GetBytes(CultureInfo.CurrentCulture.LCID)));
            Clipboard.SetDataObject(dataObject);
        }

        private void UseCurrentTime(object sender, EventArgs e)
        {
            timeStampTextBox.Text = DateTime.Now.ToString(@"yyyy-MM-dd HH:mm:ss");
        }

        private void UpdateTimeStamp(object sender, EventArgs e)
        {
            timeStampTextBox.Enabled = !useCurrentTimeCheckBox.Checked;
            if (useCurrentTimeCheckBox.Checked)
            {
                UseCurrentTime(null, null);
                updateTimer.Start();
            }
            else
                updateTimer.Stop();
        }

        private void UpdateExplaination(object sender, EventArgs e)
        {
            commandExplainationTextBox.Text = _commandListExplained[commandsDropDown.SelectedIndex];
        }

        private void UpdateRolesAndOptionsExplaination(object sender, EventArgs e)
        {
            optionsAndRolesExplainationTextBox.Text = _optionsAndRolesExplained[optionsAndRolesDropDown.SelectedIndex];
        }

        private void Stop(object sender, EventArgs e)
        {
            sendTimer.Stop();
            sendButton.Enabled = true;
        }
    }
}