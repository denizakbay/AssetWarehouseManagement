using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetWarehouseManagement.Provider
{

    public class MSSQLProvider
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;

        public MSSQLProvider(string YapilamakIstenenQuery, string Adres = "server=LAPTOP-2NTQ16BC;Database=Root;uid=sa;pwd=1234")
        {
            conn = new SqlConnection(Adres);
            cmd = new SqlCommand();
            cmd.CommandText = YapilamakIstenenQuery;

            cmd.Connection = conn;
        }

        void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
        void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }


        public int ExcutNon()
        {
            int result = 0;

            try
            {

                Open();
                result = cmd.ExecuteNonQuery();
                

            }
            catch (Exception)
            {

                result = 0;
            }
            finally
            {
                Close();
            }

            return result;



        }

        public object ExecutScalar()
        {
            object result = null;

            try
            {
                Open();
                result = cmd.ExecuteScalar();
            }
            catch (Exception)
            {


            }
            finally
            {
                Close();
            }

            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlDataReader ExcuteredaerOlustur()//yukardakiyle aynı yukarda sadece try cach var
        {
            SqlDataReader rdr = null;
            try
            {
                Open();
                rdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {


            }
            finally
            {
                //   Close();
            }

            return rdr;

        }

        public void ParametreEkle(SqlParameter[] sqlParameters)
        {
            //cmd.Parameters.AddWithValue("GirilenKargo", Kargo);
            cmd.Parameters.AddRange(sqlParameters);

        }


    }
}
