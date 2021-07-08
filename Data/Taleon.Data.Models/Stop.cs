namespace Taleon.Data.Models
{
    using System;

    using Taleon.Data.Common.Models;

    public class Stop : BaseDeletableModel<string>
    {
        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public string RouteId { get; set; }

        public Route Route { get; set; }

        public TypeOfParsel TypeOfParsel { get; set; }
    }
}
