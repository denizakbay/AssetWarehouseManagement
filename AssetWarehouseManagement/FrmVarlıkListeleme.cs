using AssetWarehouseManagement.DAL;
using AssetWarehouseManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetWarehouseManagement
{
    public partial class FrmVarlıkListeleme : Form
    {
        private UserDTO user;
        public FrmVarlıkListeleme(UserDTO userDTO)
        {
            user = userDTO;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblUserName.Text = user.UserName;
            lblRole.Text = user.Role;
            AssetDAL assetDAL = new AssetDAL();
            List<AssetDTO> assetDTO = assetDAL.Get(user.UserID);



            // Verileri ListView'e ekle
            foreach (var item in assetDTO)
            {
            ListViewItem lvi = new ListViewItem(item.RegistrationNumber);
            lvi.SubItems.Add(item.Barcode.ToString());
            lvi.SubItems.Add(item.ProductType);
            lvi.SubItems.Add(item.CurrentValue.ToString());
            lvi.SubItems.Add(item.Brand);
            lvi.SubItems.Add(item.Model);
            lstListeleme.Items.Add(lvi);
            }


        }
        private void lstListeleme_SelectedIndexChanged(object sender, EventArgs e)
        {



        }


    }
}
