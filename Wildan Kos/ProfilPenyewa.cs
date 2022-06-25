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
    public partial class ProfilPenyewa : Form
    {
        Form1 mParent;
        public ProfilPenyewa(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
            InitData();
        }

        private void LihatDataPenyewa_Load(object sender, EventArgs e)
        {

        }

        private void InitData()
        {
            labelPassword.Text = mParent.AsLoginUser.Password;
            labelUsername.Text = mParent.AsLoginUser.Username;
            labelNama.Text = mParent.AsLoginUser.Nama;
            labelAlamat.Text = mParent.AsLoginUser.Alamat;
            labelNoTelepon.Text = mParent.AsLoginUser.NomorTelepon;
            labelEmail.Text = mParent.AsLoginUser.Email;
            labelJenisKelamin.Text = mParent.AsLoginUser.Jenis_Kelamin;
            labelStatus.Text = mParent.AsLoginUser.Status;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPenyewa(mParent));
        }
    }
}
