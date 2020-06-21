namespace WindowsFormsApp2.Forms
{
    partial class TestsListForm
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
            this.kr_dbDataSet = new WindowsFormsApp2.kr_dbDataSet();
            this.tests_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tests_infoTableAdapter = new WindowsFormsApp2.kr_dbDataSetTableAdapters.tests_infoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.kr_dbDataSetTableAdapters.TableAdapterManager();
            this.dgTests = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEditTasks = new System.Windows.Forms.Button();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kr_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tests_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTests)).BeginInit();
            this.SuspendLayout();
            // 
            // kr_dbDataSet
            // 
            this.kr_dbDataSet.DataSetName = "kr_dbDataSet";
            this.kr_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tests_infoBindingSource
            // 
            this.tests_infoBindingSource.DataMember = "tests_info";
            this.tests_infoBindingSource.DataSource = this.kr_dbDataSet;
            // 
            // tests_infoTableAdapter
            // 
            this.tests_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.task_completionsTableAdapter = null;
            this.tableAdapterManager.tasksTableAdapter = null;
            this.tableAdapterManager.test_completionsTableAdapter = null;
            this.tableAdapterManager.tests_infoTableAdapter = this.tests_infoTableAdapter;
            this.tableAdapterManager.tests_tasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.kr_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgTests
            // 
            this.dgTests.AllowUserToAddRows = false;
            this.dgTests.AutoGenerateColumns = false;
            this.dgTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgTests.DataSource = this.tests_infoBindingSource;
            this.dgTests.Location = new System.Drawing.Point(30, 28);
            this.dgTests.Name = "dgTests";
            this.dgTests.Size = new System.Drawing.Size(455, 397);
            this.dgTests.TabIndex = 1;
            this.dgTests.SelectionChanged += new System.EventHandler(this.dgTests_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "test_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "test_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "test_timer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время выполнения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(510, 142);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(146, 46);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Удалить выбранные";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditTasks
            // 
            this.btnEditTasks.Location = new System.Drawing.Point(510, 85);
            this.btnEditTasks.Name = "btnEditTasks";
            this.btnEditTasks.Size = new System.Drawing.Size(146, 46);
            this.btnEditTasks.TabIndex = 3;
            this.btnEditTasks.Text = "Изменить задания...";
            this.btnEditTasks.UseVisualStyleBackColor = true;
            this.btnEditTasks.Click += new System.EventHandler(this.btnEditTasks_Click);
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(510, 28);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(146, 46);
            this.btnCreateTest.TabIndex = 4;
            this.btnCreateTest.Text = "Новый тест...";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Просмотр результатов...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Создание заданий...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateTest);
            this.Controls.Add(this.btnEditTasks);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgTests);
            this.Name = "TestsListForm";
            this.Text = "Редактирование тестов";
            this.Load += new System.EventHandler(this.EditTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kr_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tests_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kr_dbDataSet kr_dbDataSet;
        private System.Windows.Forms.BindingSource tests_infoBindingSource;
        private kr_dbDataSetTableAdapters.tests_infoTableAdapter tests_infoTableAdapter;
        private kr_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgTests;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEditTasks;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}