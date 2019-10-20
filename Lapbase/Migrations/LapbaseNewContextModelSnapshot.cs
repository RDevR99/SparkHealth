﻿// <auto-generated />
using System;
using Lapbase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lapbase.Migrations
{
    [DbContext(typeof(LapbaseNewContext))]
    partial class LapbaseNewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("bc32599d-f600-4c4e-a3b7-54fc260dd3be"),
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
                            Id = new Guid("3f35f3e6-2678-4813-bdb3-2c34549722ac"),
                            CalorieCount = 295,
                            Name = "Burger",
                            Unit = "piece"
                        },
                        new
                        {
                            Id = new Guid("487b5772-5707-4cb6-9212-0bf1a4bff41e"),
                            CalorieCount = 40,
                            Name = "Onion",
                            Unit = "piece"
                        },
                        new
                        {
                            Id = new Guid("342345dc-2ba7-4e4c-974f-754fcf846767"),
                            CalorieCount = 90,
                            Name = "Uncle Keith's Kappuccino",
                            Unit = "cup"
                        },
                        new
                        {
                            Id = new Guid("c23fe00e-599c-4c86-8f06-570e17aa50d2"),
                            CalorieCount = 96,
                            Name = "White bread",
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("c43adabf-9589-4023-bfc4-4ee9e945830b"),
                            CalorieCount = 44,
                            Name = "Apple",
                            Unit = "apple"
                        },
                        new
                        {
                            Id = new Guid("23246296-20e2-4a21-892d-fbe116ae6fb8"),
                            CalorieCount = 107,
                            Name = "Banana",
                            Unit = "banana"
                        },
                        new
                        {
                            Id = new Guid("78c2749d-ae9d-441e-8d57-35b5dc6afaab"),
                            CalorieCount = 30,
                            Name = "Tomato",
                            Unit = "tomato"
                        },
                        new
                        {
                            Id = new Guid("b9ee9330-ef7a-4918-acd2-3e584af09389"),
                            CalorieCount = 50,
                            Name = "Roti",
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("5f838700-3494-4d48-a73e-4105aea6e352"),
                            CalorieCount = 40,
                            Name = "Rice",
                            Unit = "cup"
                        },
                        new
                        {
                            Id = new Guid("7019619f-c149-4eda-a709-ff160d2bc8ad"),
                            CalorieCount = 600,
                            Name = "Halal Pork",
                            Unit = "piece"
                        },
                        new
                        {
                            Id = new Guid("59fc22d2-80cc-42b5-ba86-350f159c42cd"),
                            CalorieCount = 300,
                            Name = "Habib-Style Shwarma",
                            Unit = "shwarma"
                        },
                        new
                        {
                            Id = new Guid("d1c0cacb-19ea-43ee-9b8b-0feece79daa8"),
                            CalorieCount = 300,
                            Name = "Meat Platter",
                            Unit = "platter"
                        },
                        new
                        {
                            Id = new Guid("3ff549a1-25f5-4781-bb60-4ebf225fe31d"),
                            CalorieCount = 350,
                            Name = "Mooncake",
                            Unit = "mooncake"
                        },
                        new
                        {
                            Id = new Guid("8ac9258a-52be-4593-bc12-b8dc11978cfc"),
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

                    b.Property<decimal>("CaloriesGained");

                    b.Property<decimal>("CaloriesLost");

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
