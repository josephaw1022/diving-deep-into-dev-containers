﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using auth_db;

#nullable disable

namespace auth_db.Migrations
{
    [DbContext(typeof(AuthDatabaseContext))]
    [Migration("20231104182523_add-new-authuser-property2")]
    partial class addnewauthuserproperty2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("auth_db.AuthUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AuthUser");
                });

            modelBuilder.Entity("auth_db.Session", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("userId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("AuthSession");
                });

            modelBuilder.Entity("auth_db.Session", b =>
                {
                    b.HasOne("auth_db.AuthUser", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("auth_db.AuthUser", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
