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
    public partial class LihatDataKamarAsPenyewa : Form
    {
        Form1 mParent;
        public LihatDataKamarAsPenyewa(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
            dataGridView1.DataSource = mParent.listKamar;
        }

        private void LihatDataKamarAsPenyewa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPenyewa(mParent));
        }
    }
}
