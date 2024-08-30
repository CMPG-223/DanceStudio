
namespace CMPG223_18
{
    partial class frmDancers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDancers));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtDancerID = new System.Windows.Forms.TextBox();
            this.lblDancerID = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.grpExpLvl = new System.Windows.Forms.GroupBox();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.dgvDancers = new System.Windows.Forms.DataGridView();
            this.lblDataGrid = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtDFName = new System.Windows.Forms.TextBox();
            this.txtDLName = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.ttComplete = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLSearch = new System.Windows.Forms.TextBox();
            this.txtFSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.LNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.DancerIDError = new System.Windows.Forms.ErrorProvider(this.components);
            this.DoBError = new System.Windows.Forms.ErrorProvider(this.components);
            this.radError = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpExpLvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDancers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DancerIDError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoBError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(539, 423);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtDancerID
            // 
            this.txtDancerID.Location = new System.Drawing.Point(56, 216);
            this.txtDancerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtDancerID.Name = "txtDancerID";
            this.txtDancerID.Size = new System.Drawing.Size(127, 20);
            this.txtDancerID.TabIndex = 14;
            this.txtDancerID.TextChanged += new System.EventHandler(this.txtDancerID_TextChanged);
            this.txtDancerID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDancerID_KeyDown);
            this.txtDancerID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDancerID_KeyUp);
            // 
            // lblDancerID
            // 
            this.lblDancerID.AutoSize = true;
            this.lblDancerID.Location = new System.Drawing.Point(53, 201);
            this.lblDancerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDancerID.Name = "lblDancerID";
            this.lblDancerID.Size = new System.Drawing.Size(56, 13);
            this.lblDancerID.TabIndex = 13;
            this.lblDancerID.Text = "Dancer ID";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(53, 254);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 14;
            this.lblFName.Text = "First Name";
            // 
            // dtpDOB
            // 
            this.dtpDOB.AutoSize = true;
            this.dtpDOB.Location = new System.Drawing.Point(53, 348);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(65, 13);
            this.dtpDOB.TabIndex = 15;
            this.dtpDOB.Text = "Date of birth";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(53, 301);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 16;
            this.lblLName.Text = "Last Name";
            // 
            // grpExpLvl
            // 
            this.grpExpLvl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpExpLvl.Controls.Add(this.rdbDelete);
            this.grpExpLvl.Controls.Add(this.rdbUpdate);
            this.grpExpLvl.Controls.Add(this.rdbAdd);
            this.grpExpLvl.Location = new System.Drawing.Point(40, 45);
            this.grpExpLvl.Margin = new System.Windows.Forms.Padding(2);
            this.grpExpLvl.Name = "grpExpLvl";
            this.grpExpLvl.Padding = new System.Windows.Forms.Padding(2);
            this.grpExpLvl.Size = new System.Drawing.Size(167, 133);
            this.grpExpLvl.TabIndex = 17;
            this.grpExpLvl.TabStop = false;
            this.grpExpLvl.Text = "Select Action";
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(14, 93);
            this.rdbDelete.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(94, 17);
            this.rdbDelete.TabIndex = 2;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Delete Dancer";
            this.rdbDelete.UseVisualStyleBackColor = true;
            this.rdbDelete.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(14, 64);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(98, 17);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Dancer";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(14, 36);
            this.rdbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(82, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Dancer";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // dgvDancers
            // 
            this.dgvDancers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDancers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDancers.Location = new System.Drawing.Point(274, 64);
            this.dgvDancers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDancers.Name = "dgvDancers";
            this.dgvDancers.RowHeadersWidth = 62;
            this.dgvDancers.RowTemplate.Height = 28;
            this.dgvDancers.Size = new System.Drawing.Size(557, 237);
            this.dgvDancers.TabIndex = 18;
            this.dgvDancers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDancers_CellContentClick);
            this.dgvDancers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDancers_MouseDown);
            // 
            // lblDataGrid
            // 
            this.lblDataGrid.AutoSize = true;
            this.lblDataGrid.Location = new System.Drawing.Point(271, 45);
            this.lblDataGrid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataGrid.Name = "lblDataGrid";
            this.lblDataGrid.Size = new System.Drawing.Size(47, 13);
            this.lblDataGrid.TabIndex = 19;
            this.lblDataGrid.Text = "Dancers";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.OldLace;
            this.btnComplete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(319, 353);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(137, 32);
            this.btnComplete.TabIndex = 20;
            this.btnComplete.Text = "Complete";
            this.ttComplete.SetToolTip(this.btnComplete, "Click here to save the data that was entered");
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtDFName
            // 
            this.txtDFName.Location = new System.Drawing.Point(56, 269);
            this.txtDFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDFName.Name = "txtDFName";
            this.txtDFName.Size = new System.Drawing.Size(127, 20);
            this.txtDFName.TabIndex = 22;
            this.txtDFName.TextChanged += new System.EventHandler(this.txtDFName_TextChanged);
            this.txtDFName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDFName_KeyDown);
            // 
            // txtDLName
            // 
            this.txtDLName.Location = new System.Drawing.Point(56, 316);
            this.txtDLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDLName.Name = "txtDLName";
            this.txtDLName.Size = new System.Drawing.Size(127, 20);
            this.txtDLName.TabIndex = 23;
            this.txtDLName.TextChanged += new System.EventHandler(this.txtDLName_TextChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(56, 363);
            this.dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(127, 20);
            this.dtp.TabIndex = 24;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            this.dtp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_MouseDown);
            // 
            // ttComplete
            // 
            this.ttComplete.Tag = "Click here when want save data that was entered";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLSearch);
            this.groupBox1.Controls.Add(this.txtFSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(888, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 25;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name";
            // 
            // FNameError
            // 
            this.FNameError.ContainerControl = this;
            // 
            // LNameError
            // 
            this.LNameError.ContainerControl = this;
            // 
            // DancerIDError
            // 
            this.DancerIDError.ContainerControl = this;
            // 
            // DoBError
            // 
            this.DoBError.ContainerControl = this;
            // 
            // radError
            // 
            this.radError.ContainerControl = this;
            this.radError.Tag = "Please select add/update/delete";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDancers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1159, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDancerID);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtDLName);
            this.Controls.Add(this.txtDFName);
            this.Controls.Add(this.lblDancerID);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblDataGrid);
            this.Controls.Add(this.dgvDancers);
            this.Controls.Add(this.grpExpLvl);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDancers";
            this.Text = "Dancers";
            this.Load += new System.EventHandler(this.frmDancers_Load);
            this.grpExpLvl.ResumeLayout(false);
            this.grpExpLvl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDancers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DancerIDError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoBError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDancerID;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label dtpDOB;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.GroupBox grpExpLvl;
        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.DataGridView dgvDancers;
        private System.Windows.Forms.Label lblDataGrid;
        private System.Windows.Forms.TextBox txtDancerID;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtDFName;
        private System.Windows.Forms.TextBox txtDLName;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ToolTip ttComplete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLSearch;
        private System.Windows.Forms.TextBox txtFSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider FNameError;
        private System.Windows.Forms.ErrorProvider LNameError;
        private System.Windows.Forms.ErrorProvider DancerIDError;
        private System.Windows.Forms.ErrorProvider DoBError;
        private System.Windows.Forms.ErrorProvider radError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}