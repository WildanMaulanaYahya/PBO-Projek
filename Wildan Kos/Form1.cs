using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wildan_Kos
{
    public partial class Form1 : Form
    {
        private Form currentForm = null;
        public Pemilik pemilik = new Pemilik();
        public List<Penyewa> listPenyewa = new List<Penyewa>();
        public List<KamarKos> listKamar = new List<KamarKos>();
        public Penyewa AsLoginUser = null;
        public Form1()
        {
            InitializeComponent();
            OpenChildForm(new BaseLogin(this));
        }
        public void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildWindow.Controls.Add(childForm);
            PanelChildWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelChildWindow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
