using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2GregsList.Models
{
    public class CategoryVM
    {
        public List<HousingSubcat> HousingCategory = new List<HousingSubcat>();
        public List<FurnitureSubcat> FurnitureCategory = new List<FurnitureSubcat>();
        public List<MissedConnectionsSubcat> MissedConnectionsCategory = new List<MissedConnectionsSubcat>();
    }
}