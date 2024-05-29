﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221207061027_tet")]
    partial class tet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Đồ ăn vặt"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Nước giải khát"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Đồ uống có cồn"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Nhu yếu phẩm"
                        });
                });

            modelBuilder.Entity("_1.DAL.Entities.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("Point")
                        .HasColumnType("int");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Customer", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "n/a",
                            Name = "Khách vãng lai",
                            Phone = "0",
                            Point = 0,
                            Sex = true
                        },
                        new
                        {
                            ID = 2,
                            Address = " 10 Minh Khai, Hà Nội",
                            Name = "Nguyễn Công Tiến",
                            Phone = "0987654321",
                            Point = 10000,
                            Sex = true
                        },
                        new
                        {
                            ID = 3,
                            Address = " 69 Trịnh Văn Bô, Hà Nội",
                            Name = "Nguyễn Mạnh Thắng",
                            Phone = "0987777777",
                            Point = 10000,
                            Sex = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDRoles")
                        .HasColumnType("int");

                    b.Property<string>("LinkAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("IDRoles");

                    b.ToTable("Employees", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "174 Phương Canh",
                            Dob = new DateTime(2022, 12, 7, 13, 10, 27, 354, DateTimeKind.Local).AddTicks(5639),
                            Email = "manhman2806@gmail.com",
                            FullName = "Bùi Thế Mạnh",
                            IDRoles = 1,
                            MaNV = "NV1",
                            Password = "123",
                            Phone = "0379200866",
                            Sex = false,
                            Status = true
                        },
                        new
                        {
                            ID = 2,
                            Address = "173 Phương Canh",
                            Dob = new DateTime(2022, 12, 7, 13, 10, 27, 354, DateTimeKind.Local).AddTicks(5640),
                            Email = "khoanhph18902@gmail.com",
                            FullName = "Nguyễn Hữu Khoa",
                            IDRoles = 2,
                            MaNV = "NV2",
                            Password = "123",
                            Phone = "0972439693",
                            Sex = true,
                            Status = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Entities.ImportHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateCreate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ProductID");

                    b.ToTable("ImportHistories", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("dateCreate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerID = 1,
                            EmployeeID = 1,
                            Status = true,
                            TotalPrice = 60000m,
                            dateCreate = new DateTime(2022, 12, 7, 13, 10, 27, 354, DateTimeKind.Local).AddTicks(5612)
                        },
                        new
                        {
                            Id = 2,
                            CustomerID = 2,
                            EmployeeID = 2,
                            Status = true,
                            TotalPrice = 210000m,
                            dateCreate = new DateTime(2022, 12, 7, 13, 10, 27, 354, DateTimeKind.Local).AddTicks(5613)
                        });
                });

            modelBuilder.Entity("_1.DAL.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OderID")
                        .HasColumnType("int");

                    b.Property<int>("ProducID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OderID", "ProducID");

                    b.HasIndex("ProducID");

                    b.ToTable("OderDetails", (string)null);

                    b.HasData(
                        new
                        {
                            OderID = 1,
                            ProducID = 1,
                            Price = 6000m,
                            Quantity = 6
                        },
                        new
                        {
                            OderID = 1,
                            ProducID = 2,
                            Price = 12000m,
                            Quantity = 2
                        },
                        new
                        {
                            OderID = 2,
                            ProducID = 4,
                            Price = 150000m,
                            Quantity = 1
                        },
                        new
                        {
                            OderID = 2,
                            ProducID = 3,
                            Price = 60000m,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Entities.Producer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.ToTable("Producer", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Oishi"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Coca Cola"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Vodka"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Clear"
                        });
                });

            modelBuilder.Entity("_1.DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaSp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProducerID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ProducerID");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryID = 1,
                            DateCreated = new DateTime(2022, 12, 7, 13, 10, 27, 354, DateTimeKind.Local).AddTicks(5583),
                            LinkImage = "",
                            MaSp = "01",
                            Name = "Bim bim Tôm Cay",
                            Note = "",
                            OriginalPrice = 5000m,
                            Price = 6000m,
                            ProducerID = 1,
                            Status = true,
                            Stock = 10
                        },
                        new
                        {
                            Id = 2,
                            CategoryID = 2,
                            DateCreated = new DateTime(2022, 12, 7, 13, 10, 27, 354, DateTimeKind.Local).AddTicks(5594),
                            LinkImage = "",
                            MaSp = "02",
                            Name = "Coca Cola",
                            Note = "",
                            OriginalPrice = 10000m,
                            Price = 12000m,
                            ProducerID = 2,
                            Status = true,
                            Stock = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryID = 3,
                            DateCreated = new DateTime(2022, 12, 7, 13, 10, 27, 354, DateTimeKind.Local).AddTicks(5596),
                            LinkImage = "",
                            MaSp = "03",
                            Name = "Absolut Vodka",
                            Note = "",
                            OriginalPrice = 10000m,
                            Price = 60000m,
                            ProducerID = 3,
                            Status = true,
                            Stock = 50
                        },
                        new
                        {
                            Id = 4,
                            CategoryID = 4,
                            DateCreated = new DateTime(2022, 12, 7, 13, 10, 27, 354, DateTimeKind.Local).AddTicks(5597),
                            LinkImage = "",
                            MaSp = "04",
                            Name = "Dầu gội Clear Men",
                            Note = "",
                            OriginalPrice = 100000m,
                            Price = 150000m,
                            ProducerID = 4,
                            Status = true,
                            Stock = 5
                        });
                });

            modelBuilder.Entity("_1.DAL.Entities.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            RoleName = "Quản lý"
                        },
                        new
                        {
                            ID = 2,
                            RoleName = "Nhân viên"
                        });
                });

            modelBuilder.Entity("_1.DAL.Entities.Employee", b =>
                {
                    b.HasOne("_1.DAL.Entities.Role", "Roles")
                        .WithMany("Employees")
                        .HasForeignKey("IDRoles")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("_1.DAL.Entities.ImportHistory", b =>
                {
                    b.HasOne("_1.DAL.Entities.Employee", "Employee")
                        .WithMany("ImportHistories")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.Product", "Product")
                        .WithMany("ImportHistories")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("_1.DAL.Entities.Order", b =>
                {
                    b.HasOne("_1.DAL.Entities.Customer", "Customer")
                        .WithMany("Oders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.Employee", "Employee")
                        .WithMany("Oders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("_1.DAL.Entities.OrderDetail", b =>
                {
                    b.HasOne("_1.DAL.Entities.Order", "Oder")
                        .WithMany("OderDetails")
                        .HasForeignKey("OderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.Product", "Product")
                        .WithMany("OderDetails")
                        .HasForeignKey("ProducID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("_1.DAL.Entities.Product", b =>
                {
                    b.HasOne("_1.DAL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.Producer", "Producer")
                        .WithMany("Product")
                        .HasForeignKey("ProducerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("_1.DAL.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("_1.DAL.Entities.Customer", b =>
                {
                    b.Navigation("Oders");
                });

            modelBuilder.Entity("_1.DAL.Entities.Employee", b =>
                {
                    b.Navigation("ImportHistories");

                    b.Navigation("Oders");
                });

            modelBuilder.Entity("_1.DAL.Entities.Order", b =>
                {
                    b.Navigation("OderDetails");
                });

            modelBuilder.Entity("_1.DAL.Entities.Producer", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("_1.DAL.Entities.Product", b =>
                {
                    b.Navigation("ImportHistories");

                    b.Navigation("OderDetails");
                });

            modelBuilder.Entity("_1.DAL.Entities.Role", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
