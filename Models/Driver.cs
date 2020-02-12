using System;
using System.Collections.Generic;

namespace AceSoftServices_Api.Models
{
    public partial class Driver
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string NiNum { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string LicenseNum { get; set; }
        public DateTime LastContact { get; set; }
        public int? EmployeeId { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public DateTime? LicenseChecked { get; set; }
        public DateTime? LicenseNextCheck { get; set; }
        public DateTime? DoB { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public bool? CarOwned { get; set; }
        public DateTime? CpcExpiry { get; set; }
        public DateTime? LicenseValid { get; set; }
        public DateTime? LicenseExpiry { get; set; }
        public DateTime? DigiExpiry { get; set; }
        public bool? Active { get; set; }
        public bool Archived { get; set; }
        public bool Class1 { get; set; }
        public bool Class2 { get; set; }
        public bool NightOut { get; set; }
        public bool Tramping { get; set; }
        public bool Morning { get; set; }
        public bool Night { get; set; }
        public bool Multidrop { get; set; }
        public bool Trunking { get; set; }
        public bool? Prospect { get; set; }
        public string Notes { get; set; }
        public int? LoginId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
