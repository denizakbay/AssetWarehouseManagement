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
    public partial class FrmDuyuru : Form
    {
        public FrmDuyuru()
        {
            InitializeComponent();
        }

        private void FrmDuyuru_Load(object sender, EventArgs e)
        {
            AnnouncementsDAL announcementsDAL = new AnnouncementsDAL();
            List<AnnouncementsDTO> announcementsDTO = announcementsDAL.Get();



            // Verileri ListView'e ekle
            int i = 0;
            foreach (var item in announcementsDTO)
            {
                i++;
                ListViewItem lvi = new ListViewItem((i).ToString());
                lvi.SubItems.Add(item.Date.ToString());
                lvi.SubItems.Add(item.Title);
                lvi.SubItems.Add(item.Description);

                lstvDuyuru.Items.Add(lvi);
            }
            lstvDuyuru.View = View.Details;
            lstvDuyuru.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void btnListegeridon_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO();
            FrmVarlıkListeleme frmVarlıkListeleme = new FrmVarlıkListeleme(userDTO);
            frmVarlıkListeleme.Show();
        }
    }
}
