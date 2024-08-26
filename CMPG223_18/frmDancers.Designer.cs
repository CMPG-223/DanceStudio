
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
            this.grpExpLvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDancers)).BeginInit();
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
            this.txtDancerID.Location = new System.Drawing.Point(40, 281);
            this.txtDancerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtDancerID.Name = "txtDancerID";
            this.txtDancerID.Size = new System.Drawing.Size(127, 20);
            this.txtDancerID.TabIndex = 14;
            this.txtDancerID.TextChanged += new System.EventHandler(this.txtDancerID_TextChanged);
            this.txtDancerID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDancerID_KeyUp);
            // 
            // lblDancerID
            // 
            this.lblDancerID.AutoSize = true;
            this.lblDancerID.Location = new System.Drawing.Point(37, 266);
            this.lblDancerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDancerID.Name = "lblDancerID";
            this.lblDancerID.Size = new System.Drawing.Size(56, 13);
            this.lblDancerID.TabIndex = 13;
            this.lblDancerID.Text = "Dancer ID";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(37, 319);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 14;
            this.lblFName.Text = "First Name";
            // 
            // dtpDOB
            // 
            this.dtpDOB.AutoSize = true;
            this.dtpDOB.Location = new System.Drawing.Point(37, 413);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(65, 13);
            this.dtpDOB.TabIndex = 15;
            this.dtpDOB.Text = "Date of birth";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(37, 366);
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
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtDFName
            // 
            this.txtDFName.Location = new System.Drawing.Point(40, 334);
            this.txtDFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDFName.Name = "txtDFName";
            this.txtDFName.Size = new System.Drawing.Size(127, 20);
            this.txtDFName.TabIndex = 22;
            this.txtDFName.TextChanged += new System.EventHandler(this.txtDFName_TextChanged);
            // 
            // txtDLName
            // 
            this.txtDLName.Location = new System.Drawing.Point(40, 381);
            this.txtDLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDLName.Name = "txtDLName";
            this.txtDLName.Size = new System.Drawing.Size(127, 20);
            this.txtDLName.TabIndex = 23;
            this.txtDLName.TextChanged += new System.EventHandler(this.txtDLName_TextChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(40, 428);
            this.dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(127, 20);
            this.dtp.TabIndex = 24;
            // 
            // frmDancers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 490);
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
    }
}