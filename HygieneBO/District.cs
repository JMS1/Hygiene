﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HygieneBO
{
    public class District
    {
        public int DistrictId { get; set; }

        public string Name { get; set; }
        public string FileLocation { get; set; }

        public string CheckSum { get; set; }
        public DateTime? CheckSumChanged { get; set; }
        

    }
}
