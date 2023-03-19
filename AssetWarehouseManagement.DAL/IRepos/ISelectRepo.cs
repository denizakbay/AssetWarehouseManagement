﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetWarehouseManagement.DAL.IRepos
{
    public interface ISelectRepo<T> where T : class
    {
        T Get(string UserName, string password);


    }
}
