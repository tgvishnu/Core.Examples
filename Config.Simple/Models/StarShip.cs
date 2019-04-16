﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.Simple.Models
{
    public class Starship
    {
        public string Name { get; set; }
        public string Registry { get; set; }
        public string Class { get; set; }
        public decimal Length { get; set; }
        public bool Commissioned { get; set; }
    }
}
