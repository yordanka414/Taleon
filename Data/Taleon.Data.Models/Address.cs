namespace Taleon.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Taleon.Data.Common.Models;

    public class Address : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(70)]
        public string FirstLine { get; set; }

        [MaxLength(70)]
        public string SecondLine { get; set; }

        [MaxLength(70)]
        public string ThirdLine { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostCode { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; } = new HashSet<ApplicationUser>();
    }
}
