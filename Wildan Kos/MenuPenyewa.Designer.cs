﻿
namespace Wildan_Kos
{
    partial class MenuPenyewa
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
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(231, 376);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(310, 39);
            this.button11.TabIndex = 23;
            this.button11.Text = "Logout";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menu Penyewa";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(429, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(310, 39);
            this.button5.TabIndex = 16;
            this.button5.Text = "Melihat Data Kamar Kos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(41, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ubah Data Akun";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lihat Data Akun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(429, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 39);
            this.button3.TabIndex = 24;
            this.button3.Text = "Upload Bukti Pembayaran";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MenuPenyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MenuPenyewa";
            this.Text = "MenuPenyewa";
            this.Load += new System.EventHandler(this.MenuPenyewa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}