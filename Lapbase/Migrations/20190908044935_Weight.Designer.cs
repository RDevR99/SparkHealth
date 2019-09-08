﻿// <auto-generated />
using System;
using Lapbase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lapbase.Migrations
{
    [DbContext(typeof(LapbaseNewContext))]
    [Migration("20190908044935_Weight")]
    partial class Weight
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lapbase.Models.Advisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Advisor");

                    b.HasData(
                        new
                        {
                            Id = 1
                        });
                });

            modelBuilder.Entity("Lapbase.Models.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CaloryCount");

                    b.Property<Guid?>("ExerciseListId");

                    b.Property<string>("Name");

                    b.Property<int>("PatientId");

                    b.Property<string>("pictureUrl");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseListId");

                    b.HasIndex("PatientId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("Lapbase.Models.Feedback", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Date");

                    b.Property<int>("PatientId");

                    b.Property<int>("Type");

                    b.Property<string>("content");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Lapbase.Models.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CalorieCount");

                    b.Property<string>("Name");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.ToTable("Food");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2577969d-93da-4a17-94bf-0b984855f7c9"),
                            CalorieCount = 295,
                            Name = "Burger",
                            Unit = "piece"
                        },
                        new
                        {
                            Id = new Guid("7223eb94-fe59-4f62-b082-b216d5622b0f"),
                            CalorieCount = 40,
                            Name = "Onion",
                            Unit = "piece"
                        },
                        new
                        {
                            Id = new Guid("6b6c9e33-3d86-44a2-b97d-c50c1cefbcab"),
                            CalorieCount = 90,
                            Name = "Uncle Keith's Kappuccino",
                            Unit = "cup"
                        },
                        new
                        {
                            Id = new Guid("09fea5c9-e328-4e6a-85fa-8e2af924699d"),
                            CalorieCount = 96,
                            Name = "White bread",
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("7437ee36-e38f-4526-bf1a-78f2ba19436f"),
                            CalorieCount = 44,
                            Name = "Apple",
                            Unit = "apple"
                        },
                        new
                        {
                            Id = new Guid("ba2a7b79-7fab-4bed-b22f-b2d0e5c47007"),
                            CalorieCount = 107,
                            Name = "Banana",
                            Unit = "banana"
                        },
                        new
                        {
                            Id = new Guid("66ab8883-68ec-434b-af05-66f2c2256245"),
                            CalorieCount = 30,
                            Name = "Tomato",
                            Unit = "tomato"
                        });
                });

            modelBuilder.Entity("Lapbase.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvisorId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Username");

                    b.Property<DateTimeOffset>("ValidFrom");

                    b.Property<DateTimeOffset>("ValidTo");

                    b.Property<DateTimeOffset>("WhenCreated");

                    b.HasKey("Id");

                    b.HasIndex("AdvisorId");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdvisorId = 1,
                            Deleted = false,
                            Username = "test@test.com",
                            ValidFrom = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ValidTo = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            WhenCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Lapbase.Models.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdvisorId");

                    b.Property<int>("PatientId");

                    b.Property<int>("Repetition");

                    b.Property<int>("RepetitionInterval");

                    b.Property<DateTimeOffset>("StartDate");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("AdvisorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Task");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac2fbfe3-5557-4c52-95d6-a9f2655f9a36"),
                            AdvisorId = 1,
                            PatientId = 1,
                            Repetition = 1,
                            RepetitionInterval = 1,
                            StartDate = new DateTimeOffset(new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Type = 0
                        });
                });

            modelBuilder.Entity("Lapbase.Models.TaskInput", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("DateEntered");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<Guid>("TaskId");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskInput");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TaskInput");
                });

            modelBuilder.Entity("Lapbase.Models.ExerciseList", b =>
                {
                    b.HasBaseType("Lapbase.Models.TaskInput");

                    b.Property<string>("Reps");

                    b.HasDiscriminator().HasValue("ExerciseList");
                });

            modelBuilder.Entity("Lapbase.Models.FoodIntakeList", b =>
                {
                    b.HasBaseType("Lapbase.Models.TaskInput");

                    b.Property<decimal>("Calories");

                    b.Property<string>("Food");

                    b.Property<string>("Quantity");

                    b.Property<decimal>("Weight");

                    b.HasDiscriminator().HasValue("FoodIntakeList");
                });

            modelBuilder.Entity("Lapbase.Models.Exercise", b =>
                {
                    b.HasOne("Lapbase.Models.ExerciseList")
                        .WithMany("Exercises")
                        .HasForeignKey("ExerciseListId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Lapbase.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Lapbase.Models.Feedback", b =>
                {
                    b.HasOne("Lapbase.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Lapbase.Models.Patient", b =>
                {
                    b.HasOne("Lapbase.Models.Advisor", "Advisor")
                        .WithMany("Patients")
                        .HasForeignKey("AdvisorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Lapbase.Models.Task", b =>
                {
                    b.HasOne("Lapbase.Models.Advisor", "Advisor")
                        .WithMany()
                        .HasForeignKey("AdvisorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Lapbase.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Lapbase.Models.TaskInput", b =>
                {
                    b.HasOne("Lapbase.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
