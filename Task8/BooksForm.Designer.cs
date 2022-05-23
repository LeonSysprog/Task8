
namespace Task8
{
    partial class BooksForm
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
            this.idAuthor = new System.Windows.Forms.TextBox();
            this.idDepartment = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.publisherCode = new System.Windows.Forms.TextBox();
            this.language = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idAuthor
            // 
            this.idAuthor.Location = new System.Drawing.Point(70, 73);
            this.idAuthor.Name = "idAuthor";
            this.idAuthor.Size = new System.Drawing.Size(174, 20);
            this.idAuthor.TabIndex = 0;
            // 
            // idDepartment
            // 
            this.idDepartment.Location = new System.Drawing.Point(70, 126);
            this.idDepartment.Name = "idDepartment";
            this.idDepartment.Size = new System.Drawing.Size(174, 20);
            this.idDepartment.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(70, 175);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(174, 20);
            this.name.TabIndex = 2;
            // 
            // publisherCode
            // 
            this.publisherCode.Location = new System.Drawing.Point(70, 232);
            this.publisherCode.Name = "publisherCode";
            this.publisherCode.Size = new System.Drawing.Size(174, 20);
            this.publisherCode.TabIndex = 3;
            // 
            // language
            // 
            this.language.Location = new System.Drawing.Point(70, 286);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(174, 20);
            this.language.TabIndex = 4;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(269, 71);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(117, 23);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(269, 124);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(117, 23);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.idAuthorColumn,
            this.idDepartmentColumn,
            this.nameColumn,
            this.publisherCodeColumn,
            this.languageColumn});
            this.dataGridView1.Location = new System.Drawing.Point(392, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 279);
            this.dataGridView1.TabIndex = 8;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            // 
            // idAuthorColumn
            // 
            this.idAuthorColumn.HeaderText = "author";
            this.idAuthorColumn.Name = "idAuthorColumn";
            // 
            // idDepartmentColumn
            // 
            this.idDepartmentColumn.HeaderText = "department";
            this.idDepartmentColumn.Name = "idDepartmentColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "name";
            this.nameColumn.Name = "nameColumn";
            // 
            // publisherCodeColumn
            // 
            this.publisherCodeColumn.HeaderText = "publisherCode";
            this.publisherCodeColumn.Name = "publisherCodeColumn";
            // 
            // languageColumn
            // 
            this.languageColumn.HeaderText = "language";
            this.languageColumn.Name = "languageColumn";
            // 
            // BooksFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.language);
            this.Controls.Add(this.publisherCode);
            this.Controls.Add(this.name);
            this.Controls.Add(this.idDepartment);
            this.Controls.Add(this.idAuthor);
            this.Name = "BooksFrom";
            this.Text = "adminBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idAuthor;
        private System.Windows.Forms.TextBox idDepartment;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox publisherCode;
        private System.Windows.Forms.TextBox language;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageColumn;
    }
}