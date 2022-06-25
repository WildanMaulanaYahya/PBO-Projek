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
    public partial class ProfilPemilik : Form
    {
        private Form1 mParent;
        public ProfilPemilik(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
            SetDataLabel();
        }

        private void SetDataLabel()
        {
            LabelNama.Text = mParent.pemilik.Name;
            LabelAlamat.Text = mParent.pemilik.Alamat;
            LabelNoTelepon.Text = mParent.pemilik.NomorTelepon;
            LabelEmail.Text = mParent.pemilik.Email;
        }

        private void ProfilPemilik_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPemilik(mParent));
        }
    }
}
