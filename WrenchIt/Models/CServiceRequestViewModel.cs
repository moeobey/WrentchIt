using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrenchIt.Models
{
    public class CServiceRequestViewModel
    {
        public IEnumerable<Service>  ServiceList { get; set; }

        public IEnumerable<Car> CarList { get; set; }  

        public Car Car { get; set; }

        public int CarId { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }

    }
}
