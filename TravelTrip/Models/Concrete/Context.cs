﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Admin>Admins { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Home> Homes { get; set; }

    }
}