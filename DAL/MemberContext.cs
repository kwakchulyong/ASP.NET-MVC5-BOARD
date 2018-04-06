using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackTest.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BackTest.DAL
{
    public class MemberContext : DbContext
    {

        public MemberContext() : base("MemberContext")
        {
        }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}