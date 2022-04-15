using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace task__2.Models
{
    public partial class Productdet
    {
        public int Pcode { get; set; }
        public string Pname { get; set; }
        public decimal? Unitprice { get; set; }
        public string Pdesc { get; set; }
        public string Category { get; set; }
        public int? Stockinhand { get; set; }
    }
}
