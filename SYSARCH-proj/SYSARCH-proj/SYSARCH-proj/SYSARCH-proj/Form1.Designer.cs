namespace SYSARCH_proj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptCode = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtDeptID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.univDataSet = new SYSARCH_proj.univDataSet();
            this.univDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeTableAdapter = new SYSARCH_proj.univDataSetTableAdapters.CollegeTableAdapter();
            this.departmentTableAdapter = new SYSARCH_proj.univDataSetTableAdapters.DepartmentTableAdapter();
            this.collegeDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.univDataSet1 = new SYSARCH_proj.univDataSet1();
            this.collegeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeTableAdapter1 = new SYSARCH_proj.univDataSet1TableAdapters.CollegeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(101, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "College ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(160, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(167, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department Code:";
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCollegeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeID.Location = new System.Drawing.Point(199, 137);
            this.txtCollegeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(133, 17);
            this.txtCollegeID.TabIndex = 3;
            this.txtCollegeID.TextChanged += new System.EventHandler(this.txtCollegeID_TextChanged);
            // 
            // txtDeptName
            // 
            this.txtDeptName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptName.Location = new System.Drawing.Point(175, 290);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(133, 17);
            this.txtDeptName.TabIndex = 4;
            // 
            // txtDeptCode
            // 
            this.txtDeptCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeptCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptCode.Location = new System.Drawing.Point(175, 336);
            this.txtDeptCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeptCode.Name = "txtDeptCode";
            this.txtDeptCode.Size = new System.Drawing.Size(133, 17);
            this.txtDeptCode.TabIndex = 5;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.BackColor = System.Drawing.Color.Transparent;
            this.chkIsActive.Location = new System.Drawing.Point(205, 379);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(79, 20);
            this.chkIsActive.TabIndex = 6;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(101, 407);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(153, 407);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(236, 407);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(88, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Department ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(83, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "College Name:";
            // 
            // txtColName
            // 
            this.txtColName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColName.Location = new System.Drawing.Point(199, 186);
            this.txtColName.Margin = new System.Windows.Forms.Padding(4);
            this.txtColName.Name = "txtColName";
            this.txtColName.Size = new System.Drawing.Size(133, 17);
            this.txtColName.TabIndex = 17;
            this.txtColName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(83, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "College Code:";
            // 
            // txtColCode
            // 
            this.txtColCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColCode.Location = new System.Drawing.Point(199, 161);
            this.txtColCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtColCode.Name = "txtColCode";
            this.txtColCode.Size = new System.Drawing.Size(133, 17);
            this.txtColCode.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(74)))), ((int)(((byte)(145)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(269, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(172, 210);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 20);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Is Active";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // txtDeptID
            // 
            this.txtDeptID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptID.Location = new System.Drawing.Point(219, 241);
            this.txtDeptID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeptID.Name = "txtDeptID";
            this.txtDeptID.Size = new System.Drawing.Size(116, 16);
            this.txtDeptID.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collegeIDDataGridViewTextBoxColumn,
            this.DepartmentID,
            this.DepartmentName,
            this.DepartmentCode,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.departmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(352, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 358);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            this.collegeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // DepartmentID
            // 
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "DepartmentID";
            this.DepartmentID.MinimumWidth = 6;
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Width = 125;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "DepartmentName";
            this.DepartmentName.MinimumWidth = 6;
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Width = 125;
            // 
            // DepartmentCode
            // 
            this.DepartmentCode.DataPropertyName = "DepartmentCode";
            this.DepartmentCode.HeaderText = "DepartmentCode";
            this.DepartmentCode.MinimumWidth = 6;
            this.DepartmentCode.Name = "DepartmentCode";
            this.DepartmentCode.Width = 125;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.univDataSet;
            // 
            // univDataSet
            // 
            this.univDataSet.DataSetName = "univDataSet";
            this.univDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // univDataSetBindingSource
            // 
            this.univDataSetBindingSource.DataSource = this.univDataSet;
            this.univDataSetBindingSource.Position = 0;
            // 
            // collegeBindingSource
            // 
            this.collegeBindingSource.DataMember = "College";
            this.collegeBindingSource.DataSource = this.univDataSet;
            // 
            // collegeTableAdapter
            // 
            this.collegeTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // collegeDepartmentBindingSource
            // 
            this.collegeDepartmentBindingSource.DataMember = "CollegeDepartment";
            this.collegeDepartmentBindingSource.DataSource = this.collegeBindingSource;
            // 
            // collegeBindingSource1
            // 
            this.collegeBindingSource1.DataMember = "College";
            this.collegeBindingSource1.DataSource = this.univDataSetBindingSource;
            // 
            // univDataSet1
            // 
            this.univDataSet1.DataSetName = "univDataSet1";
            this.univDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collegeBindingSource2
            // 
            this.collegeBindingSource2.DataMember = "College";
            this.collegeBindingSource2.DataSource = this.univDataSet1;
            // 
            // collegeTableAdapter1
            // 
            this.collegeTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDeptID);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtColCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtDeptCode);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtCollegeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSTEM UNIVERSITY";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.univDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCollegeID;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptCode;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtColCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtDeptID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource univDataSetBindingSource;
        private univDataSet univDataSet;
        private System.Windows.Forms.BindingSource collegeBindingSource;
        private univDataSetTableAdapters.CollegeTableAdapter collegeTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private univDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource collegeBindingSource1;
        private System.Windows.Forms.BindingSource collegeDepartmentBindingSource;
        private univDataSet1 univDataSet1;
        private System.Windows.Forms.BindingSource collegeBindingSource2;
        private univDataSet1TableAdapters.CollegeTableAdapter collegeTableAdapter1;
    }
}

