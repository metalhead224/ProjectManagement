using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;

namespace DataLayer.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext()
        {
            //var objectAdapter = (IObjectContextAdapter)this;
            //var objContext = objectAdapter.ObjectContext;
            //objContext.CommandTimeout = 15 * 60;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object value = optionsBuilder.UseSqlServer(
            @"Server=DESKTOP-HV1SLKB;Database=Task_Management_Live;Trusted_Connection=True; UID = sa; PWD = evergreensuman99");
            //DATA SOURCE = DESKTOP - HV1SLKB; DATABASE = Task_Management_Live; UID = sa; PWD = evergreensuman99
        }


        public virtual DbSet<Roles> Roles { get; set; }
    }
}
