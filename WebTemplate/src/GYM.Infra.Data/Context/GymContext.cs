using GYM.Domain.Entities;
using GYM.Infra.Data.EntityConfig;
using System;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GYM.Infra.Data.Context
{
  public class GymContext : DbContext
  {
    public GymContext() : base("gymConnection")
    {
    }

    public DbSet<Hero> heroes { get; set; }
    public DbSet<Item> itens { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
      modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

      modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
      modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
      modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

      modelBuilder.Configurations.Add(new HeroConfig());
      modelBuilder.Configurations.Add(new ItemConfig());

      base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
      foreach (var entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("createdOn") != null))
      {
        if (entry.State == EntityState.Added)
        {
          entry.Property("createdOn").CurrentValue = DateTime.Now;
        }
        if (entry.State == EntityState.Modified)
        {
          entry.Property("createdOn").IsModified = false;
        }
      }

      return base.SaveChanges();
    }

  }
}
