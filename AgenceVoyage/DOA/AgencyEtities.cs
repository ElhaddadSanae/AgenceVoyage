using AgenceVoyage.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceVoyage
{
    internal class AgencyEtities:DbContext

    {
    public DbSet<Personnel> personnels { get; set; }
    public DbSet<Admin> admins { get; set; }
    public DbSet<Guide> guides { get; set; }
    public DbSet<Client> clients { get; set; }
    public DbSet<Reservation> reservations { get; set; }
    public DbSet<Voyage> voyages { get; set; }
    public AgencyEtities() : base("AgencyMapping") { }
    
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Admin>().ToTable("Admin");
        modelBuilder.Entity<Guide>().ToTable("Guide");
    }

    }
}
