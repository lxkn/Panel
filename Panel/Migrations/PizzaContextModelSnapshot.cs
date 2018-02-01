﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Panel.Controllers;
using System;

namespace Panel.Migrations
{
    [DbContext(typeof(PizzaContext))]
    partial class PizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Panel.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrderId");

                    b.HasKey("DishId");

                    b.HasIndex("OrderId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Panel.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("Phone");

                    b.Property<string>("Status");

                    b.Property<string>("TimeStart");

                    b.Property<string>("TimeStop");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Panel.Models.Dish", b =>
                {
                    b.HasOne("Panel.Models.Order")
                        .WithMany("orderList")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
