using AssetWarehouseManagement.DAL.Repos;
using AssetWarehouseManagement.DAL.IRepos;
using AssetWarehouseManagement.DTO;
using AssetWarehouseManagement.Provider;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetWarehouseManagement.DAL
{
    public class SSSDAL : MyBaseRepo<SSSDTO>
    {
        public List<SSSDTO> Get()
        {
            MSSQLProvider pro = new MSSQLProvider("select * from FAQs");

            SqlDataReader reader = pro.ExcuteredaerOlustur();
            List<SSSDTO> sSSDTOsList = new List<SSSDTO>();

            while (reader.Read())
            {
                SSSDTO sSSDTO = new SSSDTO();
                sSSDTO.Question = (string)reader["Question"];
                sSSDTO.Answer = (string)reader["Answer"];
                sSSDTOsList.Add(sSSDTO);
            }
            return sSSDTOsList;
        }

        #region Parametreli
        //public List<SSSDTO>  Get(int id)
        //{

        //    MSSQLProvider pro = new MSSQLProvider("select * from FAQs where FAQID =@id ");


        //    List<SqlParameter> parametreListem = new List<SqlParameter>();
        //    parametreListem.Add(new SqlParameter("@id", id ));

        //    pro.ParametreEkle(parametreListem.ToArray());

        //    SqlDataReader reader = pro.ExcuteredaerOlustur();
        //    List<SSSDTO> sSSDTOsList = new List<SSSDTO>();

        //    while (reader.Read())
        //    {
        //        SSSDTO sSSDTO = new SSSDTO();


        //        sSSDTO.Question = (string)reader["Question"];
        //        sSSDTO.Answer = (string)reader["Answer"];

        //        sSSDTOsList.Add(sSSDTO);


        //    }
        //    //  return sSSDTO;
        //    return sSSDTOsList;


        //} 
        #endregion
    }
}
