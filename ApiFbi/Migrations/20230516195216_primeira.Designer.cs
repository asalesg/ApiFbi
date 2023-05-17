﻿// <auto-generated />
using ApiFbi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiFbi.Migrations
{
    [DbContext(typeof(ApiFbiContext))]
    [Migration("20230516195216_primeira")]
    partial class primeira
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiFbi.Models.Fbi", b =>
                {
                    b.Property<string>("TitleId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nationality")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Sex")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Url")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("TitleId");

                    b.ToTable("Fbi");
                });
#pragma warning restore 612, 618
        }
    }
}