using DatingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Data
{
    public class ApplicationDataContext : DbContext
    {
        //Contructor
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {

        }
        // Add the models created here.
        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
