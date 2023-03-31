﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using appserverproject.Data;

#nullable disable

namespace appserverproject.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("appserverproject.Data.Promo", b =>
                {
                    b.Property<int>("PromoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Channel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PromoCurrency")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PromoEnd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PromoStart")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PromoTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PromoType")
                        .HasColumnType("INTEGER");

                    b.HasKey("PromoId");

                    b.ToTable("Promos");

                    b.HasData(
                        new
                        {
                            PromoId = 1,
                            Channel = "",
                            Model = "",
                            PromoCurrency = 1,
                            PromoEnd = "30.09.2022",
                            PromoStart = "28.09.2022",
                            PromoTitle = "Post 1",
                            PromoType = 1
                        },
                        new
                        {
                            PromoId = 2,
                            Channel = "",
                            Model = "",
                            PromoCurrency = 1,
                            PromoEnd = "30.09.2022",
                            PromoStart = "28.09.2022",
                            PromoTitle = "Post 2",
                            PromoType = 1
                        },
                        new
                        {
                            PromoId = 3,
                            Channel = "",
                            Model = "",
                            PromoCurrency = 1,
                            PromoEnd = "30.09.2022",
                            PromoStart = "28.09.2022",
                            PromoTitle = "Post 3",
                            PromoType = 1
                        },
                        new
                        {
                            PromoId = 4,
                            Channel = "",
                            Model = "",
                            PromoCurrency = 1,
                            PromoEnd = "30.09.2022",
                            PromoStart = "28.09.2022",
                            PromoTitle = "Post 4",
                            PromoType = 1
                        },
                        new
                        {
                            PromoId = 5,
                            Channel = "",
                            Model = "",
                            PromoCurrency = 1,
                            PromoEnd = "30.09.2022",
                            PromoStart = "28.09.2022",
                            PromoTitle = "Post 5",
                            PromoType = 1
                        },
                        new
                        {
                            PromoId = 6,
                            Channel = "",
                            Model = "",
                            PromoCurrency = 1,
                            PromoEnd = "30.09.2022",
                            PromoStart = "28.09.2022",
                            PromoTitle = "Post 6",
                            PromoType = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
