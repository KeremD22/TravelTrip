using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Concrete
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Mail { get; set; }

        public string Comment1 { get; set; }

        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
        

    }
     
    }
