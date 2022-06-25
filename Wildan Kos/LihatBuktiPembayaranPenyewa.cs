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
    public partial class LihatBuktiPembayaranPenyewa : Form
    {
        private Form1 mParent;
        public LihatBuktiPembayaranPenyewa(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
            InitDataPenyewa();
        }

        void InitDataPenyewa()
        {
            foreach(Penyewa penyewa in mParent.listPenyewa)
            {
                comboBox1.Items.Add(penyewa.Nama);
            }
        }
        private void LihatBuktiPembayaranPenyewa_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPemilik(mParent));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Penyewa penyewa in mParent.listPenyewa)
            {
                if(comboBox1.Text.Equals(penyewa.Nama))
                {
                    if(penyewa.mBuktiTransaksi!=null)
                    {
                        pictureBox1.Image = penyewa.mBuktiTransaksi.Image;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        MessageBox.Show($"Penyewa {penyewa.Nama} telah membayar tagihan !", "Terbayar !!!");
                    }
                    else
                    {
                        MessageBox.Show($"Penyewa {penyewa.Nama} belum membayar tagihan !", "Belum Terbayar !!!");
                    }
                }
            }
        }
    }
}
