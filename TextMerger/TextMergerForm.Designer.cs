namespace TextMerger
{
    partial class TextMergerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextMergerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.extensionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.outputFolderBtn = new System.Windows.Forms.Button();
            this.inputFolderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(148, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Merger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(46, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "File extension:";
            // 
            // extensionText
            // 
            this.extensionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.extensionText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extensionText.ForeColor = System.Drawing.Color.Silver;
            this.extensionText.Location = new System.Drawing.Point(325, 157);
            this.extensionText.Name = "extensionText";
            this.extensionText.Size = new System.Drawing.Size(199, 50);
            this.extensionText.TabIndex = 2;
            this.extensionText.Text = "log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(46, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "New file name:";
            // 
            // filenameBox
            // 
            this.filenameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filenameBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filenameBox.ForeColor = System.Drawing.Color.Silver;
            this.filenameBox.Location = new System.Drawing.Point(325, 237);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(322, 50);
            this.filenameBox.TabIndex = 4;
            this.filenameBox.Text = "merged";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(496, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Merge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\nickw\\Desktop";
            // 
            // outputFolderBtn
            // 
            this.outputFolderBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputFolderBtn.Location = new System.Drawing.Point(267, 397);
            this.outputFolderBtn.Name = "outputFolderBtn";
            this.outputFolderBtn.Size = new System.Drawing.Size(223, 54);
            this.outputFolderBtn.TabIndex = 6;
            this.outputFolderBtn.Text = "Select Output Folder";
            this.outputFolderBtn.UseVisualStyleBackColor = true;
            this.outputFolderBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputFolderBtn
            // 
            this.inputFolderBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputFolderBtn.Location = new System.Drawing.Point(54, 397);
            this.inputFolderBtn.Name = "inputFolderBtn";
            this.inputFolderBtn.Size = new System.Drawing.Size(207, 54);
            this.inputFolderBtn.TabIndex = 7;
            this.inputFolderBtn.Text = "Choose Folder";
            this.inputFolderBtn.UseVisualStyleBackColor = true;
            this.inputFolderBtn.Click += new System.EventHandler(this.folderChosen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(710, 491);
            this.Controls.Add(this.inputFolderBtn);
            this.Controls.Add(this.outputFolderBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.extensionText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Text Merger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox extensionText;
        private Label label3;
        private TextBox filenameBox;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button outputFolderBtn;
        private Button inputFolderBtn;
    }
}