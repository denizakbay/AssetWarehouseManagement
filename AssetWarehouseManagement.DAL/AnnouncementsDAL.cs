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
    public class AnnouncementsDAL : MyBaseRepo<AnnouncementsDTO>
    {
        public List<AnnouncementsDTO> Get()
        {
            MSSQLProvider pro = new MSSQLProvider("select * from Announcements");

            SqlDataReader reader = pro.ExcuteredaerOlustur();
            List<AnnouncementsDTO> announcementsList= new List<AnnouncementsDTO>();

            while (reader.Read())
            {
                AnnouncementsDTO announcementsDTO = new AnnouncementsDTO();
                announcementsDTO.Date =(DateTime) reader["Date"];
                announcementsDTO.Title=(string)reader["Title"];
                announcementsDTO.Description = (string)reader["Description"];
                announcementsList.Add(announcementsDTO);
              
            }
            return announcementsList;
        }
    }
}
