
namespace Task8
{
    partial class AuthorsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fio = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.death = new System.Windows.Forms.DateTimePicker();
            this.InsertButton = new System.Windows.Forms.Button();
            this.task8DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task8DataSet = new Task8.Task8DataSet();
            this.Authors = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.task8DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task8DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authors)).BeginInit();
            this.SuspendLayout();
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(52, 74);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(200, 20);
            this.fio.TabIndex = 0;
            this.fio.TextChanged += new System.EventHandler(this.fio_TextChanged);
            // 
            // birth
            // 
            this.birth.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.birth.Location = new System.Drawing.Point(52, 134);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(200, 20);
            this.birth.TabIndex = 3;
            this.birth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // death
            // 
            this.death.Location = new System.Drawing.Point(52, 209);
            this.death.Name = "death";
            this.death.Size = new System.Drawing.Size(200, 20);
            this.death.TabIndex = 4;
            this.death.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(52, 269);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(115, 23);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // task8DataSetBindingSource
            // 
            this.task8DataSetBindingSource.DataSource = this.task8DataSet;
            this.task8DataSetBindingSource.Position = 0;
            // 
            // task8DataSet
            // 
            this.task8DataSet.DataSetName = "Task8DataSet";
            this.task8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Authors
            // 
            this.Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Authors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.fioColumn,
            this.birthColumn,
            this.deathColumn});
            this.Authors.Location = new System.Drawing.Point(280, 74);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(522, 232);
            this.Authors.TabIndex = 6;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            // 
            // fioColumn
            // 
            this.fioColumn.HeaderText = "fio";
            this.fioColumn.Name = "fioColumn";
            // 
            // birthColumn
            // 
            this.birthColumn.HeaderText = "birth";
            this.birthColumn.Name = "birthColumn";
            // 
            // deathColumn
            // 
            this.deathColumn.HeaderText = "death";
            this.deathColumn.Name = "deathColumn";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(52, 312);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(115, 23);
            this.selectButton.TabIndex = 7;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.Authors);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.death);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.fio);
            this.Name = "AuthorsForm";
            this.Text = "adminAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.task8DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task8DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.DateTimePicker death;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.BindingSource task8DataSetBindingSource;
        private Task8DataSet task8DataSet;
        private System.Windows.Forms.DataGridView Authors;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

