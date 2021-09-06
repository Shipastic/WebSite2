﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSite2.Data;

namespace WebSite2.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20210825120338_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebSite2.Data.Models.CatalogGroup", b =>
                {
                    b.Property<int>("CatalogGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatalogGroupId");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("CatalogGroups");
                });

            modelBuilder.Entity("WebSite2.Data.Models.FilterGroup", b =>
                {
                    b.Property<int>("FilterGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FilterGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilterGroupId");

                    b.ToTable("FilterGroups");
                });

            modelBuilder.Entity("WebSite2.Data.Models.FilterName", b =>
                {
                    b.Property<int>("FilterNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatalogGroupId")
                        .HasColumnType("int");

                    b.Property<bool>("DisplayInFilter")
                        .HasColumnType("bit");

                    b.Property<int>("FilterGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ValueFilter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilterNameId");

                    b.HasIndex("CatalogGroupId");

                    b.HasIndex("FilterGroupId");

                    b.HasIndex("ProductId");

                    b.ToTable("FilterNames");
                });

            modelBuilder.Entity("WebSite2.Data.Models.MainCategory", b =>
                {
                    b.Property<int>("MainCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainCategoryId");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("WebSite2.Data.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("orderTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebSite2.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WebSite2.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CatalogGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Supplier")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CatalogGroupId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebSite2.Data.Models.PropertyValue", b =>
                {
                    b.Property<int>("PropertyValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilterNameId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertyValueId");

                    b.HasIndex("FilterNameId");

                    b.ToTable("PropertyValues");
                });

            modelBuilder.Entity("WebSite2.Data.Models.ShopProductItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShopProductId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ShopProductItems");
                });

            modelBuilder.Entity("WebSite2.Data.Models.CatalogGroup", b =>
                {
                    b.HasOne("WebSite2.Data.Models.MainCategory", "MainCategory")
                        .WithMany("CatalogGroups")
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("WebSite2.Data.Models.FilterName", b =>
                {
                    b.HasOne("WebSite2.Data.Models.CatalogGroup", "CatalogGroup")
                        .WithMany("FilterNames")
                        .HasForeignKey("CatalogGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebSite2.Data.Models.FilterGroup", "FilterGroup")
                        .WithMany("FilterNames")
                        .HasForeignKey("FilterGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebSite2.Data.Models.Product", "Product")
                        .WithMany("FilterNames")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CatalogGroup");

                    b.Navigation("FilterGroup");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebSite2.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("WebSite2.Data.Models.Order", "Order")
                        .WithMany("orderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebSite2.Data.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebSite2.Data.Models.Product", b =>
                {
                    b.HasOne("WebSite2.Data.Models.CatalogGroup", "CatalogGroup")
                        .WithMany("Products")
                        .HasForeignKey("CatalogGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogGroup");
                });

            modelBuilder.Entity("WebSite2.Data.Models.PropertyValue", b =>
                {
                    b.HasOne("WebSite2.Data.Models.FilterName", "FilterName")
                        .WithMany("PropertyValues")
                        .HasForeignKey("FilterNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterName");
                });

            modelBuilder.Entity("WebSite2.Data.Models.ShopProductItem", b =>
                {
                    b.HasOne("WebSite2.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebSite2.Data.Models.CatalogGroup", b =>
                {
                    b.Navigation("FilterNames");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebSite2.Data.Models.FilterGroup", b =>
                {
                    b.Navigation("FilterNames");
                });

            modelBuilder.Entity("WebSite2.Data.Models.FilterName", b =>
                {
                    b.Navigation("PropertyValues");
                });

            modelBuilder.Entity("WebSite2.Data.Models.MainCategory", b =>
                {
                    b.Navigation("CatalogGroups");
                });

            modelBuilder.Entity("WebSite2.Data.Models.Order", b =>
                {
                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("WebSite2.Data.Models.Product", b =>
                {
                    b.Navigation("FilterNames");

                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}