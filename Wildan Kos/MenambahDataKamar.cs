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
    public partial class MenambahDataKamar : Form
    {
        Form1 mParent;
        public MenambahDataKamar(Form1 parent)
        {
            InitializeComponent();
            mParent = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mParent.OpenChildForm(new MenuPemilik(mParent));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNamaKamar.Text.Length == 0 || textBoxKeterangan.Text.Length == 0)
            {
                MessageBox.Show("Data not valid !!!", "Add Data Failed !!!");
            }
            else
            {
                mParent.listKamar.Add(new KamarKos() { NamaKamarKos = textBoxNamaKamar.Text, Keterangan = textBoxKeterangan.Text });
                MessageBox.Show("Tambah Kamar Sukses !", "Success !!!");
            }
        }
    }
}
