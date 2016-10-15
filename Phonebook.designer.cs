namespace Telephone_Parser
{
    partial class Phonebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phonebook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCaller = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.outlookGrid1 = new OutlookStyleControls.OutlookGrid();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.gvPreview = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbCommands = new System.Windows.Forms.GroupBox();
            this.btnInsertPhonebook = new System.Windows.Forms.Button();
            this.lblSumAmountVat = new System.Windows.Forms.Label();
            this.lblSumAmount = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblNoRows = new System.Windows.Forms.Label();
            this.Spliter = new System.Windows.Forms.GroupBox();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlookGrid1)).BeginInit();
            this.gbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreview)).BeginInit();
            this.gbCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.tbLastName);
            this.gbFilter.Controls.Add(this.pictureBox1);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.lblCaller);
            this.gbFilter.Controls.Add(this.tbFirstName);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(857, 69);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(167, 43);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(594, 20);
            this.tbLastName.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSearch.Location = new System.Drawing.Point(768, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCaller
            // 
            this.lblCaller.AutoSize = true;
            this.lblCaller.Location = new System.Drawing.Point(104, 23);
            this.lblCaller.Name = "lblCaller";
            this.lblCaller.Size = new System.Drawing.Size(57, 13);
            this.lblCaller.TabIndex = 1;
            this.lblCaller.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(167, 20);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(594, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // outlookGrid1
            // 
            this.outlookGrid1.AllowUserToAddRows = false;
            this.outlookGrid1.AllowUserToDeleteRows = false;
            this.outlookGrid1.CollapseIcon = ((System.Drawing.Image)(resources.GetObject("outlookGrid1.CollapseIcon")));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.outlookGrid1.DefaultCellStyle = dataGridViewCellStyle1;
            this.outlookGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlookGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.outlookGrid1.ExpandIcon = ((System.Drawing.Image)(resources.GetObject("outlookGrid1.ExpandIcon")));
            this.outlookGrid1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outlookGrid1.Location = new System.Drawing.Point(3, 16);
            this.outlookGrid1.Name = "outlookGrid1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outlookGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.outlookGrid1.RowHeadersWidth = 50;
            this.outlookGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outlookGrid1.Size = new System.Drawing.Size(851, 195);
            this.outlookGrid1.TabIndex = 0;
            this.outlookGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outlookGrid1_CellClick);
            this.outlookGrid1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.outlookGrid1_CellMouseDoubleClick);
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.outlookGrid1);
            this.gbPreview.Controls.Add(this.gvPreview);
            this.gbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreview.Location = new System.Drawing.Point(0, 69);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(857, 214);
            this.gbPreview.TabIndex = 3;
            this.gbPreview.TabStop = false;
            // 
            // gvPreview
            // 
            this.gvPreview.AllowUserToAddRows = false;
            this.gvPreview.AllowUserToDeleteRows = false;
            this.gvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPreview.Location = new System.Drawing.Point(3, 16);
            this.gvPreview.Name = "gvPreview";
            this.gvPreview.ReadOnly = true;
            this.gvPreview.Size = new System.Drawing.Size(851, 195);
            this.gvPreview.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbCommands
            // 
            this.gbCommands.Controls.Add(this.btnInsertPhonebook);
            this.gbCommands.Controls.Add(this.lblSumAmountVat);
            this.gbCommands.Controls.Add(this.lblSumAmount);
            this.gbCommands.Controls.Add(this.btnExcel);
            this.gbCommands.Controls.Add(this.lblNoRows);
            this.gbCommands.Controls.Add(this.Spliter);
            this.gbCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCommands.Location = new System.Drawing.Point(0, 283);
            this.gbCommands.Name = "gbCommands";
            this.gbCommands.Size = new System.Drawing.Size(857, 63);
            this.gbCommands.TabIndex = 5;
            this.gbCommands.TabStop = false;
            // 
            // btnInsertPhonebook
            // 
            this.btnInsertPhonebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsertPhonebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsertPhonebook.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInsertPhonebook.Location = new System.Drawing.Point(150, 32);
            this.btnInsertPhonebook.Name = "btnInsertPhonebook";
            this.btnInsertPhonebook.Size = new System.Drawing.Size(137, 25);
            this.btnInsertPhonebook.TabIndex = 19;
            this.btnInsertPhonebook.Text = "Insert into Phonebook";
            this.btnInsertPhonebook.UseVisualStyleBackColor = true;
            this.btnInsertPhonebook.Click += new System.EventHandler(this.btnInsertPhonebook_Click);
            // 
            // lblSumAmountVat
            // 
            this.lblSumAmountVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumAmountVat.AutoSize = true;
            this.lblSumAmountVat.Location = new System.Drawing.Point(493, 9);
            this.lblSumAmountVat.Name = "lblSumAmountVat";
            this.lblSumAmountVat.Size = new System.Drawing.Size(0, 13);
            this.lblSumAmountVat.TabIndex = 18;
            this.lblSumAmountVat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSumAmount
            // 
            this.lblSumAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumAmount.AutoSize = true;
            this.lblSumAmount.Location = new System.Drawing.Point(321, 10);
            this.lblSumAmount.Name = "lblSumAmount";
            this.lblSumAmount.Size = new System.Drawing.Size(0, 13);
            this.lblSumAmount.TabIndex = 17;
            this.lblSumAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExcel.Location = new System.Drawing.Point(7, 32);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(137, 25);
            this.btnExcel.TabIndex = 16;
            this.btnExcel.Text = "Export to MS Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblNoRows
            // 
            this.lblNoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoRows.AutoSize = true;
            this.lblNoRows.Location = new System.Drawing.Point(709, 10);
            this.lblNoRows.Name = "lblNoRows";
            this.lblNoRows.Size = new System.Drawing.Size(0, 13);
            this.lblNoRows.TabIndex = 13;
            this.lblNoRows.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Spliter
            // 
            this.Spliter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spliter.Location = new System.Drawing.Point(4, 19);
            this.Spliter.Name = "Spliter";
            this.Spliter.Size = new System.Drawing.Size(850, 10);
            this.Spliter.TabIndex = 12;
            this.Spliter.TabStop = false;
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 346);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.gbCommands);
            this.Controls.Add(this.gbFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Phonebook";
            this.Text = "Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Phonebook_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Preview_KeyPress);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlookGrid1)).EndInit();
            this.gbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPreview)).EndInit();
            this.gbCommands.ResumeLayout(false);
            this.gbCommands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OutlookStyleControls.OutlookGrid outlookGrid1;

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.Label lblCaller;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gvPreview;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbCommands;
        private System.Windows.Forms.Label lblNoRows;
        private System.Windows.Forms.GroupBox Spliter;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblSumAmount;
        private System.Windows.Forms.Label lblSumAmountVat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnInsertPhonebook;

    }
}