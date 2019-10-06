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
    [Migration("20191005123220_fixedExercises")]
    partial class fixedExercises
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

                    b.Property<int>("CalorieCount");

                    b.Property<string>("Name");

                    b.Property<string>("pictureUrl");

                    b.HasKey("Id");

                    b.ToTable("Exercise");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eb8e7cfd-d87c-4005-9c52-176a48f972c6"),
                            CalorieCount = 54,
                            Name = "PUSHUPS"
                        });
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
                            Id = new Guid("ff722beb-6767-4e0c-806c-b258acc2b62d"),
                            CalorieCount = 295,
                            Name = "Burger",
                            Unit = "piece"
                        },
                        new
                        {
                            Id = new Guid("0154f740-8147-4163-b527-89c3e7e30c1a"),
                            CalorieCount = 40,
                            Name = "Onion",
                            Unit = "piece"
                        },
                        new
                        {
                            Id = new Guid("734a258f-37d4-426c-bcba-5e24df30f574"),
                            CalorieCount = 90,
                            Name = "Uncle Keith's Kappuccino",
                            Unit = "cup"
                        },
                        new
                        {
                            Id = new Guid("e4787d32-33be-4b7d-8dad-72475d6bc8d6"),
                            CalorieCount = 96,
                            Name = "White bread",
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("4a016a6d-cffa-4c3b-aa84-d2ea24eb0203"),
                            CalorieCount = 44,
                            Name = "Apple",
                            Unit = "apple"
                        },
                        new
                        {
                            Id = new Guid("215d4d02-f92c-4caa-94c5-19306a6e0ea9"),
                            CalorieCount = 107,
                            Name = "Banana",
                            Unit = "banana"
                        },
                        new
                        {
                            Id = new Guid("8eba859f-2daf-4648-b9b6-4d97106bf20c"),
                            CalorieCount = 30,
                            Name = "Tomato",
                            Unit = "tomato"
                        },
                        new
                        {
                            Id = new Guid("72a333c4-33d4-4bf4-b90b-a3c5aa32c04b"),
                            CalorieCount = 50,
                            Name = "Roti",
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("3b795e8f-66ac-44e0-8f3d-e43078c782f8"),
                            CalorieCount = 40,
                            Name = "Rice",
                            Unit = "cup"
                        },
                        new
                        {
                            Id = new Guid("de8b7c9c-c5cf-4461-9c44-6d8550f14048"),
                            CalorieCount = 600,
                            Name = "Halal Pork",
                            Unit = "piece"
                        },
                        new
                        {
                            Id = new Guid("07f40eea-3aa3-44e4-ac7f-c185288eaca0"),
                            CalorieCount = 300,
                            Name = "Habib-Style Shwarma",
                            Unit = "shwarma"
                        },
                        new
                        {
                            Id = new Guid("0724bf6b-9041-4b94-a463-9aae413ffcb4"),
                            CalorieCount = 300,
                            Name = "Meat Platter",
                            Unit = "platter"
                        },
                        new
                        {
                            Id = new Guid("14392f57-02b8-4026-87fa-199cbad05089"),
                            CalorieCount = 350,
                            Name = "Mooncake",
                            Unit = "mooncake"
                        },
                        new
                        {
                            Id = new Guid("0d6302f6-44f9-4da1-a87c-7b35bbdee5f4"),
                            CalorieCount = 400,
                            Name = "HSP",
                            Unit = "box"
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

            modelBuilder.Entity("Lapbase.Models.TaskInput", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Calories");

                    b.Property<bool>("Completed");

                    b.Property<DateTimeOffset>("DateAssigned");

                    b.Property<string>("ExerciseReps");

                    b.Property<string>("Exercises");

                    b.Property<string>("FoodQuantities");

                    b.Property<string>("Foods");

                    b.Property<string>("MealTimes");

                    b.Property<int>("OrganizationCode");

                    b.Property<int>("PatientId");

                    b.Property<decimal>("Weight");

                    b.HasKey("Id");

                    b.ToTable("TaskInput");
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
#pragma warning restore 612, 618
        }
    }
}
