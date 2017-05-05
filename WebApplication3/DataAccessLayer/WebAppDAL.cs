using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication3.Models;

namespace WebApplication3.DataAccessLayer
{
    public class WebAppDAL : DbContext
    {
        public DbSet<Parameter> Parameters { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parameter>().ToTable("TblParameter");
            base.OnModelCreating(modelBuilder);
        }
    }
}