﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect.Entities;

namespace Proiect.Migrations
{
    [DbContext(typeof(ProiectContext))]
    [Migration("20220124091435_Ticket2")]
    partial class Ticket2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect.Entities.Plane", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("Proiect.Entities.Ticket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DateOfPurchase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaneId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlaneId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Proiect.Entities.Ticket", b =>
                {
                    b.HasOne("Proiect.Entities.Plane", "Plane")
                        .WithMany("Tickets")
                        .HasForeignKey("PlaneId");

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("Proiect.Entities.Plane", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
