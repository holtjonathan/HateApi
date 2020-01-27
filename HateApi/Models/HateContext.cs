using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class HateContext : DbContext
    {
        public HateContext(DbContextOptions options) : base(options) { }

        DbSet<Scenario> Scenarios { get; set; }
        DbSet<Special> Specials { get; set; }
        //DbSet<SpecialType> SpecialTypes { get; set; }
        DbSet<Reward> Rewards { get; set; }
        DbSet<ScenarioRewardAssignment> ScenarioRewardAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScenarioRewardAssignment>().HasKey(sra => new { sra.RewardId, sra.ScenarioId });
            //modelBuilder.Entity<Scenario>().HasOne(s => s.AttackerReward).WithOne(m => m.AttackerScenario).HasForeignKey<Scenario>(m => m.AttackerRewardId);
            //modelBuilder.Entity<Scenario>().HasOne(s => s.DefenderReward).WithOne(m => m.DefenderScenario).HasForeignKey<Scenario>(m => m.DefenderRewardId);




            //modelBuilder.Entity<Special>()
            //    .HasOne(a => a.SpecialType)
            //    .WithOne(b => b.Special)
            //    .HasForeignKey<SpecialType>(b => b.SpecialTypeId);

            //modelBuilder.Entity<Reward>().HasData(
            //    new Reward() { RewardId = 1, Description = "You get blah!" },
            //    new Reward() { RewardId = 2, Description = "You get some other blah!" });

            //modelBuilder.Entity<Scenario>().HasData(
            //    new Scenario() { ScenarioId = 1, Name = "TestScenario1", Description = "Blah blah blah", Prereq = "Must have X, Y, and Z"},
            //    new Scenario() { ScenarioId = 2, Name = "TestScenario2", Description = "asdfasfdsf", Prereq = "adsfasfd" },
            //    new Scenario() { ScenarioId = 3, Name = "We are trapped!", Description = "We have to fight our way throught the mountain", Prereq = null });

            //modelBuilder.Entity<SpecialType>().HasData(
            //    new SpecialType() { SpecialTypeId = 1, Name = "Special Actions" },
            //    new SpecialType() { SpecialTypeId = 2, Name = "Special Rules" });

            //modelBuilder.Entity<Special>().HasData(
            //    new Special() { SpecialId = 1, Name = "Special1", ScenarioId = 1, SpecialTypeId = 1 },
            //    new Special() { SpecialId = 2, Name = "Special2", ScenarioId = 1, SpecialTypeId = 2 });
        }
    }
}
