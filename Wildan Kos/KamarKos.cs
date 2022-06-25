using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildan_Kos
{
    public class KamarKos
    {
        private string mNamaKamarKos;
        private string mKeterangan;

        public string NamaKamarKos
        {
            get => mNamaKamarKos;
            set => mNamaKamarKos = value;
        }

        public string Keterangan
        {
            get => mKeterangan;
            set => mKeterangan = value;
        }
    }
}
