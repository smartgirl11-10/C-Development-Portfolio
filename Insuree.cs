using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }

        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }

        public bool CoverageType { get; set; }

        public decimal Quote { get; set; }
    }
}
