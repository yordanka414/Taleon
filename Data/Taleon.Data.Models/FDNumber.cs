namespace Taleon.Data.Models
{
    using System.Collections.Generic;

    using Taleon.Data.Common.Models;

    public class FDNumber : BaseDeletableModel<string>
    {
        public string Name { get; set; }

        public bool IsInUse { get; set; }

        public ICollection<Driver> Drivers { get; set; } = new HashSet<Driver>();

        public ICollection<TimeTable> Dates { get; set; } = new HashSet<TimeTable>();
    }
}
