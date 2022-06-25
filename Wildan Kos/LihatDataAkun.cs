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
    public partial class LihatDataAkun : Form
    {
        Form1 mParent;
        public LihatDataAkun(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
            dataGridView1.DataSource = mParent.listPenyewa;
        }

        private void LihatDataAkun_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPemilik(mParent));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
