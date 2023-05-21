﻿// <auto-generated />
using ApiFbi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiFbi.Migrations
{
    [DbContext(typeof(ApiFbiContext))]
    partial class ApiFbiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiFbi.Models.Fbi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nationality")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Sex")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Url")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Fbi");
                });

            modelBuilder.Entity("ApiFbi.Models.Interpol", b =>
                {
                    b.Property<int>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntityId"));

                    b.Property<string>("Forename")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nationalities")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("EntityId");

                    b.ToTable("Interpol");
                });

            modelBuilder.Entity("FbiInterpol", b =>
                {
                    b.Property<int>("fbisId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("interpolsEntityId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("fbisId", "interpolsEntityId");

                    b.HasIndex("interpolsEntityId");

                    b.ToTable("FbiInterpol");
                });

            modelBuilder.Entity("FbiInterpol", b =>
                {
                    b.HasOne("ApiFbi.Models.Fbi", null)
                        .WithMany()
                        .HasForeignKey("fbisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiFbi.Models.Interpol", null)
                        .WithMany()
                        .HasForeignKey("interpolsEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
