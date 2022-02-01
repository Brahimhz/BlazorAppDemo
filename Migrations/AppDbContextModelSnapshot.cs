﻿// <auto-generated />
using BlazorAppDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorAppDemo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("BlazorAppDemo.Data.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = " this post number 1",
                            Title = "Post1"
                        },
                        new
                        {
                            Id = 2,
                            Content = " this post number 2",
                            Title = "Post2"
                        },
                        new
                        {
                            Id = 3,
                            Content = " this post number 3",
                            Title = "Post3"
                        },
                        new
                        {
                            Id = 4,
                            Content = " this post number 4",
                            Title = "Post4"
                        },
                        new
                        {
                            Id = 5,
                            Content = " this post number 5",
                            Title = "Post5"
                        },
                        new
                        {
                            Id = 6,
                            Content = " this post number 6",
                            Title = "Post6"
                        },
                        new
                        {
                            Id = 7,
                            Content = " this post number 7",
                            Title = "Post7"
                        },
                        new
                        {
                            Id = 8,
                            Content = " this post number 8",
                            Title = "Post8"
                        },
                        new
                        {
                            Id = 9,
                            Content = " this post number 9",
                            Title = "Post9"
                        },
                        new
                        {
                            Id = 10,
                            Content = " this post number 10",
                            Title = "Post10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
