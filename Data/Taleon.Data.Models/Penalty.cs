namespace Taleon.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Taleon.Data.Common.Models;

    public class Penalty : BaseDeletableModel<int>
    {
        [Required]
        public string PenaltyChargeNumber { get; set; }

        [Required]
        public string VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public bool IsPaid { get; set; }

        public decimal AmountToPay { get; set; }

        public DateTime DateOfNotice { get; set; }

        public DateTime DateToPayHalf
         => this.DateOfNotice.AddDays(14);

        public DateTime LastDateToPay => this.DateOfNotice.AddDays(28);
    }
}
