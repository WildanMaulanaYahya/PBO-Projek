using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildan_Kos
{
    public class Pemilik
    {
        public string username = "Admin";
        public string password = "12345";

        private string mName = "ResZ";
        private string mAlamat;
        private string mNoTelepon;
        private string mEmail;

        public string Name
        {
            get => mName;
            set => mName = value;
        }

        public string Alamat
        {
            get => mAlamat;
            set => mAlamat = value;
        }
        
        public string NomorTelepon
        {
            get => mNoTelepon;
            set => mNoTelepon = value;
        }

        public string Email
        {
            get => mEmail;
            set => mEmail = value;
        }
        public Pemilik()
        {

        }
    }
}
