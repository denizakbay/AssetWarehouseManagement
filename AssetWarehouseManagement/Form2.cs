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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {



            // Örnek veriler
            string[] degerler1 = { "Değer 1-1", "Değer 1-2", "Değer 1-3", "Değer 1-4", "Değer 1-5", "Değer 1-6" };
            string[] degerler2 = { "Değer 2-1", "Değer 2-2", "Değer 2-3", "Değer 2-4", "Değer 2-5", "Değer 2-6" };
            string[] degerler3 = { "Değer 3-1", "Değer 3-2", "Değer 3-3", "Değer 3-4", "Değer 3-5", "Değer 3-6" };

            // Verileri ListView'e ekle
            for (int i = 0; i < degerler1.Length; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();
                lvi.SubItems.Add(degerler1[i]);
                lvi.SubItems.Add(degerler2[i]);
                lvi.SubItems.Add(degerler3[i]);
                lvi.SubItems.Add("Değer 4");
                lvi.SubItems.Add("Değer 5");
                lstListeleme.Items.Add(lvi);
            }


        }
        private void lstListeleme_SelectedIndexChanged(object sender, EventArgs e)
        {
         


        }

       
    }
}
