using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetWarehouseManagement.DTO
{
    public class AssetUpdateDTO
    {
        public int AssetID { get; set; }
        public string RegistrationNumber { get; set; }
        public string Barcode { get; set; }
        public string CompanyID { get; set; }
        public string Brand { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string CurrencyCode { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal CurrentValue { get; set; }
        public int OwnerID { get; set; }
        public string Model { get; set; }
        public DateTime DateReceived { get; set; }
        public DateTime DateGiven { get; set; }
    }
}
