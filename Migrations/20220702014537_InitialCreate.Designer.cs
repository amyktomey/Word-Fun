// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WordFun.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220702014537_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
