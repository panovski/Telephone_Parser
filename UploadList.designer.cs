namespace Telephone_Parser
{
    partial class UploadList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadList));
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.progressBarUpload = new System.Windows.Forms.ProgressBar();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.imgAddItem = new System.Windows.Forms.PictureBox();
            this.tbImportFile = new Telephone_Parser.UserControls.TextBoxCaption();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.progressBarUpload);
            this.gbInsert.Controls.Add(this.btnChoseFile);
            this.gbInsert.Controls.Add(this.btnUpload);
            this.gbInsert.Controls.Add(this.btnDodadi);
            this.gbInsert.Controls.Add(this.imgAddItem);
            this.gbInsert.Controls.Add(this.tbImportFile);
            this.gbInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInsert.Location = new System.Drawing.Point(0, 0);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(501, 107);
            this.gbInsert.TabIndex = 0;
            this.gbInsert.TabStop = false;
            // 
            // progressBarUpload
            // 
            this.progressBarUpload.Location = new System.Drawing.Point(117, 45);
            this.progressBarUpload.Name = "progressBarUpload";
            this.progressBarUpload.Size = new System.Drawing.Size(375, 19);
            this.progressBarUpload.TabIndex = 21;
            this.progressBarUpload.Visible = false;
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChoseFile.Location = new System.Drawing.Point(468, 17);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(24, 23);
            this.btnChoseFile.TabIndex = 20;
            this.btnChoseFile.Text = "...";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUpload.Location = new System.Drawing.Point(398, 70);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(95, 25);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodadi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodadi.Image = ((System.Drawing.Image)(resources.GetObject("btnDodadi.Image")));
            this.btnDodadi.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDodadi.Location = new System.Drawing.Point(398, 70);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(95, 25);
            this.btnDodadi.TabIndex = 18;
            this.btnDodadi.Text = "Insert";
            this.btnDodadi.UseVisualStyleBackColor = true;
            // 
            // imgAddItem
            // 
            this.imgAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgAddItem.BackgroundImage")));
            this.imgAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAddItem.Location = new System.Drawing.Point(6, 9);
            this.imgAddItem.Name = "imgAddItem";
            this.imgAddItem.Size = new System.Drawing.Size(85, 82);
            this.imgAddItem.TabIndex = 15;
            this.imgAddItem.TabStop = false;
            // 
            // tbImportFile
            // 
            this.tbImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImportFile.Caption = "Import File";
            this.tbImportFile.IsNumber = 0;
            this.tbImportFile.IsUpper = 0;
            this.tbImportFile.Location = new System.Drawing.Point(117, 19);
            this.tbImportFile.Name = "tbImportFile";
            this.tbImportFile.Size = new System.Drawing.Size(350, 20);
            this.tbImportFile.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.csv|";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // UploadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 107);
            this.Controls.Add(this.gbInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "UploadList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload list to database";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.gbInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.PictureBox imgAddItem;
        public System.Windows.Forms.Button btnUpload;
        public System.Windows.Forms.Button btnDodadi;
        public UserControls.TextBoxCaption tbImportFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.ProgressBar progressBarUpload;
    }
}