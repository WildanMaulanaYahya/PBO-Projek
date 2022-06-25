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
    public partial class LihatDataKamar : Form
    {
        Form1 mParent;
        public LihatDataKamar(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
            dataGridView1.DataSource = mParent.listKamar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPemilik(mParent));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                KamarKos rowData = item.DataBoundItem as KamarKos;
                if (rowData != null)
                {
                    // Do your stuff
                    
                }
            }
        }

        private void LihatDataKamar_Load(object sender, EventArgs e)
        {

        }
    }
}
