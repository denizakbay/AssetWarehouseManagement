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
    public partial class FrmSıkSorulanSorular : Form
    {
        public FrmSıkSorulanSorular()
        {
            InitializeComponent();
        }

        private void lstsss_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsss_Click(object sender, EventArgs e)
        {
            #region kalsın

            //int id = 1; // veya farklı bir FAQID değeri
            //SSSDAL sSSDAL = new SSSDAL();
            //SSSDTO sSSDTO = sSSDAL.Get(id);

            //// listbox'a soru ve cevabı ekleyin
            //lstsss.Items.Add("Question: " + sSSDTO.Question);
            //lstsss.Items.Add("Answer: " + sSSDTO.Answer);

            //int id = 1; // or any other FAQID value
            //SSSDAL sSSDAL = new SSSDAL();
            //List<SSSDTO> sSSDTOsList = sSSDAL.Get(id);

            //// loop through the list and add each question and answer to the listbox
            //foreach (SSSDTO sSSDTO in sSSDTOsList)
            //{
            //    lstsss.Items.Add("Question: " + sSSDTO.Question);
            //    lstsss.Items.Add("Answer: " + sSSDTO.Answer);
            //} 
            #endregion

            SSSDAL sSSDAL = new SSSDAL();
            List<SSSDTO> sSSDTOList = sSSDAL.Get();

            foreach (SSSDTO sSSDTO in sSSDTOList)
            {
                lstsss.Items.Add("Question: " + sSSDTO.Question);
                lstsss.Items.Add("Answer: " + sSSDTO.Answer);
            }


        }
    }
}
