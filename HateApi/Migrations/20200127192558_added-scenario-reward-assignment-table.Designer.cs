﻿// <auto-generated />
using HateApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HateApi.Migrations
{
    [DbContext(typeof(HateContext))]
    [Migration("20200127192558_added-scenario-reward-assignment-table")]
    partial class addedscenariorewardassignmenttable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HateApi.Models.Reward", b =>
                {
                    b.Property<int>("RewardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HateReward")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResourceReward")
                        .HasColumnType("int");

                    b.Property<string>("RewardType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitUpgrade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RewardId");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("HateApi.Models.Scenario", b =>
                {
                    b.Property<int>("ScenarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScenarioId");

                    b.ToTable("Scenarios");
                });

            modelBuilder.Entity("HateApi.Models.ScenarioRewardAssignment", b =>
                {
                    b.Property<int>("RewardId")
                        .HasColumnType("int");

                    b.Property<int>("ScenarioId")
                        .HasColumnType("int");

                    b.Property<int>("ScenarioRewardAssignmentId")
                        .HasColumnType("int");

                    b.HasKey("RewardId", "ScenarioId");

                    b.HasIndex("ScenarioId");

                    b.ToTable("ScenarioRewardAssignments");
                });

            modelBuilder.Entity("HateApi.Models.Special", b =>
                {
                    b.Property<int>("SpecialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecialId");

                    b.ToTable("Specials");
                });

            modelBuilder.Entity("HateApi.Models.ScenarioRewardAssignment", b =>
                {
                    b.HasOne("HateApi.Models.Reward", "Reward")
                        .WithMany("ScenarioRewardAssignments")
                        .HasForeignKey("RewardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HateApi.Models.Scenario", "Scenario")
                        .WithMany("ScenarioRewardAssignments")
                        .HasForeignKey("ScenarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
