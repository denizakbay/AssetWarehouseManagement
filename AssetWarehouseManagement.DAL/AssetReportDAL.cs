using AssetWarehouseManagement.DAL.Repos;
using AssetWarehouseManagement.DTO;
using AssetWarehouseManagement.Provider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetWarehouseManagement.DAL
{
    public class AssetReportDAL : MyBaseRepo<AssetReportDAL>
    {
        public List<AssetReportDTO> Get(int UserID)
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
            List<AssetReportDTO> assetReportDTOs = new List<AssetReportDTO>(); //
            while (reader.Read())
            {
                AssetReportDTO assetReportDTO = new AssetReportDTO(); //

                assetReportDTO.RegistrationNumber = (string)reader["RegistrationNumber"];
                assetReportDTO.Barcode = (string)reader["Barcode"];
                assetReportDTO.ProductType = (string)reader["ProductType"];
                assetReportDTO.CurrentValue = (decimal)reader["CurrentValue"];
                assetReportDTO.Brand = (string)reader["Brand"];
                assetReportDTO.Model = (string)reader["Model"];

                assetReportDTOs.Add(assetReportDTO); //


            }

            return assetReportDTOs; //
        }
    }
}
