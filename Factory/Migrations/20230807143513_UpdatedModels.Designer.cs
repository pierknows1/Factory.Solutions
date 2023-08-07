﻿// <auto-generated />
using Factory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Factory.Migrations
{
    [DbContext(typeof(FactoryContext))]
    [Migration("20230807143513_UpdatedModels")]
    partial class UpdatedModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Factory.Models.Engineer", b =>
                {
                    b.Property<int>("EngineerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EngineerDetails")
                        .HasColumnType("longtext");

                    b.Property<string>("EngineerName")
                        .HasColumnType("longtext");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.HasKey("EngineerId");

                    b.HasIndex("MachineId")
                        .IsUnique();

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("Factory.Models.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MachineDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("MachineType")
                        .HasColumnType("longtext");

                    b.HasKey("MachineId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Factory.Models.Engineer", b =>
                {
                    b.HasOne("Factory.Models.Machine", "Machine")
                        .WithOne("Engineer")
                        .HasForeignKey("Factory.Models.Engineer", "MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("Factory.Models.Machine", b =>
                {
                    b.Navigation("Engineer");
                });
#pragma warning restore 612, 618
        }
    }
}
