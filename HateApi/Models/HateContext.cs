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
        }
    }
}
