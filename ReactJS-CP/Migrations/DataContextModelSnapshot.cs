﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactJS_CP.Models;

#nullable disable

namespace ReactJS_CP.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ReactJS_CP.Models.Accountant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accountant");
                });

            modelBuilder.Entity("ReactJS_CP.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Principal")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.Property<int>("UIC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ReactJS_CP.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InvoiceId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("IssuerIdId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaterialsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaterialsPrices")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaterialsQuantity")
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ReceiverIdId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("WhenCreated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountantId");

                    b.HasIndex("IssuerIdId");

                    b.HasIndex("ReceiverIdId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("ReactJS_CP.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DefaultPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaterialCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("ReactJS_CP.Models.Invoice", b =>
                {
                    b.HasOne("ReactJS_CP.Models.Accountant", "Accountant")
                        .WithMany()
                        .HasForeignKey("AccountantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReactJS_CP.Models.Company", "IssuerId")
                        .WithMany()
                        .HasForeignKey("IssuerIdId");

                    b.HasOne("ReactJS_CP.Models.Company", "ReceiverId")
                        .WithMany()
                        .HasForeignKey("ReceiverIdId");

                    b.Navigation("Accountant");

                    b.Navigation("IssuerId");

                    b.Navigation("ReceiverId");
                });
#pragma warning restore 612, 618
        }
    }
}