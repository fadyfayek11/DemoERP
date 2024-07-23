﻿// <auto-generated />
using System;
using DemoERP.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoERP.Migrations
{
    [DbContext(typeof(AppDbContext.AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoERP.Domain.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.HasIndex("ParentDepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("DemoERP.Domain.EmailReminder", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailId"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSent")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailId");

                    b.ToTable("EmailReminder");
                });

            modelBuilder.Entity("DemoERP.Domain.Department", b =>
                {
                    b.HasOne("DemoERP.Domain.Department", "ParentDepartment")
                        .WithMany("SubDepartments")
                        .HasForeignKey("ParentDepartmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ParentDepartment");
                });

            modelBuilder.Entity("DemoERP.Domain.Department", b =>
                {
                    b.Navigation("SubDepartments");
                });
#pragma warning restore 612, 618
        }
    }
}
