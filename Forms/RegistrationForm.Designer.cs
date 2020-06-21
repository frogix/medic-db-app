namespace dbApp
{
    partial class RegistrationForm
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
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.groupTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kr_dbDataSet = new WindowsFormsApp2.kr_dbDataSet();
            this.tests_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tests_infoTableAdapter = new WindowsFormsApp2.kr_dbDataSetTableAdapters.tests_infoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.kr_dbDataSetTableAdapters.TableAdapterManager();
            this.variantCB = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kr_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tests_infoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // lastnameTB
            // 
            this.lastnameTB.Location = new System.Drawing.Point(88, 52);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(222, 20);
            this.lastnameTB.TabIndex = 2;
            this.lastnameTB.Text = "Бочкарев";
            // 
            // firstnameTB
            // 
            this.firstnameTB.Location = new System.Drawing.Point(88, 78);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(222, 20);
            this.firstnameTB.TabIndex = 3;
            this.firstnameTB.Text = "Вадим";
            // 
            // groupTB
            // 
            this.groupTB.Location = new System.Drawing.Point(88, 26);
            this.groupTB.Name = "groupTB";
            this.groupTB.Size = new System.Drawing.Size(147, 20);
            this.groupTB.TabIndex = 1;
            this.groupTB.Text = "ПИ-18-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Группа";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(88, 143);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(171, 40);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Начать тестирование";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вариант";
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
            this.tests_infoBindingSource.CurrentChanged += new System.EventHandler(this.tests_infoBindingSource_CurrentChanged);
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
            // variantCB
            // 
            this.variantCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tests_infoBindingSource, "test_name", true));
            this.variantCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variantCB.FormattingEnabled = true;
            this.variantCB.Location = new System.Drawing.Point(88, 104);
            this.variantCB.Name = "variantCB";
            this.variantCB.Size = new System.Drawing.Size(222, 21);
            this.variantCB.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 222);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.variantCB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lastnameTB);
            this.tabPage1.Controls.Add(this.startBtn);
            this.tabPage1.Controls.Add(this.firstnameTB);
            this.tabPage1.Controls.Add(this.groupTB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ученик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.passwordTB);
            this.tabPage2.Controls.Add(this.loginTB);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Учитель";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Логин";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(124, 79);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(144, 20);
            this.passwordTB.TabIndex = 2;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(124, 53);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(144, 20);
            this.loginTB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 246);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Тестировение по дисциплине \"Радиология\"";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kr_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tests_infoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.TextBox groupTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label4;
        private WindowsFormsApp2.kr_dbDataSet kr_dbDataSet;
        private System.Windows.Forms.BindingSource tests_infoBindingSource;
        private WindowsFormsApp2.kr_dbDataSetTableAdapters.tests_infoTableAdapter tests_infoTableAdapter;
        private WindowsFormsApp2.kr_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox variantCB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Button button1;
    }
}

