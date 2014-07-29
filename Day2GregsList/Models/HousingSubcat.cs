using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2GregsList.Models
{
    public class HousingSubcat : Subcategory
    {   //These inherit from Subcategory
        public string Title;
        public string Details;
        public string Photos;

        //These are new
        public string Address;
        public double Rent;
        public bool petFriendly;
    }
}