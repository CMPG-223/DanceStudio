
namespace CMPG223_18
{
    partial class frmTeachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeachers));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDanceType = new System.Windows.Forms.Label();
            this.cmbDanceType = new System.Windows.Forms.ComboBox();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.gpbTeachers = new System.Windows.Forms.GroupBox();
            this.rdbRemove = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCellNum = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCellNum = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.gpbTeachers.SuspendLayout();
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
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(552, 346);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblDanceType
            // 
            this.lblDanceType.AutoSize = true;
            this.lblDanceType.Enabled = false;
            this.lblDanceType.Location = new System.Drawing.Point(311, 255);
            this.lblDanceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanceType.Name = "lblDanceType";
            this.lblDanceType.Size = new System.Drawing.Size(66, 13);
            this.lblDanceType.TabIndex = 38;
            this.lblDanceType.Text = "Dance Type";
            // 
            // cmbDanceType
            // 
            this.cmbDanceType.Enabled = false;
            this.cmbDanceType.FormattingEnabled = true;
            this.cmbDanceType.Location = new System.Drawing.Point(314, 281);
            this.cmbDanceType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDanceType.Name = "cmbDanceType";
            this.cmbDanceType.Size = new System.Drawing.Size(112, 21);
            this.cmbDanceType.TabIndex = 6;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(249, 51);
            this.dgvTeachers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersWidth = 62;
            this.dgvTeachers.RowTemplate.Height = 28;
            this.dgvTeachers.Size = new System.Drawing.Size(321, 119);
            this.dgvTeachers.TabIndex = 35;
            // 
            // gpbTeachers
            // 
            this.gpbTeachers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbTeachers.Controls.Add(this.rdbRemove);
            this.gpbTeachers.Controls.Add(this.rdbUpdate);
            this.gpbTeachers.Controls.Add(this.rdbAdd);
            this.gpbTeachers.Location = new System.Drawing.Point(39, 51);
            this.gpbTeachers.Margin = new System.Windows.Forms.Padding(2);
            this.gpbTeachers.Name = "gpbTeachers";
            this.gpbTeachers.Padding = new System.Windows.Forms.Padding(2);
            this.gpbTeachers.Size = new System.Drawing.Size(151, 119);
            this.gpbTeachers.TabIndex = 0;
            this.gpbTeachers.TabStop = false;
            this.gpbTeachers.Text = "Maintain Teachers";
            // 
            // rdbRemove
            // 
            this.rdbRemove.AutoSize = true;
            this.rdbRemove.Location = new System.Drawing.Point(11, 89);
            this.rdbRemove.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRemove.Name = "rdbRemove";
            this.rdbRemove.Size = new System.Drawing.Size(108, 17);
            this.rdbRemove.TabIndex = 2;
            this.rdbRemove.TabStop = true;
            this.rdbRemove.Text = "Remove Teacher";
            this.rdbRemove.UseVisualStyleBackColor = true;
            this.rdbRemove.CheckedChanged += new System.EventHandler(this.rdbRemove_CheckedChanged);
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(11, 55);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(115, 17);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Information";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.rdbUpdate_CheckedChanged);
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(11, 23);
            this.rdbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(87, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Teacher";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(173, 281);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(113, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtCellNum
            // 
            this.txtCellNum.Enabled = false;
            this.txtCellNum.Location = new System.Drawing.Point(38, 281);
            this.txtCellNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtCellNum.Name = "txtCellNum";
            this.txtCellNum.Size = new System.Drawing.Size(113, 20);
            this.txtCellNum.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Enabled = false;
            this.txtLName.Location = new System.Drawing.Point(313, 218);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(113, 20);
            this.txtLName.TabIndex = 3;
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(178, 218);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(113, 20);
            this.txtFName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Enabled = false;
            this.lblEmail.Location = new System.Drawing.Point(171, 255);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email Address";
            // 
            // lblCellNum
            // 
            this.lblCellNum.AutoSize = true;
            this.lblCellNum.Enabled = false;
            this.lblCellNum.Location = new System.Drawing.Point(36, 255);
            this.lblCellNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCellNum.Name = "lblCellNum";
            this.lblCellNum.Size = new System.Drawing.Size(94, 13);
            this.lblCellNum.TabIndex = 28;
            this.lblCellNum.Text = "Cellphone Number";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Enabled = false;
            this.lblLName.Location = new System.Drawing.Point(311, 195);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 27;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Enabled = false;
            this.lblFName.Location = new System.Drawing.Point(175, 195);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 26;
            this.lblFName.Text = "First Name";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.OldLace;
            this.btnComplete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(453, 242);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(137, 32);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(39, 218);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(36, 195);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 41;
            this.lblID.Text = "ID:";
            // 
            // frmTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(616, 374);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblDanceType);
            this.Controls.Add(this.cmbDanceType);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.gpbTeachers);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCellNum);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCellNum);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTeachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.frmTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.gpbTeachers.ResumeLayout(false);
            this.gpbTeachers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDanceType;
        private System.Windows.Forms.ComboBox cmbDanceType;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.GroupBox gpbTeachers;
        private System.Windows.Forms.RadioButton rdbRemove;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCellNum;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCellNum;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}