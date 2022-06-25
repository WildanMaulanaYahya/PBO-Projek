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
    public partial class LoginPenyewa : Form
    {
        private Form1 mParent;
        public LoginPenyewa(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void LoginPenyewa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new UserPenyewa(mParent));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Penyewa penyewa in mParent.listPenyewa)
            {
                if(UsernameBox.Text.Equals(penyewa.Username)&&PasswordBox.Text.Equals(penyewa.Password))
                {
                    mParent.AsLoginUser = penyewa;
                    MessageBox.Show("Login Success !!!", "Success !!!");
                    mParent.OpenChildForm(new MenuPenyewa(mParent));
                    return;
                }
            }
            MessageBox.Show("Data not found !!!", "Failed to login !");
        }
    }
}
