using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wildan_Kos
{
    public class Penyewa
    {
        private string mUsername;
        private string mPassword;
        private string mNama;
        private string mAlamat;
        private string mStatus;
        private string mNomorTelepon;
        private string mJenisKelamin;
        private string mEmail;

        public PictureBox mBuktiTransaksi = null;
        public Penyewa()
        {

        }
        public Penyewa(string username,string password,string nama,string alamat,
            string status,string nomortelepon,string email,string jeniskelamin)
        {
            mUsername = username;
            mPassword = password;
            mNama = nama;
            mAlamat = alamat;
            mStatus = status;
            mNomorTelepon = nomortelepon;
            mEmail = email;
            mJenisKelamin = jeniskelamin;
        }
        public string Username
        {
            get => mUsername;
            set => mUsername = value;
        }

        public string Password
        {
            get => mPassword;
            set => mPassword = value;
        }

        public string Jenis_Kelamin
        {
            get => mJenisKelamin;
            set => mJenisKelamin = value;
        }
        public string Alamat
        {
            get => mAlamat;
            set => mAlamat = value;
        }

        public string Status
        {
            get => mStatus;
            set => mStatus = value;
        }

        public string NomorTelepon
        {
            get => mNomorTelepon;
            set => mNomorTelepon = value;
        }

        public string Email
        {
            get => mEmail;
            set => mEmail = value;
        }

        public string Nama
        {
            get => mNama;
            set => mNama = value;
        }

    }
}
