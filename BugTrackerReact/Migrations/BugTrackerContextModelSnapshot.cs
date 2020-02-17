﻿// <auto-generated />
using System;
using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace bugTracker.Migrations
{
    [DbContext(typeof(BugTrackerContext))]
    partial class BugTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BugTracker.Models.Issue", b =>
                {
                    b.Property<int>("IssueId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("RightSteps");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("WrongSteps");

                    b.HasKey("IssueId");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("BugTracker.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BugTracker.Models.TagIssue", b =>
                {
                    b.Property<int>("TagIssueId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IssueId");

                    b.Property<int>("TagId");

                    b.HasKey("TagIssueId");

                    b.HasIndex("IssueId");

                    b.HasIndex("TagId");

                    b.ToTable("TagIssue");
                });

            modelBuilder.Entity("BugTracker.Models.TagIssue", b =>
                {
                    b.HasOne("BugTracker.Models.Issue", "Issue")
                        .WithMany("Tags")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BugTracker.Models.Tag", "Tag")
                        .WithMany("Issues")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
