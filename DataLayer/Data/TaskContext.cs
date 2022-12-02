using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;

namespace DataLayer
{
    public  class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base (options)
        {

        }

        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<RoleMenu> RoleMenu { get; set; }
        public virtual DbSet<Entities.Task> Task { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserAuthentication> UserAuthentications { get; set; }

    }
}
