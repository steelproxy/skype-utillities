using System.Windows.Forms;

namespace SkypeUtillities
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sendButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.sendTimer = new System.Windows.Forms.Timer(this.components);
            this.usernameBox = new System.Windows.Forms.CheckedListBox();
            this.nonContactsListBox = new System.Windows.Forms.CheckedListBox();
            this.nonContactLabel = new System.Windows.Forms.Label();
            this.generateQuoteButton = new System.Windows.Forms.Button();
            this.useCurrentTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.quoteMessageTextBox = new System.Windows.Forms.TextBox();
            this.timeStampTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timeTextBox = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.commandsDropDown = new System.Windows.Forms.ComboBox();
            this.chatCommmandsLabel = new System.Windows.Forms.Label();
            this.commandExplainationTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.rulesAndOptionsLabel = new System.Windows.Forms.Label();
            this.optionsAndRolesDropDown = new System.Windows.Forms.ComboBox();
            this.optionsAndRolesExplainationTextBox = new System.Windows.Forms.TextBox();
            this.quoteGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.continuouslyCheckBox = new System.Windows.Forms.CheckBox();
            this.freqUpDown = new System.Windows.Forms.NumericUpDown();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.nonContactCheckBox = new System.Windows.Forms.CheckBox();
            this.addUserTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.spammerGroupBox = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.chatCommandsGroupBox = new System.Windows.Forms.GroupBox();
            this.spamProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.quoteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqUpDown)).BeginInit();
            this.spammerGroupBox.SuspendLayout();
            this.chatCommandsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(87, 78);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(86, 23);
            this.sendButton.TabIndex = 25;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.Send);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(4, 198);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 24;
            this.usernameLabel.Text = "Username:";
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageBox.Location = new System.Drawing.Point(68, 8);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(443, 184);
            this.messageBox.TabIndex = 19;
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(10, 11);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 13);
            this.messageLabel.TabIndex = 18;
            this.messageLabel.Text = "Message:";
            // 
            // sendTimer
            // 
            this.sendTimer.Tick += new System.EventHandler(this.Send);
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameBox.FormattingEnabled = true;
            this.usernameBox.Location = new System.Drawing.Point(68, 198);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ScrollAlwaysVisible = true;
            this.usernameBox.Size = new System.Drawing.Size(443, 109);
            this.usernameBox.Sorted = true;
            this.usernameBox.TabIndex = 35;
            // 
            // nonContactsListBox
            // 
            this.nonContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nonContactsListBox.Enabled = false;
            this.nonContactsListBox.FormattingEnabled = true;
            this.nonContactsListBox.Location = new System.Drawing.Point(68, 313);
            this.nonContactsListBox.Name = "nonContactsListBox";
            this.nonContactsListBox.ScrollAlwaysVisible = true;
            this.nonContactsListBox.Size = new System.Drawing.Size(443, 109);
            this.nonContactsListBox.TabIndex = 36;
            // 
            // nonContactLabel
            // 
            this.nonContactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nonContactLabel.AutoSize = true;
            this.nonContactLabel.Location = new System.Drawing.Point(10, 316);
            this.nonContactLabel.Name = "nonContactLabel";
            this.nonContactLabel.Size = new System.Drawing.Size(52, 26);
            this.nonContactLabel.TabIndex = 37;
            this.nonContactLabel.Text = "Non-\r\nContacts:";
            // 
            // generateQuoteButton
            // 
            this.generateQuoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateQuoteButton.Location = new System.Drawing.Point(183, 270);
            this.generateQuoteButton.Name = "generateQuoteButton";
            this.generateQuoteButton.Size = new System.Drawing.Size(101, 23);
            this.generateQuoteButton.TabIndex = 44;
            this.generateQuoteButton.Text = "Generate Quote";
            this.generateQuoteButton.UseVisualStyleBackColor = true;
            this.generateQuoteButton.Click += new System.EventHandler(this.GenerateQuote);
            // 
            // useCurrentTimeCheckBox
            // 
            this.useCurrentTimeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.useCurrentTimeCheckBox.AutoSize = true;
            this.useCurrentTimeCheckBox.Location = new System.Drawing.Point(6, 276);
            this.useCurrentTimeCheckBox.Name = "useCurrentTimeCheckBox";
            this.useCurrentTimeCheckBox.Size = new System.Drawing.Size(86, 17);
            this.useCurrentTimeCheckBox.TabIndex = 46;
            this.useCurrentTimeCheckBox.Text = "Current Time";
            this.useCurrentTimeCheckBox.UseVisualStyleBackColor = true;
            this.useCurrentTimeCheckBox.CheckStateChanged += new System.EventHandler(this.UpdateTimeStamp);
            // 
            // quoteMessageTextBox
            // 
            this.quoteMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quoteMessageTextBox.Location = new System.Drawing.Point(6, 37);
            this.quoteMessageTextBox.Multiline = true;
            this.quoteMessageTextBox.Name = "quoteMessageTextBox";
            this.quoteMessageTextBox.Size = new System.Drawing.Size(278, 167);
            this.quoteMessageTextBox.TabIndex = 47;
            // 
            // timeStampTextBox
            // 
            this.timeStampTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeStampTextBox.Location = new System.Drawing.Point(53, 246);
            this.timeStampTextBox.Mask = "0000-00-00 00:00:00";
            this.timeStampTextBox.Name = "timeStampTextBox";
            this.timeStampTextBox.Size = new System.Drawing.Size(231, 20);
            this.timeStampTextBox.TabIndex = 48;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox.AutoSize = true;
            this.timeTextBox.Location = new System.Drawing.Point(11, 249);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(33, 13);
            this.timeTextBox.TabIndex = 49;
            this.timeTextBox.Text = "Time:";
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(3, 223);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 50;
            this.authorLabel.Text = "Author:";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.UseCurrentTime);
            // 
            // commandsDropDown
            // 
            this.commandsDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commandsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commandsDropDown.FormattingEnabled = true;
            this.commandsDropDown.Items.AddRange(new object[] {
            "/me [action]",
            "/help",
            "/add [skypename]",
            "/leave",
            "/topic [newTopic]",
            "/find [text]",
            "/fa or /",
            "/alertson or /alertson [text]",
            "/alertsoff",
            "/history",
            "/htmlhistory",
            "/clear",
            "/info",
            "/call [skypename]",
            "/goadmin",
            "/get creator",
            "/get role",
            "/whois [skypename]",
            "/setrole [skypename] [role]",
            "/kick [skypename]",
            "/kickban [skypename]",
            "/get guidelines",
            "/set guidelines [text]",
            "/get options",
            "/set options [[+ | -]flag]",
            "/get [role]",
            "/setpassword [password] [hint]",
            "/clearpassword",
            "/set password_hint [text]",
            "/get password_hint",
            "/set password [text]",
            "/set banlist [[+ | -]mask]",
            "/get banlist",
            "/set allowlist [[+ | -]mask]",
            "/get allowlist",
            "/get uri",
            "/undoedit",
            "/dbghelp",
            "/showmembers",
            "/showstatus",
            "/info",
            "/showplaces",
            "/remotelogout",
            "/get listeners"});
            this.commandsDropDown.Location = new System.Drawing.Point(6, 32);
            this.commandsDropDown.Name = "commandsDropDown";
            this.commandsDropDown.Size = new System.Drawing.Size(201, 21);
            this.commandsDropDown.TabIndex = 51;
            this.commandsDropDown.SelectedIndexChanged += new System.EventHandler(this.UpdateExplaination);
            // 
            // chatCommmandsLabel
            // 
            this.chatCommmandsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chatCommmandsLabel.AutoSize = true;
            this.chatCommmandsLabel.Location = new System.Drawing.Point(6, 16);
            this.chatCommmandsLabel.Name = "chatCommmandsLabel";
            this.chatCommmandsLabel.Size = new System.Drawing.Size(62, 13);
            this.chatCommmandsLabel.TabIndex = 52;
            this.chatCommmandsLabel.Text = "Commands:";
            // 
            // commandExplainationTextBox
            // 
            this.commandExplainationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commandExplainationTextBox.Location = new System.Drawing.Point(6, 59);
            this.commandExplainationTextBox.Multiline = true;
            this.commandExplainationTextBox.Name = "commandExplainationTextBox";
            this.commandExplainationTextBox.ReadOnly = true;
            this.commandExplainationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandExplainationTextBox.Size = new System.Drawing.Size(201, 108);
            this.commandExplainationTextBox.TabIndex = 53;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Location = new System.Drawing.Point(53, 220);
            this.authorTextBox.MaxLength = 32;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(231, 20);
            this.authorTextBox.TabIndex = 54;
            // 
            // rulesAndOptionsLabel
            // 
            this.rulesAndOptionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesAndOptionsLabel.AutoSize = true;
            this.rulesAndOptionsLabel.Location = new System.Drawing.Point(6, 170);
            this.rulesAndOptionsLabel.Name = "rulesAndOptionsLabel";
            this.rulesAndOptionsLabel.Size = new System.Drawing.Size(98, 13);
            this.rulesAndOptionsLabel.TabIndex = 55;
            this.rulesAndOptionsLabel.Text = "Roles And Options:";
            // 
            // optionsAndRolesDropDown
            // 
            this.optionsAndRolesDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsAndRolesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionsAndRolesDropDown.FormattingEnabled = true;
            this.optionsAndRolesDropDown.Items.AddRange(new object[] {
            "JOINING_ENABLED",
            "JOINERS_BECOME_APPLICANTS",
            "JOINERS_BECOME_LISTENERS",
            "HISTORY_DISCLOSED",
            "USERS_ARE_LISTENERS",
            "TOPIC_AND_PIC_LOCKED_FOR_USERS",
            "USERS_ARE_WRITERS",
            "CREATOR",
            "MASTER",
            "HELPER",
            "USER",
            "LISTENER",
            "APPLICANT"});
            this.optionsAndRolesDropDown.Location = new System.Drawing.Point(6, 186);
            this.optionsAndRolesDropDown.Name = "optionsAndRolesDropDown";
            this.optionsAndRolesDropDown.Size = new System.Drawing.Size(201, 21);
            this.optionsAndRolesDropDown.TabIndex = 56;
            this.optionsAndRolesDropDown.SelectedIndexChanged += new System.EventHandler(this.UpdateRolesAndOptionsExplaination);
            // 
            // optionsAndRolesExplainationTextBox
            // 
            this.optionsAndRolesExplainationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsAndRolesExplainationTextBox.Location = new System.Drawing.Point(6, 213);
            this.optionsAndRolesExplainationTextBox.Multiline = true;
            this.optionsAndRolesExplainationTextBox.Name = "optionsAndRolesExplainationTextBox";
            this.optionsAndRolesExplainationTextBox.ReadOnly = true;
            this.optionsAndRolesExplainationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.optionsAndRolesExplainationTextBox.Size = new System.Drawing.Size(201, 80);
            this.optionsAndRolesExplainationTextBox.TabIndex = 57;
            // 
            // quoteGroupBox
            // 
            this.quoteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quoteGroupBox.Controls.Add(this.label1);
            this.quoteGroupBox.Controls.Add(this.timeStampTextBox);
            this.quoteGroupBox.Controls.Add(this.timeTextBox);
            this.quoteGroupBox.Controls.Add(this.authorTextBox);
            this.quoteGroupBox.Controls.Add(this.authorLabel);
            this.quoteGroupBox.Controls.Add(this.generateQuoteButton);
            this.quoteGroupBox.Controls.Add(this.useCurrentTimeCheckBox);
            this.quoteGroupBox.Controls.Add(this.quoteMessageTextBox);
            this.quoteGroupBox.Location = new System.Drawing.Point(736, 8);
            this.quoteGroupBox.Name = "quoteGroupBox";
            this.quoteGroupBox.Size = new System.Drawing.Size(290, 299);
            this.quoteGroupBox.TabIndex = 58;
            this.quoteGroupBox.TabStop = false;
            this.quoteGroupBox.Text = "Quote Maker";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Quote:";
            // 
            // amountUpDown
            // 
            this.amountUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountUpDown.Location = new System.Drawing.Point(278, 73);
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(225, 20);
            this.amountUpDown.TabIndex = 28;
            this.amountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(278, 57);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 29;
            this.amountLabel.Text = "Amount:";
            // 
            // continuouslyCheckBox
            // 
            this.continuouslyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.continuouslyCheckBox.AutoSize = true;
            this.continuouslyCheckBox.Location = new System.Drawing.Point(155, 23);
            this.continuouslyCheckBox.Name = "continuouslyCheckBox";
            this.continuouslyCheckBox.Size = new System.Drawing.Size(86, 17);
            this.continuouslyCheckBox.TabIndex = 30;
            this.continuouslyCheckBox.Text = "Continuously";
            this.continuouslyCheckBox.UseVisualStyleBackColor = true;
            this.continuouslyCheckBox.CheckedChanged += new System.EventHandler(this.UpdateTime);
            // 
            // freqUpDown
            // 
            this.freqUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.freqUpDown.Enabled = false;
            this.freqUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.freqUpDown.Location = new System.Drawing.Point(278, 110);
            this.freqUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.freqUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.freqUpDown.Name = "freqUpDown";
            this.freqUpDown.Size = new System.Drawing.Size(225, 20);
            this.freqUpDown.TabIndex = 31;
            this.freqUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyLabel.Location = new System.Drawing.Point(278, 95);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(140, 12);
            this.frequencyLabel.TabIndex = 32;
            this.frequencyLabel.Text = "Frequency (Milliseconds):";
            // 
            // nonContactCheckBox
            // 
            this.nonContactCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nonContactCheckBox.Location = new System.Drawing.Point(6, 19);
            this.nonContactCheckBox.Name = "nonContactCheckBox";
            this.nonContactCheckBox.Size = new System.Drawing.Size(143, 24);
            this.nonContactCheckBox.TabIndex = 33;
            this.nonContactCheckBox.Text = "Non-Contact (Username)";
            this.nonContactCheckBox.UseVisualStyleBackColor = true;
            this.nonContactCheckBox.CheckStateChanged += new System.EventHandler(this.UpdateNonContactTextBox);
            // 
            // addUserTextBox
            // 
            this.addUserTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserTextBox.Enabled = false;
            this.addUserTextBox.Location = new System.Drawing.Point(278, 34);
            this.addUserTextBox.MaxLength = 64;
            this.addUserTextBox.Name = "addUserTextBox";
            this.addUserTextBox.Size = new System.Drawing.Size(225, 20);
            this.addUserTextBox.TabIndex = 38;
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserButton.Enabled = false;
            this.addUserButton.Location = new System.Drawing.Point(6, 49);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 39;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUser);
            // 
            // addUserLabel
            // 
            this.addUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.Location = new System.Drawing.Point(278, 16);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(54, 13);
            this.addUserLabel.TabIndex = 40;
            this.addUserLabel.Text = "Add User:";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(6, 78);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 41;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearList);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(6, 107);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 42;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteSelected);
            // 
            // spammerGroupBox
            // 
            this.spammerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spammerGroupBox.Controls.Add(this.stopButton);
            this.spammerGroupBox.Controls.Add(this.addUserLabel);
            this.spammerGroupBox.Controls.Add(this.clearButton);
            this.spammerGroupBox.Controls.Add(this.addUserButton);
            this.spammerGroupBox.Controls.Add(this.deleteButton);
            this.spammerGroupBox.Controls.Add(this.freqUpDown);
            this.spammerGroupBox.Controls.Add(this.frequencyLabel);
            this.spammerGroupBox.Controls.Add(this.continuouslyCheckBox);
            this.spammerGroupBox.Controls.Add(this.sendButton);
            this.spammerGroupBox.Controls.Add(this.addUserTextBox);
            this.spammerGroupBox.Controls.Add(this.amountUpDown);
            this.spammerGroupBox.Controls.Add(this.amountLabel);
            this.spammerGroupBox.Controls.Add(this.nonContactCheckBox);
            this.spammerGroupBox.Location = new System.Drawing.Point(517, 313);
            this.spammerGroupBox.Name = "spammerGroupBox";
            this.spammerGroupBox.Size = new System.Drawing.Size(509, 136);
            this.spammerGroupBox.TabIndex = 59;
            this.spammerGroupBox.TabStop = false;
            this.spammerGroupBox.Text = "Spammer";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(87, 107);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(86, 23);
            this.stopButton.TabIndex = 43;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.Stop);
            // 
            // chatCommandsGroupBox
            // 
            this.chatCommandsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatCommandsGroupBox.Controls.Add(this.chatCommmandsLabel);
            this.chatCommandsGroupBox.Controls.Add(this.commandsDropDown);
            this.chatCommandsGroupBox.Controls.Add(this.optionsAndRolesExplainationTextBox);
            this.chatCommandsGroupBox.Controls.Add(this.commandExplainationTextBox);
            this.chatCommandsGroupBox.Controls.Add(this.optionsAndRolesDropDown);
            this.chatCommandsGroupBox.Controls.Add(this.rulesAndOptionsLabel);
            this.chatCommandsGroupBox.Location = new System.Drawing.Point(517, 8);
            this.chatCommandsGroupBox.Name = "chatCommandsGroupBox";
            this.chatCommandsGroupBox.Size = new System.Drawing.Size(213, 299);
            this.chatCommandsGroupBox.TabIndex = 60;
            this.chatCommandsGroupBox.TabStop = false;
            this.chatCommandsGroupBox.Text = "Chat Commands:";
            // 
            // spamProgressBar
            // 
            this.spamProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spamProgressBar.Location = new System.Drawing.Point(69, 428);
            this.spamProgressBar.Name = "spamProgressBar";
            this.spamProgressBar.Size = new System.Drawing.Size(442, 21);
            this.spamProgressBar.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Progress:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spamProgressBar);
            this.Controls.Add(this.chatCommandsGroupBox);
            this.Controls.Add(this.quoteGroupBox);
            this.Controls.Add(this.nonContactLabel);
            this.Controls.Add(this.nonContactsListBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.spammerGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 500);
            this.Name = "MainForm";
            this.Text = "Skype Spammer";
            this.quoteGroupBox.ResumeLayout(false);
            this.quoteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqUpDown)).EndInit();
            this.spammerGroupBox.ResumeLayout(false);
            this.spammerGroupBox.PerformLayout();
            this.chatCommandsGroupBox.ResumeLayout(false);
            this.chatCommandsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label messageLabel;
        private Timer sendTimer;
        private CheckedListBox usernameBox;
        private CheckedListBox nonContactsListBox;
        private Label nonContactLabel;
        private Button generateQuoteButton;
        private CheckBox useCurrentTimeCheckBox;
        private TextBox quoteMessageTextBox;
        private MaskedTextBox timeStampTextBox;
        private Label timeTextBox;
        private Label authorLabel;
        private Timer updateTimer;
        private ComboBox commandsDropDown;
        private Label chatCommmandsLabel;
        private TextBox commandExplainationTextBox;
        private TextBox authorTextBox;
        private Label rulesAndOptionsLabel;
        private ComboBox optionsAndRolesDropDown;
        private TextBox optionsAndRolesExplainationTextBox;
        private GroupBox quoteGroupBox;
        private NumericUpDown amountUpDown;
        private Label amountLabel;
        private CheckBox continuouslyCheckBox;
        private NumericUpDown freqUpDown;
        private Label frequencyLabel;
        private CheckBox nonContactCheckBox;
        private TextBox addUserTextBox;
        private Button addUserButton;
        private Label addUserLabel;
        private Button clearButton;
        private Button deleteButton;
        private GroupBox spammerGroupBox;
        private GroupBox chatCommandsGroupBox;
        private Label label1;

        private readonly string[] _commandListExplained =
        {
            "Describes an action of the user by printing his name followed by the action.",
            "Shows a list of available commands. It's incomplete but helps with general administrating tasks.",
            "Adds the user skypename to the chat.",
            "Leave the current chat (only if not creator).",
            "Sets a new topic to the chat.",
            "Looks for text in the chat history.",
            "Repeats the last search.",
            "/alertson text sets the skype notification to occour on special text in messages. /alertson resets it to the default. If an alert is set, every instance of the text will be highlighted in the chat window for easier detection of the alerting lines.",
            "Turns off all notifications for this chat.",
            "Loads the complete chat history into the active chat window.",
            "Generates a HTML file of the chats history and opens it in the browser. Skype 4: not iplemented in this version anymore.",
            "Clears the chat window.",
            "Shows number and limit of chat participants.",
            "Opens a call to skypename.",
            "Enters the administration mode of the chat (only if creator) and adds a small text Creator to the user-icon in the chat. I didn't find so far a way to leave this mode again. According to the Skype documentation the only effect is the Creator tag but I'm not so sure about that.",
            "Shows the creator of this chat.",
            "Shows the current role of the user.",
            "Shows some info of the user skypename, for example the current role.",
            "Sets roles of chat members. See below for more info.",
            "Removes skypename from the chat.",
            "Removes skypename from the chat and bans him.",
            "Shows the guidelines of this public chat.",
            "Sets the guidelines of this public chat.",
            "Shows the current active options for this chat.",
            "Sets options for this chat, see below for more info.",
            "Shows a list of users in the particular role.",
            "Sets a password for this public chat, no spaces allowed, and also a password hint in the same command.",
            "Removes the password for this public chat.",
            "Sets a password hint for this public chat.",
            "Shows the password hint for this public chat.",
            "Sets a password for this public chat, no spaces allowed.",
            "Bans members from this public chat.",
            "Shows all users which are banned to this public chat.",
            "Allows members to this public chat.",
            "Shows all users which are allowed to this public chat.",
            "Gets the URI link for this public chat which can then be sent to contacts or embedded in webpages.",
            "Reverts the last edit of a message.",
            "Outputs a list of (debug?) commands but without description.",
            "Lists all members of the chat with their currently assigned role.",
            "Prints some infos about the current conversation. Conversation convoi id, Consumption horizon, History date and Message count.",
            "Displays the current and maximum number of chat participants.",
            "Displays a list of the currently online Skype instances using this Skype name (and have Skype version >=6 or recent mobile versions).",
            "Logs out all other currently online Skype instances which are using this Skype name (and have Skype version >=6 or recent mobile versions).",
            "Shows the list of listeners set with previous command."
        };

        private readonly string[] _optionsAndRolesExplained =
        {
            "When this bit is off, new users cannot join the chat. This option has to be enabled before the options JOINERS_BECOME_APPLICANTS and JOINERS_BECOME_LISTENERS can be set. Also, this cannot be disabled while one of the JOINERS_BECOME_xxx options is still set.",
            "When this bit is on, new users will be able to join the chat but they will be unable to post or receive messages until authorized by one of the chat administrators (CREATOR or MASTER).",
            "When this bit is on, new users will be able to receive message in chat but unable to post until promoted to USER role. Basically a read-only flag for new users.",
            "When this bit is off, newly joined members can see chat history prior to their joining. Maximum amount of history backlog available is either 400 messages or 2 weeks of time, depending on which limit is reached first.",
            "Read-only flag for chat members with USER role.",
            "When this bit of options is off, USER level chat members can change chat topic and the topic picture.",
            "This appeared to me after setting and removing the USERS_ARE_LISTENERS in a chat, but I didn't recognize some changed behavior to the standard.",
            "Member who created the chat. There can be only one creator per chat. Only creator can promote other members to masters.",
            "Also known as chat hosts. Masters cannot promote other people to masters.",
            "A semi-privileged member. Helpers will not be affected by the USERS_ARE_LISTENERS option. Helpers cannot promote or demote other members",
            "Regular members who can post messages into the chat.",
            "A demoted member who can only receive messages but not post anything into the chat.",
            "A member waiting for acceptance into the chat. Member cannot be demoted to applicants once they have been accepted."
        };
        private ProgressBar spamProgressBar;
        private Button stopButton;
        private Label label2;
    }
}

