using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Concrete
{
    public class Address
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Address1 { get; set; }
        public string Description { get; set; }

        public string Mail { get; set; }
        public string Phone { get; set; }

        public string Location { get; set; }

    }
}