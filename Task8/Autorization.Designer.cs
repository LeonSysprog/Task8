
namespace Task8
{
    partial class Autorization
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
            this.adminButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(120, 150);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(177, 67);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(481, 150);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(177, 67);
            this.userButton.TabIndex = 1;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.adminButton);
            this.Name = "Autorization";
            this.Text = "Autorization";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button userButton;
    }
}