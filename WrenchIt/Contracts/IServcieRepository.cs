using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WrenchIt.Models;

namespace WrenchIt.Data.RepositoryBase.IRepository
{
    public interface IServiceRepository : IRepoBase<Service>
    {
        IEnumerable<Service> GetAllServices();


        void Update(Service service);
    }
}
