﻿// <auto-generated />
using System;
using KeepRunning.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KeepRunning.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("KeepRunning.Models.Entities.Runner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Runners");
                });

            modelBuilder.Entity("KeepRunning.Models.Entities.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateActual")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePlanned")
                        .HasColumnType("datetime2");

                    b.Property<string>("DayOfWeekPlanned")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalTimeMinutes")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingPlanId")
                        .HasColumnType("int");

                    b.Property<string>("TrainingType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("KeepRunning.Models.Entities.TrainingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FinishedAtActual")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FinishedAtPlanned")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RunnerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StaretedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RunnerId");

                    b.ToTable("TrainingPlans");
                });

            modelBuilder.Entity("KeepRunning.Models.Entities.Training", b =>
                {
                    b.HasOne("KeepRunning.Models.Entities.TrainingPlan", "TrainingPlan")
                        .WithMany("Trainings")
                        .HasForeignKey("TrainingPlanId");

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("KeepRunning.Models.Entities.TrainingPlan", b =>
                {
                    b.HasOne("KeepRunning.Models.Entities.Runner", "Runner")
                        .WithMany("TrainingPlans")
                        .HasForeignKey("RunnerId");

                    b.Navigation("Runner");
                });

            modelBuilder.Entity("KeepRunning.Models.Entities.Runner", b =>
                {
                    b.Navigation("TrainingPlans");
                });

            modelBuilder.Entity("KeepRunning.Models.Entities.TrainingPlan", b =>
                {
                    b.Navigation("Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}
