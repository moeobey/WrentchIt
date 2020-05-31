﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrenchIt.Models
{
    public class ServiceRequestViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }

        public double Quote { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreaedAt { get; set; }

    }
}
