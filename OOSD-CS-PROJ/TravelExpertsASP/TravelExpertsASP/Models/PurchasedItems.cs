using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsASP.Models
{
    public class PurchasedItems
    {
        private decimal totalCost;
        public string Destination { get; set; }

        public string Description { get; set; }

        public string ProdName { get; set; }

        public DateTime TripStart { get; set; }

        public DateTime TripEnd { get; set; }

        public int TravelerCount { get; set; }

        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        public string TTName { get; set; }

        public string ClassName { get; set; }

        public decimal BasePrice { get; set; }

        public decimal FeeAmt { get; set; }

        public decimal TotalCost
        {
            get
            {
                return totalCost = BasePrice + FeeAmt; 
            }
            set
            {
                totalCost = value;
            }
        }
    }
}