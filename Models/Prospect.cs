using System;
using System.Collections.Generic;

namespace AceSoftServices_Api.Models
{
    public partial class Prospect
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public bool Class1 { get; set; }
        public bool Class2 { get; set; }
        public bool NightOut { get; set; }
        public bool Tramping { get; set; }
        public bool Morning { get; set; }
        public bool Night { get; set; }
        public bool Multidrop { get; set; }
        public bool Trunking { get; set; }
        public string Notes { get; set; }
    }
}
