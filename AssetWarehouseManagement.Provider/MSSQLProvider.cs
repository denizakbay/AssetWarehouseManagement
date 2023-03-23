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
        /// <summary>
        /// SqlConnection nesnesi ve SqlCommand nesnesi tanımlanır ve bağlantı dizesi ve sorgu tanımlarıyla oluşturulur.
        /// </summary>
        SqlConnection conn = null;
        SqlCommand cmd = null;

        /// <summary>
        /// MSSQLProvider sınıfının yapıcısı, bir SQL sorgusu ve bir bağlantı dizesi alır. Bağlantı dizesi, veritabanı sunucusu adını, veritabanı adını, kullanıcı adını ve şifreyi içerir.
        /// </summary>
        /// <param name="YapilamakIstenenQuery"></param>
        /// <param name="Adres"></param>
        public MSSQLProvider(string YapilamakIstenenQuery, string Adres = "server=LAPTOP-2NTQ16BC;Database=Root;uid=sa;pwd=1234")
        {
            conn = new SqlConnection(Adres);
            cmd = new SqlCommand();
            cmd.CommandText = YapilamakIstenenQuery;

            cmd.Connection = conn;
        }

        /// <summary>
        /// Close() metodunda, bağlantıyı kapatmak için kullanılır.
        /// </summary>
        void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
        /// <summary>
        /// Open() metodunda, bağlantıyı açmak için kullanılır.
        /// </summary>
        void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }

        /// <summary>
        /// ExcutNon() metodunda, SqlCommand nesnesinin ExecuteNonQuery() yöntemi kullanılarak sorgu çalıştırılır ve etkilenen satır sayısı geri döndürülür.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// ExecutScalar() metodunda, SqlCommand nesnesinin ExecuteScalar() yöntemi kullanılarak sorgu çalıştırılır ve tek bir değer döndürülür.
        /// </summary>
        /// <returns></returns>
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
        /// ExcuteredaerOlustur() metodunda, SqlCommand nesnesinin ExecuteReader() yöntemi kullanılarak sorgu çalıştırılır ve SqlDataReader nesnesi geri döndürülür.
        /// </summary>
        /// <returns></returns>
        public SqlDataReader ExcuteredaerOlustur()
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

            }

            return rdr;

        }

        /// <summary>
        /// SqlParameter nesnesi, SQL sorgusunda kullanılacak parametre değerlerini depolar.
        /// </summary>
        /// <param name="sqlParameters"></param>
        public void ParametreEkle(SqlParameter[] sqlParameters)
        {

            cmd.Parameters.AddRange(sqlParameters);

        }

        /// <summary>
        /// ExecuteNonQuery() metodunda, NotImplementedException hatası oluşturulur. Bu, bu yöntemin henüz uygulanmadığını belirtir.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}
