﻿// <auto-generated />
using System;
using DotNetProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetProject.Migrations
{
    [DbContext(typeof(BooksContext))]
    partial class BooksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("DotNetProject.Models.Author", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("DotNetProject.Models.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("authorId");

                    b.Property<string>("description");

                    b.Property<string>("imageUrl");

                    b.Property<string>("name");

                    b.Property<int>("posterId");

                    b.HasKey("id");

                    b.HasIndex("authorId");

                    b.HasIndex("posterId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DotNetProject.Models.BookGenreR", b =>
                {
                    b.Property<int>("bookId");

                    b.Property<int>("genreId");

                    b.HasKey("bookId", "genreId");

                    b.HasIndex("genreId");

                    b.ToTable("BookGenreR");
                });

            modelBuilder.Entity("DotNetProject.Models.BookReadingCardR", b =>
                {
                    b.Property<int>("bookId");

                    b.Property<int>("readingCardId");

                    b.HasKey("bookId", "readingCardId");

                    b.HasIndex("readingCardId");

                    b.ToTable("BookReadingCard");
                });

            modelBuilder.Entity("DotNetProject.Models.Genre", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Bookid");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.HasIndex("Bookid");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DotNetProject.Models.Poster", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Poster");
                });

            modelBuilder.Entity("DotNetProject.Models.ReadingCard", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("ReadingCard");
                });

            modelBuilder.Entity("DotNetProject.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<int>("readingCardId");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DotNetProject.Models.Book", b =>
                {
                    b.HasOne("DotNetProject.Models.Author", "author")
                        .WithMany("books")
                        .HasForeignKey("authorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetProject.Models.Poster", "poster")
                        .WithMany("books")
                        .HasForeignKey("posterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetProject.Models.BookGenreR", b =>
                {
                    b.HasOne("DotNetProject.Models.Book", "book")
                        .WithMany("bookGenreR")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetProject.Models.Genre", "genre")
                        .WithMany()
                        .HasForeignKey("genreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetProject.Models.BookReadingCardR", b =>
                {
                    b.HasOne("DotNetProject.Models.Book", "book")
                        .WithMany("bookReadingCardR")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetProject.Models.ReadingCard", "readingCard")
                        .WithMany("bookReadingCardRs")
                        .HasForeignKey("readingCardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetProject.Models.Genre", b =>
                {
                    b.HasOne("DotNetProject.Models.Book")
                        .WithMany("genres")
                        .HasForeignKey("Bookid");
                });

            modelBuilder.Entity("DotNetProject.Models.ReadingCard", b =>
                {
                    b.HasOne("DotNetProject.Models.User", "user")
                        .WithOne("readingCard")
                        .HasForeignKey("DotNetProject.Models.ReadingCard", "userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
