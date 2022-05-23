
namespace Task8
{
    partial class Report
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
            this.bookCountSuppliesButton = new System.Windows.Forms.Button();
            this.resRevenue = new System.Windows.Forms.TextBox();
            this.revenueFromOrdersButton = new System.Windows.Forms.Button();
            this.resBookCount = new System.Windows.Forms.TextBox();
            this.dateBookCountSupplies1 = new System.Windows.Forms.DateTimePicker();
            this.dateBookCountSupplies2 = new System.Windows.Forms.DateTimePicker();
            this.dateRevenueFromOrders1 = new System.Windows.Forms.DateTimePicker();
            this.dateRevenueFromOrders2 = new System.Windows.Forms.DateTimePicker();
            this.getMaxBookCountByGenreButton = new System.Windows.Forms.Button();
            this.dateGetMaxBookCountByGenre1 = new System.Windows.Forms.DateTimePicker();
            this.dateGetMaxBookCountByGenre2 = new System.Windows.Forms.DateTimePicker();
            this.BookGenre = new System.Windows.Forms.DataGridView();
            this.genreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BookGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // bookCountSuppliesButton
            // 
            this.bookCountSuppliesButton.Location = new System.Drawing.Point(36, 54);
            this.bookCountSuppliesButton.Name = "bookCountSuppliesButton";
            this.bookCountSuppliesButton.Size = new System.Drawing.Size(169, 45);
            this.bookCountSuppliesButton.TabIndex = 0;
            this.bookCountSuppliesButton.Text = "bookCountSupplies";
            this.bookCountSuppliesButton.UseVisualStyleBackColor = true;
            this.bookCountSuppliesButton.Click += new System.EventHandler(this.bookCountSuppliesButton_Click);
            // 
            // resRevenue
            // 
            this.resRevenue.Location = new System.Drawing.Point(619, 128);
            this.resRevenue.Name = "resRevenue";
            this.resRevenue.Size = new System.Drawing.Size(169, 20);
            this.resRevenue.TabIndex = 1;
            this.resRevenue.TextChanged += new System.EventHandler(this.resTextBox_TextChanged);
            // 
            // revenueFromOrdersButton
            // 
            this.revenueFromOrdersButton.Location = new System.Drawing.Point(36, 128);
            this.revenueFromOrdersButton.Name = "revenueFromOrdersButton";
            this.revenueFromOrdersButton.Size = new System.Drawing.Size(169, 45);
            this.revenueFromOrdersButton.TabIndex = 2;
            this.revenueFromOrdersButton.Text = "revenueFromOrders";
            this.revenueFromOrdersButton.UseVisualStyleBackColor = true;
            this.revenueFromOrdersButton.Click += new System.EventHandler(this.revenueFromOrdersButton_Click);
            // 
            // resBookCount
            // 
            this.resBookCount.Location = new System.Drawing.Point(619, 54);
            this.resBookCount.Name = "resBookCount";
            this.resBookCount.Size = new System.Drawing.Size(169, 20);
            this.resBookCount.TabIndex = 3;
            // 
            // dateBookCountSupplies1
            // 
            this.dateBookCountSupplies1.Location = new System.Drawing.Point(238, 54);
            this.dateBookCountSupplies1.Name = "dateBookCountSupplies1";
            this.dateBookCountSupplies1.Size = new System.Drawing.Size(159, 20);
            this.dateBookCountSupplies1.TabIndex = 4;
            // 
            // dateBookCountSupplies2
            // 
            this.dateBookCountSupplies2.Location = new System.Drawing.Point(423, 54);
            this.dateBookCountSupplies2.Name = "dateBookCountSupplies2";
            this.dateBookCountSupplies2.Size = new System.Drawing.Size(151, 20);
            this.dateBookCountSupplies2.TabIndex = 5;
            // 
            // dateRevenueFromOrders1
            // 
            this.dateRevenueFromOrders1.Location = new System.Drawing.Point(238, 128);
            this.dateRevenueFromOrders1.Name = "dateRevenueFromOrders1";
            this.dateRevenueFromOrders1.Size = new System.Drawing.Size(159, 20);
            this.dateRevenueFromOrders1.TabIndex = 6;
            // 
            // dateRevenueFromOrders2
            // 
            this.dateRevenueFromOrders2.Location = new System.Drawing.Point(423, 128);
            this.dateRevenueFromOrders2.Name = "dateRevenueFromOrders2";
            this.dateRevenueFromOrders2.Size = new System.Drawing.Size(151, 20);
            this.dateRevenueFromOrders2.TabIndex = 7;
            // 
            // getMaxBookCountByGenreButton
            // 
            this.getMaxBookCountByGenreButton.Location = new System.Drawing.Point(36, 268);
            this.getMaxBookCountByGenreButton.Name = "getMaxBookCountByGenreButton";
            this.getMaxBookCountByGenreButton.Size = new System.Drawing.Size(169, 45);
            this.getMaxBookCountByGenreButton.TabIndex = 8;
            this.getMaxBookCountByGenreButton.Text = "getMaxBookCountByGenre";
            this.getMaxBookCountByGenreButton.UseVisualStyleBackColor = true;
            this.getMaxBookCountByGenreButton.Click += new System.EventHandler(this.getMaxBookCountByGenreButton_Click);
            // 
            // dateGetMaxBookCountByGenre1
            // 
            this.dateGetMaxBookCountByGenre1.Location = new System.Drawing.Point(238, 268);
            this.dateGetMaxBookCountByGenre1.Name = "dateGetMaxBookCountByGenre1";
            this.dateGetMaxBookCountByGenre1.Size = new System.Drawing.Size(159, 20);
            this.dateGetMaxBookCountByGenre1.TabIndex = 9;
            // 
            // dateGetMaxBookCountByGenre2
            // 
            this.dateGetMaxBookCountByGenre2.Location = new System.Drawing.Point(238, 306);
            this.dateGetMaxBookCountByGenre2.Name = "dateGetMaxBookCountByGenre2";
            this.dateGetMaxBookCountByGenre2.Size = new System.Drawing.Size(159, 20);
            this.dateGetMaxBookCountByGenre2.TabIndex = 10;
            // 
            // BookGenre
            // 
            this.BookGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreColumn,
            this.bookCountColumn});
            this.BookGenre.Location = new System.Drawing.Point(423, 208);
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.Size = new System.Drawing.Size(365, 230);
            this.BookGenre.TabIndex = 11;
            // 
            // genreColumn
            // 
            this.genreColumn.HeaderText = "genre";
            this.genreColumn.Name = "genreColumn";
            // 
            // bookCountColumn
            // 
            this.bookCountColumn.HeaderText = "bookCount";
            this.bookCountColumn.Name = "bookCountColumn";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookGenre);
            this.Controls.Add(this.dateGetMaxBookCountByGenre2);
            this.Controls.Add(this.dateGetMaxBookCountByGenre1);
            this.Controls.Add(this.getMaxBookCountByGenreButton);
            this.Controls.Add(this.dateRevenueFromOrders2);
            this.Controls.Add(this.dateRevenueFromOrders1);
            this.Controls.Add(this.dateBookCountSupplies2);
            this.Controls.Add(this.dateBookCountSupplies1);
            this.Controls.Add(this.resBookCount);
            this.Controls.Add(this.revenueFromOrdersButton);
            this.Controls.Add(this.resRevenue);
            this.Controls.Add(this.bookCountSuppliesButton);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.BookGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookCountSuppliesButton;
        private System.Windows.Forms.TextBox resRevenue;
        private System.Windows.Forms.Button revenueFromOrdersButton;
        private System.Windows.Forms.TextBox resBookCount;
        private System.Windows.Forms.DateTimePicker dateBookCountSupplies1;
        private System.Windows.Forms.DateTimePicker dateBookCountSupplies2;
        private System.Windows.Forms.DateTimePicker dateRevenueFromOrders1;
        private System.Windows.Forms.DateTimePicker dateRevenueFromOrders2;
        private System.Windows.Forms.Button getMaxBookCountByGenreButton;
        private System.Windows.Forms.DateTimePicker dateGetMaxBookCountByGenre1;
        private System.Windows.Forms.DateTimePicker dateGetMaxBookCountByGenre2;
        private System.Windows.Forms.DataGridView BookGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCountColumn;
    }
}