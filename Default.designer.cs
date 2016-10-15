namespace Telephone_Parser
{
    partial class Default
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exiitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.imgAddItem = new System.Windows.Forms.PictureBox();
            this.lblPhonebook = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDatabaseInit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.previewItemsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exiitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newItemToolStripMenuItem.Text = "Import to Database";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // previewItemsToolStripMenuItem
            // 
            this.previewItemsToolStripMenuItem.Name = "previewItemsToolStripMenuItem";
            this.previewItemsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.previewItemsToolStripMenuItem.Text = "Preview of calls";
            this.previewItemsToolStripMenuItem.Click += new System.EventHandler(this.previewItemsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // exiitToolStripMenuItem
            // 
            this.exiitToolStripMenuItem.Name = "exiitToolStripMenuItem";
            this.exiitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exiitToolStripMenuItem.Text = "Exit";
            this.exiitToolStripMenuItem.Click += new System.EventHandler(this.exiitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 179);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imgPreview
            // 
            this.imgPreview.Image = ((System.Drawing.Image)(resources.GetObject("imgPreview.Image")));
            this.imgPreview.Location = new System.Drawing.Point(37, 207);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(130, 134);
            this.imgPreview.TabIndex = 2;
            this.imgPreview.TabStop = false;
            this.imgPreview.Click += new System.EventHandler(this.imgPreview_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(55, 338);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(81, 13);
            this.lblPreview.TabIndex = 3;
            this.lblPreview.Text = "Preview of calls";
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItem.Location = new System.Drawing.Point(240, 338);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(97, 13);
            this.lblAddItem.TabIndex = 5;
            this.lblAddItem.Text = "Import to Database";
            // 
            // imgAddItem
            // 
            this.imgAddItem.Image = ((System.Drawing.Image)(resources.GetObject("imgAddItem.Image")));
            this.imgAddItem.Location = new System.Drawing.Point(221, 207);
            this.imgAddItem.Name = "imgAddItem";
            this.imgAddItem.Size = new System.Drawing.Size(130, 134);
            this.imgAddItem.TabIndex = 4;
            this.imgAddItem.TabStop = false;
            this.imgAddItem.Click += new System.EventHandler(this.imgAddItem_Click);
            // 
            // lblPhonebook
            // 
            this.lblPhonebook.AutoSize = true;
            this.lblPhonebook.BackColor = System.Drawing.Color.Transparent;
            this.lblPhonebook.Location = new System.Drawing.Point(443, 338);
            this.lblPhonebook.Name = "lblPhonebook";
            this.lblPhonebook.Size = new System.Drawing.Size(62, 13);
            this.lblPhonebook.TabIndex = 7;
            this.lblPhonebook.Text = "Phonebook";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(407, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 134);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnDatabaseInit
            // 
            this.btnDatabaseInit.Location = new System.Drawing.Point(475, 358);
            this.btnDatabaseInit.Name = "btnDatabaseInit";
            this.btnDatabaseInit.Size = new System.Drawing.Size(101, 23);
            this.btnDatabaseInit.TabIndex = 8;
            this.btnDatabaseInit.Text = "Database Init";
            this.btnDatabaseInit.UseVisualStyleBackColor = true;
            this.btnDatabaseInit.Click += new System.EventHandler(this.btnDatabaseInit_Click);
            // 
            // Default
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(576, 381);
            this.Controls.Add(this.btnDatabaseInit);
            this.Controls.Add(this.lblPhonebook);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAddItem);
            this.Controls.Add(this.imgAddItem);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Default";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Central - DMM";
            this.Load += new System.EventHandler(this.Default_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exiitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.PictureBox imgAddItem;
        private System.Windows.Forms.Label lblPhonebook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDatabaseInit;
    }
}