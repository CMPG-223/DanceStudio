
namespace CMPG223_18
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.gpbReports = new System.Windows.Forms.GroupBox();
            this.rdbOutPay = new System.Windows.Forms.RadioButton();
            this.rdbTop3Dance = new System.Windows.Forms.RadioButton();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExplain = new System.Windows.Forms.Label();
            this.ttChoose = new System.Windows.Forms.ToolTip(this.components);
            this.gpbReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(717, 375);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(82, 306);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(135, 20);
            this.dtpEndDate.TabIndex = 20;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(82, 291);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 19;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(82, 246);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(135, 20);
            this.dtpStartDate.TabIndex = 18;
            this.dtpStartDate.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // gpbReports
            // 
            this.gpbReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbReports.Controls.Add(this.rdbOutPay);
            this.gpbReports.Controls.Add(this.rdbTop3Dance);
            this.gpbReports.Location = new System.Drawing.Point(44, 51);
            this.gpbReports.Margin = new System.Windows.Forms.Padding(2);
            this.gpbReports.Name = "gpbReports";
            this.gpbReports.Padding = new System.Windows.Forms.Padding(2);
            this.gpbReports.Size = new System.Drawing.Size(227, 105);
            this.gpbReports.TabIndex = 17;
            this.gpbReports.TabStop = false;
            this.gpbReports.Text = "Please choose what report you want to see";
            this.ttChoose.SetToolTip(this.gpbReports, "Choose what report you want to see here");
            // 
            // rdbOutPay
            // 
            this.rdbOutPay.AutoSize = true;
            this.rdbOutPay.Location = new System.Drawing.Point(5, 58);
            this.rdbOutPay.Margin = new System.Windows.Forms.Padding(2);
            this.rdbOutPay.Name = "rdbOutPay";
            this.rdbOutPay.Size = new System.Drawing.Size(130, 17);
            this.rdbOutPay.TabIndex = 1;
            this.rdbOutPay.TabStop = true;
            this.rdbOutPay.Text = "Outstanding payments";
            this.rdbOutPay.UseVisualStyleBackColor = true;
            this.rdbOutPay.CheckedChanged += new System.EventHandler(this.rdbTop3Dance_CheckedChanged);
            // 
            // rdbTop3Dance
            // 
            this.rdbTop3Dance.AutoSize = true;
            this.rdbTop3Dance.Location = new System.Drawing.Point(5, 27);
            this.rdbTop3Dance.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTop3Dance.Name = "rdbTop3Dance";
            this.rdbTop3Dance.Size = new System.Drawing.Size(93, 17);
            this.rdbTop3Dance.TabIndex = 0;
            this.rdbTop3Dance.TabStop = true;
            this.rdbTop3Dance.Text = "Top 3 Dances";
            this.rdbTop3Dance.UseVisualStyleBackColor = true;
            this.rdbTop3Dance.CheckedChanged += new System.EventHandler(this.rdbTop3Dance_CheckedChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(82, 231);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 16;
            this.lblStartDate.Text = "Start Date";
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Alphabetical (A-Z)",
            "Alphabetical (Z-A)",
            "Most in debt",
            "Least in debt"});
            this.cmbSortBy.Location = new System.Drawing.Point(82, 190);
            this.cmbSortBy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(135, 21);
            this.cmbSortBy.TabIndex = 15;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(80, 175);
            this.lblSort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(41, 13);
            this.lblSort.TabIndex = 14;
            this.lblSort.Text = "Sort By";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToOrderColumns = true;
            this.dgvReports.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(371, 51);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.Size = new System.Drawing.Size(281, 313);
            this.dgvReports.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.OldLace;
            this.btnExport.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(720, 48);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(56, 20);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Print Report";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Explanation:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Location = new System.Drawing.Point(720, 152);
            this.lblExplain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(65, 13);
            this.lblExplain.TabIndex = 24;
            this.lblExplain.Text = "Explanation:";
            // 
            // ttChoose
            // 
            this.ttChoose.Tag = "Choose either of the buttons to get that report";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(910, 429);
            this.Controls.Add(this.lblExplain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.gpbReports);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.gpbReports.ResumeLayout(false);
            this.gpbReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox gpbReports;
        private System.Windows.Forms.RadioButton rdbOutPay;
        private System.Windows.Forms.RadioButton rdbTop3Dance;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.ToolTip ttChoose;
    }
}