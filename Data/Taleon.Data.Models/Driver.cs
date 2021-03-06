namespace Taleon.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Taleon.Data.Common.Models;

    public class Driver : BaseDeletableModel<string>
    {
        public string DrivingLicence { get; set; }

        public string ApplicationUserId { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; } = new HashSet<Vehicle>();

        public ICollection<Penalty> Penalties { get; set; } = new HashSet<Penalty>();

        public ICollection<FDNumber> FDNumbers { get; set; } = new HashSet<FDNumber>();

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
