namespace Taleon.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Drivers")]
    public class Driver : ApplicationUser
    {
        public string DrivingLicence { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; } = new HashSet<Vehicle>();

        public ICollection<Penalty> Penalties { get; set; } = new HashSet<Penalty>();

        public ICollection<FDNumber> FDNumbers { get; set; } = new HashSet<FDNumber>();
    }
}
