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
    public partial class MenuPenyewa : Form
    {
        private Form1 mParent;
        public MenuPenyewa(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void MenuPenyewa_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new BaseLogin(mParent));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new ProfilPenyewa(mParent));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new LihatDataKamarAsPenyewa(mParent));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new UbahDataProfilPenyewa(mParent));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new UploadBuktiPembayaran(mParent));
        }
    }
}
