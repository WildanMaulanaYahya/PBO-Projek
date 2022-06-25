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
    public partial class UbahDataProfilPenyewa : Form
    {
        Form1 mParent;
        public UbahDataProfilPenyewa(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string nama = textBoxNama.Text;
            string alamat = textBoxAlamat.Text;
            string noTelepon = textBoxNoTelepon.Text;
            string email = textBoxEmail.Text;
            string jenisKelamin = comboBox1.Text;
            string status = comboBox2.Text;
            if (username.Length == 0 && password.Length == 0 && nama.Length == 0 && alamat.Length == 0 &&
                noTelepon.Length == 0 && email.Length == 0 && jenisKelamin.Length == 0 && status.Length == 0)
            {
                MessageBox.Show("Data not valid, please re-enter your data !", "Caution !");
            }
            else
            {
                if (username.Length != 0)
                    mParent.AsLoginUser.Username = username;
                if (password.Length != 0)
                    mParent.AsLoginUser.Password = password;
                if (nama.Length != 0)
                    mParent.AsLoginUser.Nama = nama;
                if (alamat.Length != 0)
                    mParent.AsLoginUser.Alamat = alamat;
                if (noTelepon.Length != 0)
                    mParent.AsLoginUser.NomorTelepon = noTelepon;
                if (email.Length != 0)
                    mParent.AsLoginUser.Email = email;
                if (jenisKelamin.Length != 0)
                    mParent.AsLoginUser.Jenis_Kelamin = jenisKelamin;
                if (status.Length != 0)
                    mParent.AsLoginUser.Status = status;
                CleanForm();
                MessageBox.Show("Edit data success !!!", "Success !");
            }
        }

        private void CleanForm()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxNoTelepon.Text = "";
            textBoxEmail.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        private void UbahDataProfilPenyewa_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPenyewa(mParent));
        }
    }
}
