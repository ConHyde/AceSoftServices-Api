using System;
using System.Collections.Generic;

namespace AceSoftServices_Api.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string Sector { get; set; }
        public decimal Mobile { get; set; }
        public decimal Telephone { get; set; }
        public bool Prospect { get; set; }
        public int? LoginId { get; set; }
    }
}
