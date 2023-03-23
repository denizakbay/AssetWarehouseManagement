using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetWarehouseManagement.DAL.IRepos
{
    public interface IUpdateRepo<T> where T : class
    {

        void Update(int id, T entity);



    }
}

