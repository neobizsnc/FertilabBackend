﻿// <auto-generated />
using FertilabApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FertilabApi.Migrations
{
    [DbContext(typeof(FertilabContext))]
    [Migration("20180809092223_distane")]
    partial class distane
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FertilabApi.Models.Center", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<double>("Distance");

                    b.Property<double>("Lat");

                    b.Property<double>("Lng");

                    b.Property<string>("Mail");

                    b.Property<string>("OpenRef");

                    b.Property<string>("OpenTime");

                    b.Property<string>("Phone");

                    b.Property<string>("Structure");

                    b.HasKey("Id");

                    b.ToTable("Center");
                });
#pragma warning restore 612, 618
        }
    }
}
