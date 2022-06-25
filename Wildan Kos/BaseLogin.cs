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
    public partial class BaseLogin : Form
    {
        Form1 mParent;
        public BaseLogin(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void BaseLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void PemilikButton_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new LoginPemilik(mParent));
        }

        private void PenyewaButton_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new UserPenyewa(mParent));
        }
    }
}
