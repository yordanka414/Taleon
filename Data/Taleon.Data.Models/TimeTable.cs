namespace Taleon.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Taleon.Data.Common.Models;

    public class TimeTable : BaseModel<int>
    {
        public DateTime Date { get; set; }

        [Required]
        [StringLength(2)]
        public string DayOfMonth { get; set; }

        [Required]
        [StringLength(15)]
        public string Month { get; set; }

        [Required]
        [StringLength(4)]
        public string Year { get; set; }

        [Required]
        [StringLength(15)]
        public string DayOfWeek { get; set; }

        public ICollection<FDNumber> FDNumbers { get; set; } = new HashSet<FDNumber>();
    }
}
