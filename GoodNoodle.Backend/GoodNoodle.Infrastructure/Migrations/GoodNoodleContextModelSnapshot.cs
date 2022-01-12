﻿// <auto-generated />
using System;
using GoodNoodle.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoodNoodle.Infrastructure.Migrations
{
    [DbContext(typeof(GoodNoodleContext))]
    partial class GoodNoodleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GoodNoodle.Domain.Entities.Invitations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NoodleGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NoodleUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("GoodNoodle.Domain.Entities.NoodleGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("NoodleGroup");
                });

            modelBuilder.Entity("GoodNoodle.Domain.Entities.NoodleUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NoodleUser");
                });

            modelBuilder.Entity("GoodNoodle.Domain.Entities.Star", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NoodleGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NoodleUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Star");
                });

            modelBuilder.Entity("GoodNoodle.Domain.Entities.UserInGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NoodleGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NoodleUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NoodleGroupId");

                    b.HasIndex("NoodleUserId");

                    b.ToTable("UserInGroup");
                });

            modelBuilder.Entity("GoodNoodle.Domain.Entities.UserInGroup", b =>
                {
                    b.HasOne("GoodNoodle.Domain.Entities.NoodleGroup", "NoodleGroup")
                        .WithMany("UserInGroups")
                        .HasForeignKey("NoodleGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoodNoodle.Domain.Entities.NoodleUser", "NoodleUser")
                        .WithMany("UserInGroups")
                        .HasForeignKey("NoodleUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NoodleGroup");

                    b.Navigation("NoodleUser");
                });

            modelBuilder.Entity("GoodNoodle.Domain.Entities.NoodleGroup", b =>
                {
                    b.Navigation("UserInGroups");
                });

            modelBuilder.Entity("GoodNoodle.Domain.Entities.NoodleUser", b =>
                {
                    b.Navigation("UserInGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
