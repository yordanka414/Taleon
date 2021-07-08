namespace Taleon.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Taleon.Data.Common.Models;

    public class Vehicle : BaseDeletableModel<string>
    {
        [Required]
        [StringLength(50)]
        public string Make { get; set; }

        [Required]
        [RegularExpression("\b[a-z]{2}([1-9]|0[2-9]|6[0-9]|1[0-9])[a-z]{3}\b/i")]
        public string RegistrationNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public ICollection<Driver> Drivers { get; set; } = new HashSet<Driver>();

        public ICollection<Penalty> Penalties { get; set; } = new HashSet<Penalty>();
    }
}
