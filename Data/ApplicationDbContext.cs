using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROLab.Models.DataModels;

namespace PROLab.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PROLab.Models.DataModels.Person> Person { get; set; }
        public DbSet<PROLab.Models.DataModels.Account> Account { get; set; }
        public DbSet<PROLab.Models.DataModels.Transaction> Transaction { get; set; }
        public DbSet<PROLab.Models.DataModels.Accounting> Accounting { get; set; }
        public DbSet<PROLab.Models.DataModels.PhysicalSampling> PhysicalSampling { get; set; }
    }
}
