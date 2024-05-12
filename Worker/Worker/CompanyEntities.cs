using System;
using System.Data.Entity;
using System.Linq;
using Worker.Model;

namespace Workers
{
    public class CompanyEntities : DbContext
    { 
        public CompanyEntities(): base("name=CompanyEntities")
        {
        } 
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Person> Persons { get; set; }

    }
}