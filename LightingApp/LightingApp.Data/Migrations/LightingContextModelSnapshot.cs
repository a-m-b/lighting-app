﻿// <auto-generated />
using LightingApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LightingApp.Data.Migrations
{
    [DbContext(typeof(LightingContext))]
    partial class LightingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("LightingApp.Data.Models.Lighting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AcceptableLighting");

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressNameOrNumber");

                    b.Property<string>("AddressPostcode");

                    b.Property<string>("AddressTown");

                    b.Property<int>("BrightnessLevel");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Lightings");
                });
#pragma warning restore 612, 618
        }
    }
}
