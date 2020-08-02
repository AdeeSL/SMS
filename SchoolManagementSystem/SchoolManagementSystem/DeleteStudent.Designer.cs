namespace SchoolManagementSystem
{
    partial class DeleteStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentmobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolManagementSystemDataSet = new SchoolManagementSystem.SchoolManagementSystemDataSet();
            this.studentTableAdapter = new SchoolManagementSystem.SchoolManagementSystemDataSetTableAdapters.StudentTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Student Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Index Number";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(223, 106);
            this.txtIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(132, 22);
            this.txtIndex.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stidDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.initialDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.parentnameDataGridViewTextBoxColumn,
            this.parentmobileDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 250);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 273);
            this.dataGridView1.TabIndex = 5;
            // 
            // stidDataGridViewTextBoxColumn
            // 
            this.stidDataGridViewTextBoxColumn.DataPropertyName = "st_id";
            this.stidDataGridViewTextBoxColumn.HeaderText = "st_id";
            this.stidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stidDataGridViewTextBoxColumn.Name = "stidDataGridViewTextBoxColumn";
            this.stidDataGridViewTextBoxColumn.ReadOnly = true;
            this.stidDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "full_name";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // initialDataGridViewTextBoxColumn
            // 
            this.initialDataGridViewTextBoxColumn.DataPropertyName = "initial";
            this.initialDataGridViewTextBoxColumn.HeaderText = "initial";
            this.initialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.initialDataGridViewTextBoxColumn.Name = "initialDataGridViewTextBoxColumn";
            this.initialDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentnameDataGridViewTextBoxColumn
            // 
            this.parentnameDataGridViewTextBoxColumn.DataPropertyName = "parent_name";
            this.parentnameDataGridViewTextBoxColumn.HeaderText = "parent_name";
            this.parentnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentnameDataGridViewTextBoxColumn.Name = "parentnameDataGridViewTextBoxColumn";
            this.parentnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentmobileDataGridViewTextBoxColumn
            // 
            this.parentmobileDataGridViewTextBoxColumn.DataPropertyName = "parent_mobile";
            this.parentmobileDataGridViewTextBoxColumn.HeaderText = "parent_mobile";
            this.parentmobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentmobileDataGridViewTextBoxColumn.Name = "parentmobileDataGridViewTextBoxColumn";
            this.parentmobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.schoolManagementSystemDataSet;
            // 
            // schoolManagementSystemDataSet
            // 
            this.schoolManagementSystemDataSet.DataSetName = "SchoolManagementSystemDataSet";
            this.schoolManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(452, 102);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(603, 103);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 551);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolManagementSystemDataSet schoolManagementSystemDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private SchoolManagementSystemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentmobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}