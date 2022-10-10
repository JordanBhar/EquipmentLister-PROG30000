using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentLister.Models
{
    public static class EquipmentListingsRepository
    {
        private static List<EquipmentListing> _listings = new List<EquipmentListing>();


        public static void AddListing(EquipmentListing listing)
        {
            _listings.Add(listing);
        }


    }
}