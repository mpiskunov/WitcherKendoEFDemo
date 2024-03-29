﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WitcherKendoEFDemo.Models;

namespace WitcherKendoEFDemo.Migrations
{
    [DbContext(typeof(WitcherKendoEFDemoContext))]
    [Migration("20190822123114_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WitcherKendoEFDemo.Models.Character", b =>
                {
                    b.Property<int>("CharacterID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttackPower");

                    b.Property<int>("DefensePower");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int>("WeaponID");

                    b.HasKey("CharacterID");

                    b.HasIndex("WeaponID");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("WitcherKendoEFDemo.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttackPower");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("WeaponID");

                    b.ToTable("Weapon");
                });

            modelBuilder.Entity("WitcherKendoEFDemo.Models.Character", b =>
                {
                    b.HasOne("WitcherKendoEFDemo.Models.Weapon", "Weapon")
                        .WithMany("Characters")
                        .HasForeignKey("WeaponID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
