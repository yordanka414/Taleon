namespace Taleon.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Taleon.Data.Common.Models;

    public class Accident : BaseDeletableModel<int>
    {
        public DateTime DateOfAccident { get; set; }

        public bool IsInsuranceInvolved { get; set; }

        [Required]
        public string VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
