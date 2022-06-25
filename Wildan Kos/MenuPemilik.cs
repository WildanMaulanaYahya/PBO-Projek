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
    public partial class MenuPemilik : Form
    {
        private Form1 mParent;
        public MenuPemilik(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void MenuPemilik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new ProfilPemilik(mParent));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new BaseLogin(mParent));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new UbahProfilPemilik(mParent));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new LihatDataAkun(mParent));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenambahDataKamar(mParent));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new LihatDataKamar(mParent));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new LihatBuktiPembayaranPenyewa(mParent));
        }
    }
}
