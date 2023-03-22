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

    public partial class FrmFiltreListe : Form
    {
        private UserDTO user;
        public FrmFiltreListe(UserDTO userDTO)
        {
            user = userDTO;
            InitializeComponent();
        }

        private void FrmFiltreListe_Load(object sender, EventArgs e)
        {
        
            AssetReportDAL assetReportDAL = new AssetReportDAL();
            List<AssetReportDTO> assetReportDTOs = assetReportDAL.Get(user.UserID);



            // Verileri ListView'e ekle
            foreach (var item in assetReportDTOs)
            {
                ListViewItem lvi = new ListViewItem(item.RegistrationNumber);
                lvi.SubItems.Add(item.Barcode.ToString());
                lvi.SubItems.Add(item.ProductType);
                lvi.SubItems.Add(item.CurrentValue.ToString());
                lvi.SubItems.Add(item.Brand);
                lvi.SubItems.Add(item.Model);
                lstFiltre.Items.Add(lvi);
            }
            lstFiltre.View = View.Details;
            lstFiltre.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string searhBarcod = txtBarkod.Text;

            AssetReportDAL assetReportDAL = new AssetReportDAL();
            List<AssetReportDTO> assetReportDTOs = assetReportDAL.Get(user.UserID);


            lstFiltre.Items.Clear();
            // Verileri ListView'e ekle
            foreach (var item in assetReportDTOs)
            {
                if (item.Barcode == searhBarcod)
                {
                    ListViewItem lvi = new ListViewItem(item.RegistrationNumber);
                    lvi.SubItems.Add(item.Barcode.ToString());
                    lvi.SubItems.Add(item.ProductType);
                    lvi.SubItems.Add(item.CurrentValue.ToString());
                    lvi.SubItems.Add(item.Brand);
                    lvi.SubItems.Add(item.Model);
                    lstFiltre.Tag = item;
                    lstFiltre.Items.Add(lvi);
                }
               
            }
            lstFiltre.View = View.Details;
            lstFiltre.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}
