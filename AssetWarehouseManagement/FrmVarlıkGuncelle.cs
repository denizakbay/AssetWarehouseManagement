using AssetWarehouseManagement.DAL.Repos;
using AssetWarehouseManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetWarehouseManagement
{
    public partial class FrmVarlıkGuncelle : Form
    {



    
        public FrmVarlıkGuncelle()
        {
          
            InitializeComponent();
        }
        //private void Yukle()
        //{
        //    //Connection 
        //    //Command 


        //    #region MyRegion
        //    //  SqlConnectionStringBuilder bl = new SqlConnectionStringBuilder();
        //    //  bl.DataSource = ".";
        //    //  //bl.UserID = "sa";
        //    //  //bl.Password = "123";
        //    //  bl.InitialCatalog = "Northwind";
        //    //  bl.IntegratedSecurity = true;

        //    //  SqlConnection conn = new SqlConnection(bl.ConnectionString);
        //    ////  conn.ConnectionString = bl.ConnectionString; 
        //    #endregion
        //    SqlConnection conn = new SqlConnection("server=.;Database=Northwind;uid=sa;pwd=123");
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = "select * from Shippers where IsDeleted=1";
        //    cmd.Connection = conn;

        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        conn.Open();
        //    }

        //    //   SqlDataReader rdr01 = new SqlDataReader();
        //    SqlDataReader rdr = cmd.ExecuteReader();
        //    List<KargoBilgisi> listem = null;
        //    if (rdr.HasRows)
        //    {
        //        lstKargolar.Items.Clear();
        //        listem = new List<KargoBilgisi>();
        //        while (rdr.Read())
        //        {
        //            KargoBilgisi kb = new KargoBilgisi();
        //            kb.KargoID = rdr.GetInt32(0);
        //            kb.KargoAdi = rdr.GetString(1);
        //            kb.Tel = rdr.GetString(2);
        //            kb.AktifMi = (bool)rdr["IsDeleted"];
        //            // lstKargolar.Items.Add(kb);
        //            listem.Add(kb);
        //        }
        //    }


        //    //SqlTransaction tran = new SqlTransaction();
        //    if (conn.State == ConnectionState.Open)
        //    {
        //        conn.Close();
        //    }

        //    foreach (var item in listem)
        //    {
        //        lstKargolar.Items.Add(item);

        //    }
        //    //execute
        //    /*
        //     Connected Mimari

        //    select => tablo  executereader 
        //    insert update delete => executenonquery
        //    select => tek değer => executescaler 
        //     */

        //}
        private void FrmVarlıkGuncelle_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KargoDAL dal = new KargoDAL();
            //MyResult donendeger = dal.Update(new KargoBilgisi()
            //{
            //    KargoID = tiklanilanKargoBilgisi,
            //    KargoAdi = txtKargoAdi.Text,
            //    Tel = txtTel.Text
            //});
            //MessageBox.Show(donendeger.ResultMessage);
            //if (donendeger.ResultType)
            //{
            //    Yukle();
            //    Temizle();
            //}

        }
        int tiklanilanKargoBilgisi = 0;
        private void lstGuncelleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KargoBilgisi degistirilmekIstenenKargo = lstKargolar.SelectedItem as KargoBilgisi;
            ////button1.Tag = degistirilmekIstenenKargo.KargoID;
            //tiklanilanKargoBilgisi = degistirilmekIstenenKargo.KargoID;
            //txtKargoAdi.Text = degistirilmekIstenenKargo.KargoAdi;
            //txtTel.Text = degistirilmekIstenenKargo.Tel;

        }
    }



}
