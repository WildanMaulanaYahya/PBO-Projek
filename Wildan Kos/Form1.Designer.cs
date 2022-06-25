
namespace Wildan_Kos
{
    partial class Form1
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
            this.PanelChildWindow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelChildWindow
            // 
            this.PanelChildWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChildWindow.Location = new System.Drawing.Point(0, 0);
            this.PanelChildWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelChildWindow.Name = "PanelChildWindow";
            this.PanelChildWindow.Size = new System.Drawing.Size(1067, 554);
            this.PanelChildWindow.TabIndex = 1;
            this.PanelChildWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChildWindow_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PanelChildWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelChildWindow;
    }
}

