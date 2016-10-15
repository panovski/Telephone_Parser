namespace Telephone_Parser
{
    partial class Phonebook_Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phonebook_Upload));
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.gbUpload = new System.Windows.Forms.GroupBox();
            this.progressBarUpload = new System.Windows.Forms.ProgressBar();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.tbImportFile = new Telephone_Parser.UserControls.TextBoxCaption();
            this.btnUpload = new System.Windows.Forms.Button();
            this.imgAddItem = new System.Windows.Forms.PictureBox();
            this.gbInsertOne = new System.Windows.Forms.GroupBox();
            this.tbPhoneNumber = new Telephone_Parser.UserControls.TextBoxCaption();
            this.tbFirstName = new Telephone_Parser.UserControls.TextBoxCaption();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbLastName = new Telephone_Parser.UserControls.TextBoxCaption();
            this.cbPhoneType = new System.Windows.Forms.ComboBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbInsert.SuspendLayout();
            this.gbUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).BeginInit();
            this.gbInsertOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.gbUpload);
            this.gbInsert.Controls.Add(this.gbInsertOne);
            this.gbInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInsert.Location = new System.Drawing.Point(0, 0);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(505, 275);
            this.gbInsert.TabIndex = 0;
            this.gbInsert.TabStop = false;
            // 
            // gbUpload
            // 
            this.gbUpload.Controls.Add(this.progressBarUpload);
            this.gbUpload.Controls.Add(this.btnChoseFile);
            this.gbUpload.Controls.Add(this.tbImportFile);
            this.gbUpload.Controls.Add(this.btnUpload);
            this.gbUpload.Controls.Add(this.imgAddItem);
            this.gbUpload.Location = new System.Drawing.Point(6, 12);
            this.gbUpload.Name = "gbUpload";
            this.gbUpload.Size = new System.Drawing.Size(493, 113);
            this.gbUpload.TabIndex = 21;
            this.gbUpload.TabStop = false;
            this.gbUpload.Text = "Upload from Excel";
            // 
            // progressBarUpload
            // 
            this.progressBarUpload.Location = new System.Drawing.Point(103, 76);
            this.progressBarUpload.Name = "progressBarUpload";
            this.progressBarUpload.Size = new System.Drawing.Size(375, 19);
            this.progressBarUpload.TabIndex = 26;
            this.progressBarUpload.Visible = false;
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChoseFile.Location = new System.Drawing.Point(453, 17);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(24, 23);
            this.btnChoseFile.TabIndex = 25;
            this.btnChoseFile.Text = "...";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // tbImportFile
            // 
            this.tbImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImportFile.Caption = "Import File";
            this.tbImportFile.IsNumber = 0;
            this.tbImportFile.IsUpper = 0;
            this.tbImportFile.Location = new System.Drawing.Point(102, 19);
            this.tbImportFile.Name = "tbImportFile";
            this.tbImportFile.Size = new System.Drawing.Size(350, 20);
            this.tbImportFile.TabIndex = 22;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUpload.Location = new System.Drawing.Point(383, 45);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(95, 25);
            this.btnUpload.TabIndex = 24;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // imgAddItem
            // 
            this.imgAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgAddItem.BackgroundImage")));
            this.imgAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAddItem.Location = new System.Drawing.Point(6, 19);
            this.imgAddItem.Name = "imgAddItem";
            this.imgAddItem.Size = new System.Drawing.Size(85, 82);
            this.imgAddItem.TabIndex = 15;
            this.imgAddItem.TabStop = false;
            // 
            // gbInsertOne
            // 
            this.gbInsertOne.Controls.Add(this.tbPhoneNumber);
            this.gbInsertOne.Controls.Add(this.tbFirstName);
            this.gbInsertOne.Controls.Add(this.btnInsert);
            this.gbInsertOne.Controls.Add(this.tbLastName);
            this.gbInsertOne.Controls.Add(this.cbPhoneType);
            this.gbInsertOne.Controls.Add(this.lblPhoneType);
            this.gbInsertOne.Location = new System.Drawing.Point(6, 131);
            this.gbInsertOne.Name = "gbInsertOne";
            this.gbInsertOne.Size = new System.Drawing.Size(493, 138);
            this.gbInsertOne.TabIndex = 20;
            this.gbInsertOne.TabStop = false;
            this.gbInsertOne.Text = "Insert one contact";
            this.gbInsertOne.Enter += new System.EventHandler(this.gbInsertOne_Enter);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneNumber.Caption = "Phone Number (38943551-)";
            this.tbPhoneNumber.IsNumber = 1;
            this.tbPhoneNumber.IsUpper = 0;
            this.tbPhoneNumber.Location = new System.Drawing.Point(6, 82);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(472, 20);
            this.tbPhoneNumber.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Caption = "First Name";
            this.tbFirstName.IsNumber = 0;
            this.tbFirstName.IsUpper = 0;
            this.tbFirstName.Location = new System.Drawing.Point(101, 41);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(377, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInsert.Location = new System.Drawing.Point(383, 107);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 25);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Caption = "Last Name";
            this.tbLastName.IsNumber = 0;
            this.tbLastName.IsUpper = 0;
            this.tbLastName.Location = new System.Drawing.Point(101, 62);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(377, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // cbPhoneType
            // 
            this.cbPhoneType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPhoneType.FormattingEnabled = true;
            this.cbPhoneType.Items.AddRange(new object[] {
            "Fixed phones",
            "Dect phones"});
            this.cbPhoneType.Location = new System.Drawing.Point(167, 19);
            this.cbPhoneType.Name = "cbPhoneType";
            this.cbPhoneType.Size = new System.Drawing.Size(311, 21);
            this.cbPhoneType.TabIndex = 0;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneType.Location = new System.Drawing.Point(98, 22);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(68, 15);
            this.lblPhoneType.TabIndex = 12;
            this.lblPhoneType.Text = "Phone type";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*xlsx|";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Phonebook_Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 275);
            this.Controls.Add(this.gbInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Phonebook_Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert into Phonebook";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.gbInsert.ResumeLayout(false);
            this.gbUpload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).EndInit();
            this.gbInsertOne.ResumeLayout(false);
            this.gbInsertOne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.PictureBox imgAddItem;
        public System.Windows.Forms.Button btnInsert;
        public UserControls.TextBoxCaption tbFirstName;
        public UserControls.TextBoxCaption tbPhoneNumber;
        public UserControls.TextBoxCaption tbLastName;
        public System.Windows.Forms.ComboBox cbPhoneType;
        private System.Windows.Forms.GroupBox gbUpload;
        private System.Windows.Forms.GroupBox gbInsertOne;
        private System.Windows.Forms.ProgressBar progressBarUpload;
        private System.Windows.Forms.Button btnChoseFile;
        public System.Windows.Forms.Button btnUpload;
        public UserControls.TextBoxCaption tbImportFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}