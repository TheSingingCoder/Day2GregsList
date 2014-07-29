using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2GregsList.Models
{
    public class FurnitureSubcat : Subcategory
    {   //These inherit from Subcategory
        public string Title;
        public string Details;
        public string Photos;

        //These are new
        public string Price;
        public string Quality;
    }
}