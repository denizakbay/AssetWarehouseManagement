using AssetWarehouseManagement.DAL.IRepos;
using AssetWarehouseManagement.DAL.Repos;
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
    public class AssetDAL : MyBaseRepo<AssetDTO>
    {
        public List<AssetDTO> Get(int UserID)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM Users WHERE UserID = @UserID AND Role = 'SuperAdmin')
                BEGIN
                    SELECT 
                        a.RegistrationNumber, a.Barcode, a.Model, a.Brand, a.ProductType, 
                        a.Description, a.Quantity, a.CurrencyCode, a.PurchaseDate, a.CurrentValue,
                        u.UserName, u.Role
                    FROM 
                        Assets a 
                        JOIN Users u ON a.OwnerID = u.UserID
                END
                ELSE
                BEGIN
                    SELECT 
                        a.RegistrationNumber, a.Barcode, a.Model, a.Brand, a.ProductType, 
                        a.Description, a.Quantity, a.CurrencyCode, a.PurchaseDate, a.CurrentValue,
                        u.UserName, u.Role
                    FROM 
                        Assets a 
                        JOIN Users u ON a.OwnerID = u.UserID
                    WHERE 
                        u.UserID = @UserID
                END";


            MSSQLProvider pro = new MSSQLProvider(query);


            List<SqlParameter> parametreListem = new List<SqlParameter>();
            parametreListem.Add(new SqlParameter("@UserID", UserID));
            pro.ParametreEkle(parametreListem.ToArray());

            SqlDataReader reader = pro.ExcuteredaerOlustur();
            List<AssetDTO>  assetDTOList = new List<AssetDTO>(); //
            while (reader.Read())
            {
                AssetDTO assetDTO = new AssetDTO(); //

                assetDTO.RegistrationNumber = (string)reader["RegistrationNumber"];
                assetDTO.Barcode = (string)reader["Barcode"];
                assetDTO.ProductType = (string)reader["ProductType"];
                assetDTO.CurrentValue = (decimal)reader["CurrentValue"];
                assetDTO.Brand = (string)reader["Brand"];
                assetDTO.Model = (string)reader["Model"];

                assetDTOList.Add(assetDTO); //

                
            }

            return assetDTOList; //
        }
    }
}
