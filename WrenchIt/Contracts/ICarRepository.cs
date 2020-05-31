using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrenchIt.Data.RepositoryBase.IRepository;
using WrenchIt.Models;

namespace WrenchIt.Contracts
{
    public interface ICarRepository:IRepoBase<Car>
    {
        IEnumerable<Car> GetCustomerCars(int id);
        void Update(Car car);

    }
}
