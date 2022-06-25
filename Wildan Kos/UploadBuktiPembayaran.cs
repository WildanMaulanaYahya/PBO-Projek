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
    public partial class UploadBuktiPembayaran : Form
    {
        private Form1 mParent;
        public UploadBuktiPembayaran(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
            if (mParent.AsLoginUser.mBuktiTransaksi != null)
            {
                pictureBox1.Image = mParent.AsLoginUser.mBuktiTransaksi.Image;
                pictureBox1.Refresh();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void UploadBuktiPembayaran_Load(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPenyewa(mParent));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mParent.AsLoginUser.mBuktiTransaksi = pictureBox1;
            if (pictureBox1.Image != null)
                MessageBox.Show("Upload Success !!!", "Success !!!");
            else
            {
                MessageBox.Show("Upload Failed !!!", "Failure !");
            }
        }
    }
}
