
namespace Task8
{
    partial class Search
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
            this.searchTable = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTable
            // 
            this.searchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.clientColumn,
            this.orderDateColumn,
            this.totalAmountColumn,
            this.orderColumn,
            this.bookColumn,
            this.bookCountColumn,
            this.costColumn});
            this.searchTable.Location = new System.Drawing.Point(4, 140);
            this.searchTable.Name = "searchTable";
            this.searchTable.Size = new System.Drawing.Size(795, 238);
            this.searchTable.TabIndex = 1;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            // 
            // clientColumn
            // 
            this.clientColumn.HeaderText = "client";
            this.clientColumn.Name = "clientColumn";
            // 
            // orderDateColumn
            // 
            this.orderDateColumn.HeaderText = "orderDate";
            this.orderDateColumn.Name = "orderDateColumn";
            // 
            // totalAmountColumn
            // 
            this.totalAmountColumn.HeaderText = "totalAmount";
            this.totalAmountColumn.Name = "totalAmountColumn";
            // 
            // orderColumn
            // 
            this.orderColumn.HeaderText = "order";
            this.orderColumn.Name = "orderColumn";
            // 
            // bookColumn
            // 
            this.bookColumn.HeaderText = "book";
            this.bookColumn.Name = "bookColumn";
            // 
            // bookCountColumn
            // 
            this.bookCountColumn.HeaderText = "bookCount";
            this.bookCountColumn.Name = "bookCountColumn";
            // 
            // costColumn
            // 
            this.costColumn.HeaderText = "cost";
            this.costColumn.Name = "costColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "orderDate";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(241, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(159, 33);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "SearchByDate";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "totalAmount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "bookCount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "SearchByAmount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "SearchByBookCount";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "TotalSearch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTable);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView searchTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}