namespace SQLite_Browser
{
    partial class MainForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPageNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.tbPageNumber = new System.Windows.Forms.TextBox();
            this.tbHashes = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 72;
            this.dgv.RowTemplate.Height = 37;
            this.dgv.Size = new System.Drawing.Size(834, 426);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hash ID";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SHA1";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 600;
            // 
            // nbPageNumber
            // 
            this.nbPageNumber.Location = new System.Drawing.Point(12, 496);
            this.nbPageNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbPageNumber.Name = "nbPageNumber";
            this.nbPageNumber.Size = new System.Drawing.Size(147, 35);
            this.nbPageNumber.TabIndex = 3;
            this.nbPageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "View Page";
            // 
            // btnViewPage
            // 
            this.btnViewPage.Location = new System.Drawing.Point(12, 537);
            this.btnViewPage.Name = "btnViewPage";
            this.btnViewPage.Size = new System.Drawing.Size(147, 40);
            this.btnViewPage.TabIndex = 5;
            this.btnViewPage.Text = "View Page";
            this.btnViewPage.UseVisualStyleBackColor = true;
            this.btnViewPage.Click += new System.EventHandler(this.btnViewPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(180, 444);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(131, 40);
            this.btnFirstPage.TabIndex = 6;
            this.btnFirstPage.Text = "First Page";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(715, 444);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(131, 40);
            this.btnLastPage.TabIndex = 7;
            this.btnLastPage.Text = "Last Page";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(317, 444);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(193, 40);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.Text = "Next Page ->";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(516, 444);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(193, 40);
            this.btnPreviousPage.TabIndex = 9;
            this.btnPreviousPage.Text = "<- Previous Page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // tbPageNumber
            // 
            this.tbPageNumber.Enabled = false;
            this.tbPageNumber.Location = new System.Drawing.Point(317, 490);
            this.tbPageNumber.Multiline = true;
            this.tbPageNumber.Name = "tbPageNumber";
            this.tbPageNumber.Size = new System.Drawing.Size(392, 40);
            this.tbPageNumber.TabIndex = 10;
            this.tbPageNumber.Text = "Page 0/0";
            this.tbPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHashes
            // 
            this.tbHashes.Location = new System.Drawing.Point(12, 629);
            this.tbHashes.Multiline = true;
            this.tbHashes.Name = "tbHashes";
            this.tbHashes.Size = new System.Drawing.Size(834, 192);
            this.tbHashes.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 583);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(833, 40);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Check If Hashes Exist";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 833);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbHashes);
            this.Controls.Add(this.tbPageNumber);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnViewPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbPageNumber);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "SQLite Browser";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPageNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private NumericUpDown nbPageNumber;
        private Label label2;
        private Button btnViewPage;
        private Button btnFirstPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private TextBox tbPageNumber;
        private TextBox tbHashes;
        private Button btnSearch;
    }
}