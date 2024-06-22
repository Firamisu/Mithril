﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mithril.Data;

#nullable disable

namespace Mithril.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240620203624_ExcerciseSchema")]
    partial class ExcerciseSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Mithril.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("EffortPointsPerMinute")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("Mithril.Models.ExerciseLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExerciseLogSetId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("ExerciseLogSetId");

                    b.ToTable("ExerciseLogs");
                });

            modelBuilder.Entity("Mithril.Models.ExerciseLogSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExerciseLogSets");
                });

            modelBuilder.Entity("Mithril.Models.ExerciseLog", b =>
                {
                    b.HasOne("Mithril.Models.Exercise", "Exercise")
                        .WithMany("ExerciseLogs")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mithril.Models.ExerciseLogSet", "ExerciseLogSet")
                        .WithMany("ExerciseLogs")
                        .HasForeignKey("ExerciseLogSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("ExerciseLogSet");
                });

            modelBuilder.Entity("Mithril.Models.Exercise", b =>
                {
                    b.Navigation("ExerciseLogs");
                });

            modelBuilder.Entity("Mithril.Models.ExerciseLogSet", b =>
                {
                    b.Navigation("ExerciseLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
