
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlSearch.SuspendLayout();
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
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(539, 423);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Controls.Add(this.textBox2);
            this.pnlSearch.Controls.Add(this.textBox1);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.lblDancerID);
            this.pnlSearch.Location = new System.Drawing.Point(40, 201);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(167, 100);
            this.pnlSearch.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 11);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblDancerID
            // 
            this.lblDancerID.AutoSize = true;
            this.lblDancerID.Location = new System.Drawing.Point(18, 55);
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
            this.grpExpLvl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpExpLvl.Name = "grpExpLvl";
            this.grpExpLvl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpExpLvl.Size = new System.Drawing.Size(167, 138);
            this.grpExpLvl.TabIndex = 17;
            this.grpExpLvl.TabStop = false;
            this.grpExpLvl.Text = "Select Action";
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(14, 93);
            this.rdbDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(94, 17);
            this.rdbDelete.TabIndex = 2;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Delete Dancer";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(14, 64);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(98, 17);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Dancer";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(14, 36);
            this.rdbAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(82, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Dancer";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // dgvDancers
            // 
            this.dgvDancers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDancers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDancers.Location = new System.Drawing.Point(274, 64);
            this.dgvDancers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDancers.Name = "dgvDancers";
            this.dgvDancers.RowHeadersWidth = 62;
            this.dgvDancers.RowTemplate.Height = 28;
            this.dgvDancers.Size = new System.Drawing.Size(228, 237);
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
            this.btnComplete.Location = new System.Drawing.Point(365, 324);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(137, 32);
            this.btnComplete.TabIndex = 20;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 334);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 381);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 20);
            this.textBox4.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 428);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // frmDancers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(603, 451);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblDataGrid);
            this.Controls.Add(this.dgvDancers);
            this.Controls.Add(this.grpExpLvl);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDancers";
            this.Text = "Dancers";
            this.Load += new System.EventHandler(this.frmDancers_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grpExpLvl.ResumeLayout(false);
            this.grpExpLvl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDancers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearch;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}