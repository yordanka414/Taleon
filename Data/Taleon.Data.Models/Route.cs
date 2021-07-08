namespace Taleon.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Taleon.Data.Common.Models;

    public class Route : BaseDeletableModel<string>
    {
        [Required]
        [StringLength(5)]
        public string Number { get; set; }

        public int CountParsels => this.Stops.Count;

        public ICollection<Driver> Drivers { get; set; } = new HashSet<Driver>();

        public ICollection<TimeTable> Dates { get; set; } = new HashSet<TimeTable>();

        public ICollection<FDNumber> FDNumbers { get; set; } = new HashSet<FDNumber>();

        public ICollection<Stop> Stops { get; set; } = new HashSet<Stop>();
    }
}
