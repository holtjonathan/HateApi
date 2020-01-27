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
        DbSet<ScenarioSpecialAssignment> ScenarioSpecialAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScenarioRewardAssignment>().HasKey(sra => new { sra.RewardId, sra.ScenarioId });
            modelBuilder.Entity<ScenarioSpecialAssignment>().HasKey(sra => new { sra.SpecialId, sra.ScenarioId });

            modelBuilder.Entity<Scenario>().HasData(
                new Scenario() { ScenarioId = 1, Name = "Pillage the Village", Description = "Go pillage a bunch of stuff!!" },
                new Scenario() { ScenarioId = 2, Name = "Some other scenario name", Description = "Some other scenario description!!" }
                );

            modelBuilder.Entity<Reward>().HasData(
                new Reward() { RewardId = 1, Name = "Pillaged", Description = "Do PILLAGE action on 5 huts", HateReward = 0, ResourceReward = 3, RewardType = "Attacker" },
                new Reward() { RewardId = 2, Name = "Hold the line", Description = "Allow less than 5 PILLAGE actions", HateReward = 0, ResourceReward = 4, RewardType = "Defender" },
                new Reward() { RewardId = 3, Name = "Something else", Description = "Do something else unrelated to the others", HateReward = 4, ResourceReward = 0, RewardType = "Both", UnitUpgrade = "SomeCoolActionName" }
                );

            modelBuilder.Entity<Special>().HasData(
                new Special() { SpecialId = 1, Name = "Special Chair", Description = "Make sure to be sitting down while playing." },
                new Special() { SpecialId = 2, Name = "Special Action", Description = "Play with your eyes closed." }
                );

            modelBuilder.Entity<ScenarioRewardAssignment>().HasData(
                new ScenarioRewardAssignment() { ScenarioRewardAssignmentId = 1, RewardId = 1, ScenarioId = 1 },
                new ScenarioRewardAssignment() { ScenarioRewardAssignmentId = 2, RewardId = 2, ScenarioId = 1 },
                new ScenarioRewardAssignment() { ScenarioRewardAssignmentId = 3, RewardId = 3, ScenarioId = 1 }
                );

            modelBuilder.Entity<ScenarioSpecialAssignment>().HasData(
                new ScenarioSpecialAssignment() { ScenarioSpecialAssignmentId = 1, SpecialId = 1, ScenarioId = 1 },
                new ScenarioSpecialAssignment() { ScenarioSpecialAssignmentId = 2, SpecialId = 2, ScenarioId = 1 }
                );

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
