using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string Title { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comment> Comments { get; set;}
    }
}