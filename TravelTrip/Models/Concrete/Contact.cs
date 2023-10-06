﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public string Mail { get; set; }

        public string Subject { get; set; }
    }
}