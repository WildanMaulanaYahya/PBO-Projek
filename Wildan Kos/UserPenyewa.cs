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
    public partial class UserPenyewa : Form
    {
        private Form1 mParent;
        public UserPenyewa(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new LoginPenyewa(mParent));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new RegisterPenyewa(mParent));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new BaseLogin(mParent));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
