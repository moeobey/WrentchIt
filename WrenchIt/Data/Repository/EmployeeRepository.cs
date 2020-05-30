using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrenchIt.Contracts;
using WrenchIt.Data.RepositoryBase;
using WrenchIt.Models;

namespace WrenchIt.Data.Repository
{
    public class EmployeeRepository: RepositoryBase<Employee>,  IEmployeeRepository
    {

        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
