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
    [DbContext(typeof(LapbaseContext))]
    [Migration("20190601122919_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
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

                    b.Property<Guid?>("FoodIntakeListId");

                    b.Property<string>("Name");

                    b.Property<int>("PatientId");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("FoodIntakeListId");

                    b.HasIndex("PatientId");

                    b.ToTable("Food");
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

                    b.Property<string>("Quantity");

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

            modelBuilder.Entity("Lapbase.Models.Food", b =>
                {
                    b.HasOne("Lapbase.Models.FoodIntakeList")
                        .WithMany("Food")
                        .HasForeignKey("FoodIntakeListId")
                        .OnDelete(DeleteBehavior.Restrict);

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