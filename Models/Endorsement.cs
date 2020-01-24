using System;
using System.Collections.Generic;

namespace AceSoftServices_Api.Models
{
    public partial class Endorsement
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Insurable { get; set; }
        public decimal YearsOnLicense { get; set; }
    }
}
