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
    public partial class UbahProfilPemilik : Form
    {
        Form1 mParent;
        public UbahProfilPemilik(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void UbahProfilPemilik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text.Length > 0)
                mParent.pemilik.Name = textBoxNama.Text;
            if (textBoxAlamat.Text.Length > 0)
                mParent.pemilik.Alamat = textBoxAlamat.Text;
            if (textBoxNoTelepon.Text.Length > 0)
                mParent.pemilik.NomorTelepon = textBoxNoTelepon.Text;
            if (textBoxEmail.Text.Length > 0)
                mParent.pemilik.Email = textBoxEmail.Text;
            if (textBoxNama.Text.Length == 0 &&
                textBoxAlamat.Text.Length == 0 &&
                textBoxNoTelepon.Text.Length == 0 &&
                    textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("You can't let data empty !", "Edit failed !");
            }
            else
            {
                MessageBox.Show("Edit data success !!!", "Edit Success !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPemilik(mParent));
        }
    }
}
