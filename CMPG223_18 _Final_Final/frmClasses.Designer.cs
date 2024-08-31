
namespace CMPG223_18
{
    partial class frmClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClasses));
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblExpLvl = new System.Windows.Forms.Label();
            this.txtClassPrice = new System.Windows.Forms.TextBox();
            this.lblClassPrice = new System.Windows.Forms.Label();
            this.lblDateOfClass = new System.Windows.Forms.Label();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDanceType = new System.Windows.Forms.Label();
            this.cmbDanceType = new System.Windows.Forms.ComboBox();
            this.cmbExpLvl = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.gpbClasses = new System.Windows.Forms.GroupBox();
            this.rdbRemove = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.typeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.expError = new System.Windows.Forms.ErrorProvider(this.components);
            this.teachError = new System.Windows.Forms.ErrorProvider(this.components);
            this.timeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.priceError = new System.Windows.Forms.ErrorProvider(this.components);
            this.descError = new System.Windows.Forms.ErrorProvider(this.components);
            this.deleteTip = new System.Windows.Forms.ToolTip(this.components);
            this.updateTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.gpbClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(419, 216);
            this.lblTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(47, 13);
            this.lblTeacher.TabIndex = 31;
            this.lblTeacher.Text = "Teacher";
            this.lblTeacher.Visible = false;
            // 
            // lblExpLvl
            // 
            this.lblExpLvl.AutoSize = true;
            this.lblExpLvl.Location = new System.Drawing.Point(231, 216);
            this.lblExpLvl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpLvl.Name = "lblExpLvl";
            this.lblExpLvl.Size = new System.Drawing.Size(89, 13);
            this.lblExpLvl.TabIndex = 30;
            this.lblExpLvl.Text = "Experience Level";
            this.lblExpLvl.Visible = false;
            // 
            // txtClassPrice
            // 
            this.txtClassPrice.Location = new System.Drawing.Point(420, 289);
            this.txtClassPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtClassPrice.Name = "txtClassPrice";
            this.txtClassPrice.Size = new System.Drawing.Size(134, 20);
            this.txtClassPrice.TabIndex = 9;
            this.txtClassPrice.Visible = false;
            this.txtClassPrice.TextChanged += new System.EventHandler(this.txtClassPrice_TextChanged);
            // 
            // lblClassPrice
            // 
            this.lblClassPrice.AutoSize = true;
            this.lblClassPrice.Location = new System.Drawing.Point(417, 274);
            this.lblClassPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassPrice.Name = "lblClassPrice";
            this.lblClassPrice.Size = new System.Drawing.Size(59, 13);
            this.lblClassPrice.TabIndex = 28;
            this.lblClassPrice.Text = "Class Price";
            this.lblClassPrice.Visible = false;
            // 
            // lblDateOfClass
            // 
            this.lblDateOfClass.AutoSize = true;
            this.lblDateOfClass.Location = new System.Drawing.Point(235, 274);
            this.lblDateOfClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfClass.Name = "lblDateOfClass";
            this.lblDateOfClass.Size = new System.Drawing.Size(70, 13);
            this.lblDateOfClass.TabIndex = 27;
            this.lblDateOfClass.Text = "Date of Class";
            this.lblDateOfClass.Visible = false;
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.Location = new System.Drawing.Point(235, 290);
            this.dtpClassDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(129, 20);
            this.dtpClassDate.TabIndex = 7;
            this.dtpClassDate.Visible = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(48, 320);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 25;
            this.lblMinutes.Text = "Minutes";
            this.lblMinutes.Visible = false;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(48, 299);
            this.lblHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 24;
            this.lblHours.Text = "Hours";
            this.lblHours.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(48, 274);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(75, 13);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "Class Duration";
            this.lblDuration.Visible = false;
            // 
            // lblDanceType
            // 
            this.lblDanceType.AutoSize = true;
            this.lblDanceType.Location = new System.Drawing.Point(47, 216);
            this.lblDanceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanceType.Name = "lblDanceType";
            this.lblDanceType.Size = new System.Drawing.Size(66, 13);
            this.lblDanceType.TabIndex = 19;
            this.lblDanceType.Text = "Dance Type";
            this.lblDanceType.Visible = false;
            // 
            // cmbDanceType
            // 
            this.cmbDanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanceType.FormattingEnabled = true;
            this.cmbDanceType.Location = new System.Drawing.Point(50, 231);
            this.cmbDanceType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDanceType.Name = "cmbDanceType";
            this.cmbDanceType.Size = new System.Drawing.Size(134, 21);
            this.cmbDanceType.TabIndex = 2;
            this.cmbDanceType.Visible = false;
            // 
            // cmbExpLvl
            // 
            this.cmbExpLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpLvl.FormattingEnabled = true;
            this.cmbExpLvl.Location = new System.Drawing.Point(234, 231);
            this.cmbExpLvl.Margin = new System.Windows.Forms.Padding(2);
            this.cmbExpLvl.Name = "cmbExpLvl";
            this.cmbExpLvl.Size = new System.Drawing.Size(134, 21);
            this.cmbExpLvl.TabIndex = 3;
            this.cmbExpLvl.Visible = false;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(419, 231);
            this.cmbTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(134, 21);
            this.cmbTeacher.TabIndex = 4;
            this.cmbTeacher.Visible = false;
            // 
            // dgvClasses
            // 
            this.dgvClasses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(235, 48);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 62;
            this.dgvClasses.RowTemplate.Height = 28;
            this.dgvClasses.Size = new System.Drawing.Size(318, 153);
            this.dgvClasses.TabIndex = 35;
            this.dgvClasses.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentDoubleClick);
            // 
            // gpbClasses
            // 
            this.gpbClasses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbClasses.Controls.Add(this.rdbRemove);
            this.gpbClasses.Controls.Add(this.rdbUpdate);
            this.gpbClasses.Controls.Add(this.rdbAdd);
            this.gpbClasses.Location = new System.Drawing.Point(51, 48);
            this.gpbClasses.Margin = new System.Windows.Forms.Padding(2);
            this.gpbClasses.Name = "gpbClasses";
            this.gpbClasses.Padding = new System.Windows.Forms.Padding(2);
            this.gpbClasses.Size = new System.Drawing.Size(151, 119);
            this.gpbClasses.TabIndex = 0;
            this.gpbClasses.TabStop = false;
            this.gpbClasses.Text = "Maintain Classes";
            // 
            // rdbRemove
            // 
            this.rdbRemove.AutoSize = true;
            this.rdbRemove.Location = new System.Drawing.Point(11, 89);
            this.rdbRemove.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRemove.Name = "rdbRemove";
            this.rdbRemove.Size = new System.Drawing.Size(84, 17);
            this.rdbRemove.TabIndex = 2;
            this.rdbRemove.Text = "Delete Class";
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
            this.rdbAdd.Size = new System.Drawing.Size(72, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.Text = "Add Class";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
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
            this.btnBack.TabIndex = 37;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(610, 376);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 38;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.OldLace;
            this.btnComplete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(610, 280);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(137, 32);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(119, 296);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 5;
            this.txtHours.Visible = false;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(119, 322);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(100, 20);
            this.txtMinutes.TabIndex = 6;
            this.txtMinutes.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(238, 329);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 13);
            this.lblDescription.TabIndex = 46;
            this.lblDescription.Text = "Class Description";
            this.lblDescription.Visible = false;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(361, 329);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(100, 20);
            this.txtDescr.TabIndex = 8;
            this.txtDescr.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(233, 366);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(67, 366);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(135, 13);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search according to name:";
            // 
            // typeError
            // 
            this.typeError.ContainerControl = this;
            // 
            // expError
            // 
            this.expError.ContainerControl = this;
            // 
            // teachError
            // 
            this.teachError.ContainerControl = this;
            // 
            // timeError
            // 
            this.timeError.ContainerControl = this;
            // 
            // dateError
            // 
            this.dateError.ContainerControl = this;
            // 
            // priceError
            // 
            this.priceError.ContainerControl = this;
            // 
            // descError
            // 
            this.descError.ContainerControl = this;
            // 
            // frmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 404);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpbClasses);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbExpLvl);
            this.Controls.Add(this.cmbDanceType);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblExpLvl);
            this.Controls.Add(this.txtClassPrice);
            this.Controls.Add(this.lblClassPrice);
            this.Controls.Add(this.lblDateOfClass);
            this.Controls.Add(this.dtpClassDate);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblDanceType);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClasses";
            this.Text = "S";
            this.Load += new System.EventHandler(this.frmClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.gpbClasses.ResumeLayout(false);
            this.gpbClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblExpLvl;
        private System.Windows.Forms.TextBox txtClassPrice;
        private System.Windows.Forms.Label lblClassPrice;
        private System.Windows.Forms.Label lblDateOfClass;
        private System.Windows.Forms.DateTimePicker dtpClassDate;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDanceType;
        private System.Windows.Forms.ComboBox cmbDanceType;
        private System.Windows.Forms.ComboBox cmbExpLvl;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.GroupBox gpbClasses;
        private System.Windows.Forms.RadioButton rdbRemove;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ErrorProvider typeError;
        private System.Windows.Forms.ErrorProvider expError;
        private System.Windows.Forms.ErrorProvider teachError;
        private System.Windows.Forms.ErrorProvider timeError;
        private System.Windows.Forms.ErrorProvider dateError;
        private System.Windows.Forms.ErrorProvider priceError;
        private System.Windows.Forms.ErrorProvider descError;
        private System.Windows.Forms.ToolTip deleteTip;
        private System.Windows.Forms.ToolTip updateTip;
    }
}