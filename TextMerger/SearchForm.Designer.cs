namespace TextMerger
{
    partial class SearchForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.datesGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.singleDatePicker = new System.Windows.Forms.DateTimePicker();
            this.singleDateCheckbox = new System.Windows.Forms.CheckBox();
            this.playerCheckBox = new System.Windows.Forms.CheckBox();
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.commandGroupBox = new System.Windows.Forms.GroupBox();
            this.commandCheckBox = new System.Windows.Forms.CheckBox();
            this.playerUUIDText = new System.Windows.Forms.TextBox();
            this.playerUUIDCheckbox = new System.Windows.Forms.CheckBox();
            this.playerUsernameCheckbox = new System.Windows.Forms.CheckBox();
            this.playerUsernameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.datesGroupBox.SuspendLayout();
            this.playerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(558, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 349);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(558, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.openFileBtn);
            this.groupBox2.Controls.Add(this.datesGroupBox);
            this.groupBox2.Controls.Add(this.singleDatePicker);
            this.groupBox2.Controls.Add(this.singleDateCheckbox);
            this.groupBox2.Controls.Add(this.playerCheckBox);
            this.groupBox2.Controls.Add(this.playerGroupBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 656);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Controls";
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.Gray;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openFileBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.openFileBtn.Location = new System.Drawing.Point(10, 22);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(86, 31);
            this.openFileBtn.TabIndex = 10;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // datesGroupBox
            // 
            this.datesGroupBox.Controls.Add(this.label3);
            this.datesGroupBox.Controls.Add(this.label2);
            this.datesGroupBox.Controls.Add(this.startDatePicker);
            this.datesGroupBox.Controls.Add(this.endDatePicker);
            this.datesGroupBox.Location = new System.Drawing.Point(10, 70);
            this.datesGroupBox.Name = "datesGroupBox";
            this.datesGroupBox.Size = new System.Drawing.Size(304, 80);
            this.datesGroupBox.TabIndex = 9;
            this.datesGroupBox.TabStop = false;
            this.datesGroupBox.Text = "Dates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start Date";
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.startDatePicker.Location = new System.Drawing.Point(6, 46);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(142, 23);
            this.startDatePicker.TabIndex = 2;
            this.startDatePicker.Value = new System.DateTime(2022, 2, 3, 16, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(154, 47);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(143, 23);
            this.endDatePicker.TabIndex = 5;
            // 
            // singleDatePicker
            // 
            this.singleDatePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.singleDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.singleDatePicker.Location = new System.Drawing.Point(320, 115);
            this.singleDatePicker.Name = "singleDatePicker";
            this.singleDatePicker.Size = new System.Drawing.Size(192, 23);
            this.singleDatePicker.TabIndex = 8;
            // 
            // singleDateCheckbox
            // 
            this.singleDateCheckbox.AutoSize = true;
            this.singleDateCheckbox.Location = new System.Drawing.Point(320, 90);
            this.singleDateCheckbox.Name = "singleDateCheckbox";
            this.singleDateCheckbox.Size = new System.Drawing.Size(85, 19);
            this.singleDateCheckbox.TabIndex = 7;
            this.singleDateCheckbox.Text = "Single Date";
            this.singleDateCheckbox.UseVisualStyleBackColor = true;
            this.singleDateCheckbox.CheckedChanged += new System.EventHandler(this.singleDateCheckbox_CheckedChanged);
            // 
            // playerCheckBox
            // 
            this.playerCheckBox.AutoSize = true;
            this.playerCheckBox.Location = new System.Drawing.Point(10, 166);
            this.playerCheckBox.Name = "playerCheckBox";
            this.playerCheckBox.Size = new System.Drawing.Size(58, 19);
            this.playerCheckBox.TabIndex = 6;
            this.playerCheckBox.Text = "Player";
            this.playerCheckBox.UseVisualStyleBackColor = true;
            this.playerCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.commandGroupBox);
            this.playerGroupBox.Controls.Add(this.commandCheckBox);
            this.playerGroupBox.Controls.Add(this.playerUUIDText);
            this.playerGroupBox.Controls.Add(this.playerUUIDCheckbox);
            this.playerGroupBox.Controls.Add(this.playerUsernameCheckbox);
            this.playerGroupBox.Controls.Add(this.playerUsernameText);
            this.playerGroupBox.Enabled = false;
            this.playerGroupBox.Location = new System.Drawing.Point(10, 191);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(506, 248);
            this.playerGroupBox.TabIndex = 1;
            this.playerGroupBox.TabStop = false;
            this.playerGroupBox.Text = "Player";
            // 
            // commandGroupBox
            // 
            this.commandGroupBox.Enabled = false;
            this.commandGroupBox.Location = new System.Drawing.Point(7, 94);
            this.commandGroupBox.Name = "commandGroupBox";
            this.commandGroupBox.Size = new System.Drawing.Size(493, 141);
            this.commandGroupBox.TabIndex = 5;
            this.commandGroupBox.TabStop = false;
            this.commandGroupBox.Text = "Command";
            // 
            // commandCheckBox
            // 
            this.commandCheckBox.AutoSize = true;
            this.commandCheckBox.Location = new System.Drawing.Point(6, 73);
            this.commandCheckBox.Name = "commandCheckBox";
            this.commandCheckBox.Size = new System.Drawing.Size(83, 19);
            this.commandCheckBox.TabIndex = 4;
            this.commandCheckBox.Text = "Command";
            this.commandCheckBox.UseVisualStyleBackColor = true;
            // 
            // playerUUIDText
            // 
            this.playerUUIDText.Enabled = false;
            this.playerUUIDText.Location = new System.Drawing.Point(89, 44);
            this.playerUUIDText.Name = "playerUUIDText";
            this.playerUUIDText.Size = new System.Drawing.Size(202, 23);
            this.playerUUIDText.TabIndex = 3;
            this.playerUUIDText.TextChanged += new System.EventHandler(this.playerUUIDText_TextChanged);
            // 
            // playerUUIDCheckbox
            // 
            this.playerUUIDCheckbox.AutoSize = true;
            this.playerUUIDCheckbox.Location = new System.Drawing.Point(6, 46);
            this.playerUUIDCheckbox.Name = "playerUUIDCheckbox";
            this.playerUUIDCheckbox.Size = new System.Drawing.Size(56, 19);
            this.playerUUIDCheckbox.TabIndex = 2;
            this.playerUUIDCheckbox.Text = "UUID:";
            this.playerUUIDCheckbox.UseVisualStyleBackColor = true;
            this.playerUUIDCheckbox.CheckedChanged += new System.EventHandler(this.playerUUIDCheckbox_CheckedChanged);
            // 
            // playerUsernameCheckbox
            // 
            this.playerUsernameCheckbox.AutoSize = true;
            this.playerUsernameCheckbox.Checked = true;
            this.playerUsernameCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playerUsernameCheckbox.Location = new System.Drawing.Point(6, 18);
            this.playerUsernameCheckbox.Name = "playerUsernameCheckbox";
            this.playerUsernameCheckbox.Size = new System.Drawing.Size(82, 19);
            this.playerUsernameCheckbox.TabIndex = 1;
            this.playerUsernameCheckbox.Text = "Username:";
            this.playerUsernameCheckbox.UseVisualStyleBackColor = true;
            this.playerUsernameCheckbox.CheckedChanged += new System.EventHandler(this.playerUsernameCheckbox_CheckedChanged);
            // 
            // playerUsernameText
            // 
            this.playerUsernameText.Location = new System.Drawing.Point(89, 16);
            this.playerUsernameText.Name = "playerUsernameText";
            this.playerUsernameText.Size = new System.Drawing.Size(203, 23);
            this.playerUsernameText.TabIndex = 0;
            this.playerUsernameText.TextChanged += new System.EventHandler(this.playerUsernameText_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(6, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(560, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Results";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1202, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.datesGroupBox.ResumeLayout(false);
            this.datesGroupBox.PerformLayout();
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker startDatePicker;
        private GroupBox playerGroupBox;
        private Button button1;
        private DateTimePicker endDatePicker;
        private CheckBox playerCheckBox;
        private DateTimePicker singleDatePicker;
        private CheckBox singleDateCheckbox;
        private Label label1;
        private GroupBox datesGroupBox;
        private Label label3;
        private Label label2;
        private TextBox playerUsernameText;
        private CheckBox playerUsernameCheckbox;
        private TextBox playerUUIDText;
        private CheckBox playerUUIDCheckbox;
        private GroupBox commandGroupBox;
        private CheckBox commandCheckBox;
        private Button openFileBtn;
    }
}