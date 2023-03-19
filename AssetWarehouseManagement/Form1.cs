using AssetWarehouseManagement.DAL;
using AssetWarehouseManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetWarehouseManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            UserDAL userDAL = new UserDAL();
            UserDTO userDTO = userDAL.Get(txtKullaniciAdi.Text, txtSifre.Text);

            if(!string.IsNullOrEmpty(userDTO.UserName))
            {
                MessageBox.Show("Basarili");

                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }


        }

    }
}
