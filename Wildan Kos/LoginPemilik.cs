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
    public partial class LoginPemilik : Form
    {
        private Form1 parent = null;
        public LoginPemilik(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void LoginPemilik_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UsernameBox.Text.Equals(parent.pemilik.username)&&PasswordBox.Text.Equals(parent.pemilik.password))
            {
                parent.OpenChildForm(new MenuPemilik(parent));
            }
            else
            {
                MessageBox.Show("Username or Password is wrong !!!", "Login failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.OpenChildForm(new BaseLogin(parent));
        }
    }
}
