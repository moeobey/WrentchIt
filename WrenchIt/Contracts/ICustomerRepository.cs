﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WrenchIt.Data.RepositoryBase;
using WrenchIt.Data.RepositoryBase.IRepository;
using WrenchIt.Models;

namespace WrenchIt.Contracts
{
    public interface ICustomerRepository : IRepoBase<Customer>
    {
        Customer GetByUserId(string id);
    }
}
