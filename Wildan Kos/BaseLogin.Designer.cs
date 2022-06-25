
namespace Wildan_Kos
{
    partial class BaseLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.PemilikButton = new System.Windows.Forms.Button();
            this.PenyewaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wildan Kos";
            // 
            // PemilikButton
            // 
            this.PemilikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PemilikButton.Location = new System.Drawing.Point(261, 172);
            this.PemilikButton.Name = "PemilikButton";
            this.PemilikButton.Size = new System.Drawing.Size(248, 46);
            this.PemilikButton.TabIndex = 1;
            this.PemilikButton.Text = "Pemilik";
            this.PemilikButton.UseVisualStyleBackColor = true;
            this.PemilikButton.Click += new System.EventHandler(this.PemilikButton_Click);
            // 
            // PenyewaButton
            // 
            this.PenyewaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenyewaButton.Location = new System.Drawing.Point(261, 236);
            this.PenyewaButton.Name = "PenyewaButton";
            this.PenyewaButton.Size = new System.Drawing.Size(248, 46);
            this.PenyewaButton.TabIndex = 2;
            this.PenyewaButton.Text = "Penyewa";
            this.PenyewaButton.UseVisualStyleBackColor = true;
            this.PenyewaButton.Click += new System.EventHandler(this.PenyewaButton_Click);
            // 
            // BaseLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PenyewaButton);
            this.Controls.Add(this.PemilikButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseLogin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.BaseLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PemilikButton;
        private System.Windows.Forms.Button PenyewaButton;
    }
}