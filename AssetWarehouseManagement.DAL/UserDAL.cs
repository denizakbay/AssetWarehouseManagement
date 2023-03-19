using AssetWarehouseManagement.DAL.IRepos;
using AssetWarehouseManagement.DTO;
using AssetWarehouseManagement.Provider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetWarehouseManagement.DAL
{
    public class UserDAL : ISelectRepo<UserDTO>
    {
        public UserDTO Get(string userName, string password)
        {
            MSSQLProvider pro = new MSSQLProvider("select * from Users where UserName=@u and Password=@p");


            List<SqlParameter> parametreListem = new List<SqlParameter>();
            parametreListem.Add(new SqlParameter("@u", userName));
            parametreListem.Add(new SqlParameter("@p", password));
            pro.ParametreEkle(parametreListem.ToArray());

            //Debug.WriteLine(pro.ExcuteredaerOlustur());

            // UserDTO executedResult = (UserDTO)pro.ExecutScalar();

            SqlDataReader reader = pro.ExcuteredaerOlustur();
            UserDTO userDTO = new UserDTO();
            while (reader.Read())
            {

                string name = reader.GetString(1); // Assumes the second column of the result set is a string name
                userDTO.UserName = name;
                Debug.WriteLine(name);

            }

            return userDTO;

        }
    }
}
