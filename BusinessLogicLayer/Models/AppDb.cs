using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options) { }

        public DbSet<Orders> Orders { get; set; }       
        public DbSet<Users> Users { get; set; }       
        public DbSet<Valid> Valid { get; set; }       
        public DbSet<T1> t1tbl { get; set; }       
        public DbSet<T2> t2tbl { get; set; }       
        public DbSet<T3> t3tbl { get; set; }       
        public DbSet<T4> t4tbl { get; set; }       

        public DbSet<DataAnnotationEx> dataAnnotationExes { get; set; } 
        public DbSet<Aadhar> aadhar { get; set; } 
        public DbSet<Pan> pan { get; set; }
        public DbSet<Aadhar1> aadhar1 { get; set; }
        public DbSet<Pan1> pan1 { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
    }
}
