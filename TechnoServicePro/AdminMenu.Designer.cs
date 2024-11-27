namespace TechnoServicePro
{
    partial class AdminMenu
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
            this.кодзаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оборудованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коднеисправностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниепроблемыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ответственныйисполнительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technoDataSet = new TechnoServicePro.TechnoDataSet();
            this.заявкиTableAdapter = new TechnoServicePro.TechnoDataSetTableAdapters.ЗаявкиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодзаявкиDataGridViewTextBoxColumn,
            this.датазаявкиDataGridViewTextBoxColumn,
            this.оборудованиеDataGridViewTextBoxColumn,
            this.коднеисправностиDataGridViewTextBoxColumn,
            this.описаниепроблемыDataGridViewTextBoxColumn,
            this.кодклиентаDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.ответственныйисполнительDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заявкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(123, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодзаявкиDataGridViewTextBoxColumn
            // 
            this.кодзаявкиDataGridViewTextBoxColumn.DataPropertyName = "Код_заявки";
            this.кодзаявкиDataGridViewTextBoxColumn.HeaderText = "Код_заявки";
            this.кодзаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодзаявкиDataGridViewTextBoxColumn.Name = "кодзаявкиDataGridViewTextBoxColumn";
            this.кодзаявкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодзаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датазаявкиDataGridViewTextBoxColumn
            // 
            this.датазаявкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_заявки";
            this.датазаявкиDataGridViewTextBoxColumn.HeaderText = "Дата_заявки";
            this.датазаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датазаявкиDataGridViewTextBoxColumn.Name = "датазаявкиDataGridViewTextBoxColumn";
            this.датазаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // оборудованиеDataGridViewTextBoxColumn
            // 
            this.оборудованиеDataGridViewTextBoxColumn.DataPropertyName = "Оборудование";
            this.оборудованиеDataGridViewTextBoxColumn.HeaderText = "Оборудование";
            this.оборудованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.оборудованиеDataGridViewTextBoxColumn.Name = "оборудованиеDataGridViewTextBoxColumn";
            this.оборудованиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // коднеисправностиDataGridViewTextBoxColumn
            // 
            this.коднеисправностиDataGridViewTextBoxColumn.DataPropertyName = "Код_неисправности";
            this.коднеисправностиDataGridViewTextBoxColumn.HeaderText = "Код_неисправности";
            this.коднеисправностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.коднеисправностиDataGridViewTextBoxColumn.Name = "коднеисправностиDataGridViewTextBoxColumn";
            this.коднеисправностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // описаниепроблемыDataGridViewTextBoxColumn
            // 
            this.описаниепроблемыDataGridViewTextBoxColumn.DataPropertyName = "Описание_проблемы";
            this.описаниепроблемыDataGridViewTextBoxColumn.HeaderText = "Описание_проблемы";
            this.описаниепроблемыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниепроблемыDataGridViewTextBoxColumn.Name = "описаниепроблемыDataGridViewTextBoxColumn";
            this.описаниепроблемыDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            this.кодклиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Width = 125;
            // 
            // ответственныйисполнительDataGridViewTextBoxColumn
            // 
            this.ответственныйисполнительDataGridViewTextBoxColumn.DataPropertyName = "Ответственный_исполнитель";
            this.ответственныйисполнительDataGridViewTextBoxColumn.HeaderText = "Ответственный_исполнитель";
            this.ответственныйисполнительDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ответственныйисполнительDataGridViewTextBoxColumn.Name = "ответственныйисполнительDataGridViewTextBoxColumn";
            this.ответственныйисполнительDataGridViewTextBoxColumn.Width = 125;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.technoDataSet;
            // 
            // technoDataSet
            // 
            this.technoDataSet.DataSetName = "TechnoDataSet";
            this.technoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(469, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(46, 438);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(46, 506);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(65, 559);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(229, 313);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(229, 358);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 11;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 407);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 710);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TechnoDataSet technoDataSet;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private TechnoDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оборудованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коднеисправностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниепроблемыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответственныйисполнительDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}