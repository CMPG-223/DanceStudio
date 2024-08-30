//kyk of dit onder my branch verksyn
namespace CMPG223_18
{
    partial class frmPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtDancerFName = new System.Windows.Forms.TextBox();
            this.dtpDatePaid = new System.Windows.Forms.DateTimePicker();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblPayNow = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDancerLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttAdd = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLSearch = new System.Windows.Forms.TextBox();
            this.txtFSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPaid = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaid)).BeginInit();
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
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(788, 375);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(213, 52);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 62;
            this.dgvPayments.RowTemplate.Height = 28;
            this.dgvPayments.Size = new System.Drawing.Size(631, 312);
            this.dgvPayments.TabIndex = 12;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(40, 200);
            this.txtPay.Margin = new System.Windows.Forms.Padding(2);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(135, 20);
            this.txtPay.TabIndex = 22;
            this.txtPay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPay_KeyDown);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(36, 43);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(95, 13);
            this.lblFName.TabIndex = 14;
            this.lblFName.Text = "Dancer First Name";
            // 
            // txtDancerFName
            // 
            this.txtDancerFName.Location = new System.Drawing.Point(39, 58);
            this.txtDancerFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDancerFName.Name = "txtDancerFName";
            this.txtDancerFName.Size = new System.Drawing.Size(135, 20);
            this.txtDancerFName.TabIndex = 15;
            this.txtDancerFName.TextChanged += new System.EventHandler(this.txtDancerFName_TextChanged);
            this.txtDancerFName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDancerFName_KeyDown);
            // 
            // dtpDatePaid
            // 
            this.dtpDatePaid.Location = new System.Drawing.Point(39, 148);
            this.dtpDatePaid.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatePaid.Name = "dtpDatePaid";
            this.dtpDatePaid.Size = new System.Drawing.Size(135, 20);
            this.dtpDatePaid.TabIndex = 16;
            this.dtpDatePaid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDatePaid_MouseDown);
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.Location = new System.Drawing.Point(36, 133);
            this.lblDatePaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(54, 13);
            this.lblDatePaid.TabIndex = 17;
            this.lblDatePaid.Text = "Date Paid";
            // 
            // lblPayNow
            // 
            this.lblPayNow.AutoSize = true;
            this.lblPayNow.Location = new System.Drawing.Point(40, 184);
            this.lblPayNow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayNow.Name = "lblPayNow";
            this.lblPayNow.Size = new System.Drawing.Size(28, 13);
            this.lblPayNow.TabIndex = 19;
            this.lblPayNow.Text = "Paid";
            this.lblPayNow.Click += new System.EventHandler(this.lblPayNow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.OldLace;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(37, 295);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 32);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.ttAdd.SetToolTip(this.btnAdd, "Click here to save the payment details");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDancerLName
            // 
            this.txtDancerLName.Location = new System.Drawing.Point(39, 104);
            this.txtDancerLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDancerLName.Name = "txtDancerLName";
            this.txtDancerLName.Size = new System.Drawing.Size(135, 20);
            this.txtDancerLName.TabIndex = 25;
            this.txtDancerLName.TextChanged += new System.EventHandler(this.txtDancerLName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dancer Last Name";
            // 
            // ttAdd
            // 
            this.ttAdd.Tag = "Click here when you are done filling in all the information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLSearch);
            this.groupBox1.Controls.Add(this.txtFSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(888, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtLSearch
            // 
            this.txtLSearch.Location = new System.Drawing.Point(38, 89);
            this.txtLSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtLSearch.Name = "txtLSearch";
            this.txtLSearch.Size = new System.Drawing.Size(127, 20);
            this.txtLSearch.TabIndex = 27;
            this.txtLSearch.TextChanged += new System.EventHandler(this.txtLSearch_TextChanged);
            // 
            // txtFSearch
            // 
            this.txtFSearch.Location = new System.Drawing.Point(38, 42);
            this.txtFSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtFSearch.Name = "txtFSearch";
            this.txtFSearch.Size = new System.Drawing.Size(127, 20);
            this.txtFSearch.TabIndex = 26;
            this.txtFSearch.TextChanged += new System.EventHandler(this.txtFSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "First Name";
            // 
            // ErrorFName
            // 
            this.ErrorFName.ContainerControl = this;
            // 
            // errorLName
            // 
            this.errorLName.ContainerControl = this;
            // 
            // errorPaid
            // 
            this.errorPaid.ContainerControl = this;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1110, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDancerLName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.lblPayNow);
            this.Controls.Add(this.lblDatePaid);
            this.Controls.Add(this.dtpDatePaid);
            this.Controls.Add(this.txtDancerFName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtDancerFName;
        private System.Windows.Forms.DateTimePicker dtpDatePaid;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblPayNow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDancerLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLSearch;
        private System.Windows.Forms.TextBox txtFSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider ErrorFName;
        private System.Windows.Forms.ErrorProvider errorLName;
        private System.Windows.Forms.ErrorProvider errorPaid;
    }
}