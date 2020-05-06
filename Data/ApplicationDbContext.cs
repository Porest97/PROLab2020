using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROLab.Models.DataModels;
using PROLab.NBS.Models.DataModels;

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
        public DbSet<PROLab.NBS.Models.DataModels.Company> Company { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.CompanyRole> CompanyRole { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.CompanyStatus> CompanyStatus { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.CompanyType> CompanyType { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.Incident> Incident { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.IncidentPriority> IncidentPriority { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.IncidentStatus> IncidentStatus { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.IncidentType> IncidentType { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.Site> Site { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.SiteRole> SiteRole { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.SiteStatus> SiteStatus { get; set; }
        public DbSet<PROLab.NBS.Models.DataModels.SiteType> SiteType { get; set; }
    }
}
