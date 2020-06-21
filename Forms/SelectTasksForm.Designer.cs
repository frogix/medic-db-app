namespace WindowsFormsApp2.Forms
{
    partial class SelectTasksForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kr_dbDataSet = new WindowsFormsApp2.kr_dbDataSet();
            this.tasksTableAdapter = new WindowsFormsApp2.kr_dbDataSetTableAdapters.tasksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAnyAbn = new System.Windows.Forms.RadioButton();
            this.rbHasAbn = new System.Windows.Forms.RadioButton();
            this.rbNoAbn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbSetDate = new System.Windows.Forms.RadioButton();
            this.rbAnyDate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbAnyId = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbSetId = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.answerDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbHideRest = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kr_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.answerDataGridViewImageColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tasksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(543, 542);
            this.dataGridView1.TabIndex = 0;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "tasks";
            this.tasksBindingSource.DataSource = this.kr_dbDataSet;
            // 
            // kr_dbDataSet
            // 
            this.kr_dbDataSet.DataSetName = "kr_dbDataSet";
            this.kr_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фильтры";
            // 
            // rbAnyAbn
            // 
            this.rbAnyAbn.AutoSize = true;
            this.rbAnyAbn.Checked = true;
            this.rbAnyAbn.Location = new System.Drawing.Point(17, 65);
            this.rbAnyAbn.Name = "rbAnyAbn";
            this.rbAnyAbn.Size = new System.Drawing.Size(59, 17);
            this.rbAnyAbn.TabIndex = 4;
            this.rbAnyAbn.TabStop = true;
            this.rbAnyAbn.Text = "Любое";
            this.rbAnyAbn.UseVisualStyleBackColor = true;
            this.rbAnyAbn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbHasAbn
            // 
            this.rbHasAbn.AutoSize = true;
            this.rbHasAbn.Location = new System.Drawing.Point(17, 19);
            this.rbHasAbn.Name = "rbHasAbn";
            this.rbHasAbn.Size = new System.Drawing.Size(49, 17);
            this.rbHasAbn.TabIndex = 5;
            this.rbHasAbn.Text = "Есть";
            this.rbHasAbn.UseVisualStyleBackColor = true;
            // 
            // rbNoAbn
            // 
            this.rbNoAbn.AutoSize = true;
            this.rbNoAbn.Location = new System.Drawing.Point(17, 42);
            this.rbNoAbn.Name = "rbNoAbn";
            this.rbNoAbn.Size = new System.Drawing.Size(44, 17);
            this.rbNoAbn.TabIndex = 6;
            this.rbNoAbn.Text = "Нет";
            this.rbNoAbn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 4, 12, 37, 0, 0);
            // 
            // rbSetDate
            // 
            this.rbSetDate.AutoSize = true;
            this.rbSetDate.Location = new System.Drawing.Point(12, 32);
            this.rbSetDate.Name = "rbSetDate";
            this.rbSetDate.Size = new System.Drawing.Size(14, 13);
            this.rbSetDate.TabIndex = 10;
            this.rbSetDate.UseVisualStyleBackColor = true;
            // 
            // rbAnyDate
            // 
            this.rbAnyDate.AutoSize = true;
            this.rbAnyDate.Checked = true;
            this.rbAnyDate.Location = new System.Drawing.Point(12, 55);
            this.rbAnyDate.Name = "rbAnyDate";
            this.rbAnyDate.Size = new System.Drawing.Size(59, 17);
            this.rbAnyDate.TabIndex = 11;
            this.rbAnyDate.TabStop = true;
            this.rbAnyDate.Text = "Любая";
            this.rbAnyDate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHasAbn);
            this.groupBox1.Controls.Add(this.rbAnyAbn);
            this.groupBox1.Controls.Add(this.rbNoAbn);
            this.groupBox1.Location = new System.Drawing.Point(590, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наличие отклонения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.rbSetDate);
            this.groupBox2.Controls.Add(this.rbAnyDate);
            this.groupBox2.Location = new System.Drawing.Point(590, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 86);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата добавления";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbAnyId);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.rbSetId);
            this.groupBox3.Location = new System.Drawing.Point(590, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 81);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ID задания";
            // 
            // rbAnyId
            // 
            this.rbAnyId.AutoSize = true;
            this.rbAnyId.Checked = true;
            this.rbAnyId.Location = new System.Drawing.Point(12, 46);
            this.rbAnyId.Name = "rbAnyId";
            this.rbAnyId.Size = new System.Drawing.Size(59, 17);
            this.rbAnyId.TabIndex = 12;
            this.rbAnyId.TabStop = true;
            this.rbAnyId.Text = "Любой";
            this.rbAnyId.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(32, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(151, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // rbSetId
            // 
            this.rbSetId.AutoSize = true;
            this.rbSetId.Location = new System.Drawing.Point(12, 22);
            this.rbSetId.Name = "rbSetId";
            this.rbSetId.Size = new System.Drawing.Size(14, 13);
            this.rbSetId.TabIndex = 12;
            this.rbSetId.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // answerDataGridViewImageColumn
            // 
            this.answerDataGridViewImageColumn.DataPropertyName = "answer";
            this.answerDataGridViewImageColumn.HeaderText = "answer";
            this.answerDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.answerDataGridViewImageColumn.Name = "answerDataGridViewImageColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbShowAll);
            this.groupBox4.Controls.Add(this.rbHideRest);
            this.groupBox4.Location = new System.Drawing.Point(590, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Показывать только выбранные задания?";
            // 
            // rbHideRest
            // 
            this.rbHideRest.AutoSize = true;
            this.rbHideRest.Location = new System.Drawing.Point(17, 38);
            this.rbHideRest.Name = "rbHideRest";
            this.rbHideRest.Size = new System.Drawing.Size(40, 17);
            this.rbHideRest.TabIndex = 12;
            this.rbHideRest.Text = "Да";
            this.rbHideRest.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Location = new System.Drawing.Point(17, 61);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(132, 17);
            this.rbShowAll.TabIndex = 7;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Нет, показывать все";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(12, 12);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(138, 35);
            this.removeBtn.TabIndex = 18;
            this.removeBtn.Text = "Удалить выделенные задания из теста";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(168, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(138, 35);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Добавить выделенные задания в тест";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // SelectTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 714);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectTasksForm";
            this.Text = "Редактирования набора заданий теста";
            this.Load += new System.EventHandler(this.SelectTasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kr_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kr_dbDataSet kr_dbDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private kr_dbDataSetTableAdapters.tasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAnyAbn;
        private System.Windows.Forms.RadioButton rbHasAbn;
        private System.Windows.Forms.RadioButton rbNoAbn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbSetDate;
        private System.Windows.Forms.RadioButton rbAnyDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbAnyId;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rbSetId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn answerDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbHideRest;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
    }
}