
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDancerID = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpExpLvl = new System.Windows.Forms.GroupBox();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.dgvDancers = new System.Windows.Forms.DataGridView();
            this.lblDataGrid = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(809, 651);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 31);
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
            this.pnlSearch.Location = new System.Drawing.Point(60, 309);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(250, 154);
            this.pnlSearch.TabIndex = 12;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(27, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblDancerID
            // 
            this.lblDancerID.AutoSize = true;
            this.lblDancerID.Location = new System.Drawing.Point(27, 85);
            this.lblDancerID.Name = "lblDancerID";
            this.lblDancerID.Size = new System.Drawing.Size(82, 20);
            this.lblDancerID.TabIndex = 13;
            this.lblDancerID.Text = "Dancer ID";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(56, 491);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(86, 20);
            this.lblFName.TabIndex = 14;
            this.lblFName.Text = "First Name";
            // 
            // dtpDOB
            // 
            this.dtpDOB.AutoSize = true;
            this.dtpDOB.Location = new System.Drawing.Point(56, 635);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(97, 20);
            this.dtpDOB.TabIndex = 15;
            this.dtpDOB.Text = "Date of birth";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(56, 563);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(86, 20);
            this.lblLName.TabIndex = 16;
            this.lblLName.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 1;
            // 
            // grpExpLvl
            // 
            this.grpExpLvl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpExpLvl.Controls.Add(this.rdbDelete);
            this.grpExpLvl.Controls.Add(this.rdbUpdate);
            this.grpExpLvl.Controls.Add(this.rdbAdd);
            this.grpExpLvl.Location = new System.Drawing.Point(60, 69);
            this.grpExpLvl.Name = "grpExpLvl";
            this.grpExpLvl.Size = new System.Drawing.Size(250, 213);
            this.grpExpLvl.TabIndex = 17;
            this.grpExpLvl.TabStop = false;
            this.grpExpLvl.Text = "Select Action";
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(21, 143);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(137, 24);
            this.rdbDelete.TabIndex = 2;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Delete Dancer";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(21, 99);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(143, 24);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Dancer";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(21, 55);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(119, 24);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Dancer";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // dgvDancers
            // 
            this.dgvDancers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDancers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDancers.Location = new System.Drawing.Point(411, 99);
            this.dgvDancers.Name = "dgvDancers";
            this.dgvDancers.RowHeadersWidth = 62;
            this.dgvDancers.RowTemplate.Height = 28;
            this.dgvDancers.Size = new System.Drawing.Size(342, 364);
            this.dgvDancers.TabIndex = 18;
            // 
            // lblDataGrid
            // 
            this.lblDataGrid.AutoSize = true;
            this.lblDataGrid.Location = new System.Drawing.Point(407, 69);
            this.lblDataGrid.Name = "lblDataGrid";
            this.lblDataGrid.Size = new System.Drawing.Size(69, 20);
            this.lblDataGrid.TabIndex = 19;
            this.lblDataGrid.Text = "Dancers";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.OldLace;
            this.btnComplete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(547, 498);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(206, 49);
            this.btnComplete.TabIndex = 20;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 514);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 26);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(60, 586);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 26);
            this.textBox4.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 658);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 26);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // frmDancers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(905, 694);
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
            this.Name = "frmDancers";
            this.Text = "Dancers";
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