﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScreeDesigner.API.DataAccess.Context;

#nullable disable

namespace ScreeDesigner.API.Migrations
{
    [DbContext(typeof(ScreenDesignerContext))]
    partial class ScreenDesignerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ScreeDesigner.API.Models.DesignElement", b =>
                {
                    b.Property<Guid>("DesignElementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesignElementId");

                    b.ToTable("DesignElement");
                });

            modelBuilder.Entity("ScreeDesigner.API.Models.Property", b =>
                {
                    b.Property<Guid>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DesignElementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertyId");

                    b.HasIndex("DesignElementId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("ScreeDesigner.API.Models.Property", b =>
                {
                    b.HasOne("ScreeDesigner.API.Models.DesignElement", null)
                        .WithMany("Properties")
                        .HasForeignKey("DesignElementId");
                });

            modelBuilder.Entity("ScreeDesigner.API.Models.DesignElement", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
