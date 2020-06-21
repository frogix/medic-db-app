namespace WindowsFormsApp2.Forms
{
    partial class ShowResultsForm
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
            this.test_completionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_completionsTableAdapter = new WindowsFormsApp2.kr_dbDataSetTableAdapters.test_completionsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.kr_dbDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.rbAnyGroup = new System.Windows.Forms.RadioButton();
            this.rbSetGroup = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbSetDate = new System.Windows.Forms.RadioButton();
            this.rbAnyDate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTest = new System.Windows.Forms.ComboBox();
            this.rbSetTest = new System.Windows.Forms.RadioButton();
            this.rbAnyTest = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbAnyMark = new System.Windows.Forms.RadioButton();
            this.rbSetMark = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.rbAnyLastname = new System.Windows.Forms.RadioButton();
            this.rbSetLastname = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kr_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_completionsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kr_dbDataSet
            // 
            this.kr_dbDataSet.DataSetName = "kr_dbDataSet";
            this.kr_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test_completionsBindingSource
            // 
            this.test_completionsBindingSource.DataMember = "test_completions";
            this.test_completionsBindingSource.DataSource = this.kr_dbDataSet;
            // 
            // test_completionsTableAdapter
            // 
            this.test_completionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.task_completionsTableAdapter = null;
            this.tableAdapterManager.tasksTableAdapter = null;
            this.tableAdapterManager.test_completionsTableAdapter = this.test_completionsTableAdapter;
            this.tableAdapterManager.tests_infoTableAdapter = null;
            this.tableAdapterManager.tests_tasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.kr_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbGroup);
            this.groupBox3.Controls.Add(this.rbAnyGroup);
            this.groupBox3.Controls.Add(this.rbSetGroup);
            this.groupBox3.Location = new System.Drawing.Point(631, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 81);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Группа студентов";
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(37, 19);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(146, 20);
            this.tbGroup.TabIndex = 13;
            // 
            // rbAnyGroup
            // 
            this.rbAnyGroup.AutoSize = true;
            this.rbAnyGroup.Checked = true;
            this.rbAnyGroup.Location = new System.Drawing.Point(12, 46);
            this.rbAnyGroup.Name = "rbAnyGroup";
            this.rbAnyGroup.Size = new System.Drawing.Size(59, 17);
            this.rbAnyGroup.TabIndex = 12;
            this.rbAnyGroup.TabStop = true;
            this.rbAnyGroup.Text = "Любая";
            this.rbAnyGroup.UseVisualStyleBackColor = true;
            // 
            // rbSetGroup
            // 
            this.rbSetGroup.AutoSize = true;
            this.rbSetGroup.Location = new System.Drawing.Point(12, 22);
            this.rbSetGroup.Name = "rbSetGroup";
            this.rbSetGroup.Size = new System.Drawing.Size(14, 13);
            this.rbSetGroup.TabIndex = 12;
            this.rbSetGroup.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.rbSetDate);
            this.groupBox2.Controls.Add(this.rbAnyDate);
            this.groupBox2.Location = new System.Drawing.Point(631, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 86);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата добавления";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 4, 17, 57, 0, 0);
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
            this.groupBox1.Controls.Add(this.cbTest);
            this.groupBox1.Controls.Add(this.rbSetTest);
            this.groupBox1.Controls.Add(this.rbAnyTest);
            this.groupBox1.Location = new System.Drawing.Point(631, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тест";
            // 
            // cbTest
            // 
            this.cbTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Location = new System.Drawing.Point(37, 32);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(121, 21);
            this.cbTest.TabIndex = 6;
            // 
            // rbSetTest
            // 
            this.rbSetTest.AutoSize = true;
            this.rbSetTest.Location = new System.Drawing.Point(17, 35);
            this.rbSetTest.Name = "rbSetTest";
            this.rbSetTest.Size = new System.Drawing.Size(14, 13);
            this.rbSetTest.TabIndex = 5;
            this.rbSetTest.UseVisualStyleBackColor = true;
            // 
            // rbAnyTest
            // 
            this.rbAnyTest.AutoSize = true;
            this.rbAnyTest.Checked = true;
            this.rbAnyTest.Location = new System.Drawing.Point(17, 54);
            this.rbAnyTest.Name = "rbAnyTest";
            this.rbAnyTest.Size = new System.Drawing.Size(59, 17);
            this.rbAnyTest.TabIndex = 4;
            this.rbAnyTest.TabStop = true;
            this.rbAnyTest.Text = "Любое";
            this.rbAnyTest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Фильтры";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.rbAnyMark);
            this.groupBox4.Controls.Add(this.rbSetMark);
            this.groupBox4.Location = new System.Drawing.Point(631, 443);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 81);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Оценка";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(38, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rbAnyMark
            // 
            this.rbAnyMark.AutoSize = true;
            this.rbAnyMark.Checked = true;
            this.rbAnyMark.Location = new System.Drawing.Point(12, 46);
            this.rbAnyMark.Name = "rbAnyMark";
            this.rbAnyMark.Size = new System.Drawing.Size(59, 17);
            this.rbAnyMark.TabIndex = 12;
            this.rbAnyMark.TabStop = true;
            this.rbAnyMark.Text = "Любая";
            this.rbAnyMark.UseVisualStyleBackColor = true;
            // 
            // rbSetMark
            // 
            this.rbSetMark.AutoSize = true;
            this.rbSetMark.Location = new System.Drawing.Point(12, 22);
            this.rbSetMark.Name = "rbSetMark";
            this.rbSetMark.Size = new System.Drawing.Size(14, 13);
            this.rbSetMark.TabIndex = 12;
            this.rbSetMark.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbLastname);
            this.groupBox5.Controls.Add(this.rbAnyLastname);
            this.groupBox5.Controls.Add(this.rbSetLastname);
            this.groupBox5.Location = new System.Drawing.Point(631, 356);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 81);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фамилия студента";
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(37, 19);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(146, 20);
            this.tbLastname.TabIndex = 13;
            // 
            // rbAnyLastname
            // 
            this.rbAnyLastname.AutoSize = true;
            this.rbAnyLastname.Checked = true;
            this.rbAnyLastname.Location = new System.Drawing.Point(12, 46);
            this.rbAnyLastname.Name = "rbAnyLastname";
            this.rbAnyLastname.Size = new System.Drawing.Size(59, 17);
            this.rbAnyLastname.TabIndex = 12;
            this.rbAnyLastname.TabStop = true;
            this.rbAnyLastname.Text = "Любая";
            this.rbAnyLastname.UseVisualStyleBackColor = true;
            // 
            // rbSetLastname
            // 
            this.rbSetLastname.AutoSize = true;
            this.rbSetLastname.Location = new System.Drawing.Point(12, 22);
            this.rbSetLastname.Name = "rbSetLastname";
            this.rbSetLastname.Size = new System.Drawing.Size(14, 13);
            this.rbSetLastname.TabIndex = 12;
            this.rbSetLastname.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 594);
            this.dataGridView1.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 42);
            this.button3.TabIndex = 25;
            this.button3.Text = "Сохранить CSV...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(740, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 42);
            this.button4.TabIndex = 26;
            this.button4.Text = "Сохранить PDF...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ShowResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 643);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ShowResultsForm";
            this.Text = "Результаты тестирования";
            this.Load += new System.EventHandler(this.ShowResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kr_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_completionsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kr_dbDataSet kr_dbDataSet;
        private System.Windows.Forms.BindingSource test_completionsBindingSource;
        private kr_dbDataSetTableAdapters.test_completionsTableAdapter test_completionsTableAdapter;
        private kr_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbAnyGroup;
        private System.Windows.Forms.RadioButton rbSetGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbSetDate;
        private System.Windows.Forms.RadioButton rbAnyDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTest;
        private System.Windows.Forms.RadioButton rbSetTest;
        private System.Windows.Forms.RadioButton rbAnyTest;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rbAnyMark;
        private System.Windows.Forms.RadioButton rbSetMark;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.RadioButton rbAnyLastname;
        private System.Windows.Forms.RadioButton rbSetLastname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}