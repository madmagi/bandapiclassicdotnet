using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiclassnet.Models
{
    public class Band
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public ushort Rating { get; set; }
    }
}