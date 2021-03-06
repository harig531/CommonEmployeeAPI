// <auto-generated />
using System;
using CommonEmployeeAPI.CommonEmployeeApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommonEmployeeAPI.Migrations
{
    [DbContext(typeof(CommonEmployeeDbContext))]
    [Migration("20210609044905_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommonEmployeeAPI.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("Datetime");

                    b.Property<string>("EmailId")
                        .HasColumnType("varchar(75)");

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Gender")
                        .HasColumnType("char(1)");

                    b.Property<string>("Location")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Remarks")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
