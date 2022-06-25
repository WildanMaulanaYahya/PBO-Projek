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
    public partial class RegisterPenyewa : Form
    {
        private Form1 mParent;
        public RegisterPenyewa(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void RegisterPemilik_Load(object sender, EventArgs e)
        {

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
            if (username.Length == 0 || password.Length == 0 || nama.Length == 0 || alamat.Length == 0 ||
                noTelepon.Length == 0 || email.Length == 0 || jenisKelamin.Length == 0 || status.Length == 0)
            {
                MessageBox.Show("Data not valid, please re-enter your data !", "Caution !");
            }
            else
            {
                mParent.listPenyewa.Add(new Penyewa()
                {
                    Username = username,
                    Password = password,
                    Nama = nama,
                    Alamat = alamat,
                    NomorTelepon = noTelepon,
                    Email = email,
                    Jenis_Kelamin = jenisKelamin,
                    Status = status
                });

                //Penyewa temp = new Penyewa(username, password, nama, alamat, status, noTelepon, email, jenisKelamin);
                //mParent.listPenyewa.Add(temp);
                CleanForm();
                MessageBox.Show("Register Completed ! You can login now !", "Success !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new UserPenyewa(mParent));
        }
    }
}
