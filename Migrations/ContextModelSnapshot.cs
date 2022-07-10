﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WordFun.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Story", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adjective")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun5")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun6")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun7")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun8")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verb")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Story");
                });

            modelBuilder.Entity("StoryB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adjective1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adjective2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adjective3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interjection")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun5")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun6")
                        .HasColumnType("TEXT");

                    b.Property<string>("Noun7")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verb1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verb2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verb3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verb4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verb5")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verb6")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("StoryB");
                });
#pragma warning restore 612, 618
        }
    }
}
