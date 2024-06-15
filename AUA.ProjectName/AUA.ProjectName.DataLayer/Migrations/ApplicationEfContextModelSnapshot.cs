﻿// <auto-generated />
using System;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AUA.ProjectName.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationEfContext))]
    partial class ApplicationEfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AccountAggregate.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AppUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Account", "acc");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AppUserId = 1L,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AccountRoleAggregate.AccountRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<long>("UserAccountId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserAccountId");

                    b.ToTable("AccountRole", "acc");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccountId = 1L
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.ActiveAccessTokenAggregate.ActiveAccessToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("ActiveAccessToken", "acc");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AppUserAggregate.AppUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("AppUser", "acc");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatorUserId = 1L,
                            FirstName = "Rahim",
                            IsActive = true,
                            LastName = "Lotfi",
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.ClientAggregate.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppType")
                        .HasColumnType("int");

                    b.Property<Guid>("ClientIdentity")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client", "acc");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppType = 1,
                            ClientIdentity = new Guid("9245fe4a-d402-451c-b9ed-9c1a04247482"),
                            CreatorUserId = 1L,
                            Description = "AUA default",
                            IsActive = true,
                            IsDefault = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Default App"
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.RoleAggregate.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Role", "acc");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorUserId = 1L,
                            Description = "AUA default role",
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatorUserId = 1L,
                            Description = "AUA default role",
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "User"
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.RoleUserAccessAggregate.RoleUserAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserAccessId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserAccessId");

                    b.ToTable("RoleUserAccess", "acc");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 4
                        },
                        new
                        {
                            Id = 5,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 5
                        },
                        new
                        {
                            Id = 6,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 6
                        },
                        new
                        {
                            Id = 7,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1,
                            UserAccessId = 7
                        },
                        new
                        {
                            Id = 8,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 2,
                            UserAccessId = 2
                        },
                        new
                        {
                            Id = 9,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 2,
                            UserAccessId = 3
                        },
                        new
                        {
                            Id = 10,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 2,
                            UserAccessId = 4
                        },
                        new
                        {
                            Id = 11,
                            CreatorUserId = 1L,
                            IsActive = true,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 2,
                            UserAccessId = 6
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccessAggregate.UserAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessCode")
                        .HasColumnType("int");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsIndirect")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("UserAccess", "acc");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessCode = 1,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = false,
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "User Management",
                            Url = "../Accounting/AppUser"
                        },
                        new
                        {
                            Id = 2,
                            AccessCode = 3,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = false,
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Access level management",
                            Url = "../Accounting/UserAccess"
                        },
                        new
                        {
                            Id = 3,
                            AccessCode = 2,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = false,
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Role Management",
                            Url = "../Accounting/Role"
                        },
                        new
                        {
                            Id = 4,
                            AccessCode = 4,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = false,
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Report access to users",
                            Url = "../reports/UserAccessReport"
                        },
                        new
                        {
                            Id = 5,
                            AccessCode = 5,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = false,
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Reset Password",
                            Url = ""
                        },
                        new
                        {
                            Id = 6,
                            AccessCode = 6,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = false,
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "User Access Report",
                            Url = ""
                        },
                        new
                        {
                            Id = 7,
                            AccessCode = 7,
                            CreatorUserId = 1L,
                            IsActive = true,
                            IsIndirect = false,
                            ParentId = 0,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Account Management",
                            Url = ""
                        });
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.School.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Student", "School");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.School.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(3)")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Teacher", "School");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AccountAggregate.Account", b =>
                {
                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.AppUserAggregate.AppUser", "AppUser")
                        .WithMany("UserAccounts")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.OwnsOne("AUA.ProjectName.DomainEntities.Entities.Accounting.AccountAggregate.PasswordCredential", "PasswordCredential", b1 =>
                        {
                            b1.Property<long>("AccountId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Password")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.Property<int>("PasswordSecurityRate")
                                .HasColumnType("int");

                            b1.Property<string>("Salt")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.HasKey("AccountId");

                            b1.ToTable("Account", "acc");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");

                            b1.HasData(
                                new
                                {
                                    AccountId = 1L,
                                    Password = "07479BB27E983DD65312BB13F34FE1DDD6E7D597AA7C91C8156B246FA12E0DCF1598CD29D3760225B6C81287F88E1F1F912D1325D4CDE7E77584CEAE6A40E2C8",
                                    PasswordSecurityRate = 1,
                                    Salt = "OJfR9nZCD2W4hUaWJxxqGt4Bo/F4Bpcy7cdXAaTcHsI="
                                });
                        });

                    b.Navigation("AppUser");

                    b.Navigation("PasswordCredential")
                        .IsRequired();
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AccountRoleAggregate.AccountRole", b =>
                {
                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.RoleAggregate.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.AccountAggregate.Account", "UserAccount")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.ActiveAccessTokenAggregate.ActiveAccessToken", b =>
                {
                    b.OwnsOne("AUA.ProjectName.DomainEntities.Entities.Accounting.ActiveAccessTokenAggregate.TokenInfo", "TokenInfo", b1 =>
                        {
                            b1.Property<long>("ActiveAccessTokenId")
                                .HasColumnType("bigint");

                            b1.Property<string>("AccessToken")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("nvarchar(2000)");

                            b1.Property<DateTime>("ExpirationDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("RefreshToken")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)");

                            b1.HasKey("ActiveAccessTokenId");

                            b1.ToTable("ActiveAccessToken", "acc");

                            b1.WithOwner()
                                .HasForeignKey("ActiveAccessTokenId");
                        });

                    b.Navigation("TokenInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AppUserAggregate.AppUser", b =>
                {
                    b.OwnsOne("AUA.ProjectName.DomainEntities.Entities.Accounting.AppUserAggregate.UserContact", "UserContact", b1 =>
                        {
                            b1.Property<long>("AppUserId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("Phone")
                                .IsRequired()
                                .HasMaxLength(25)
                                .HasColumnType("nvarchar(25)");

                            b1.HasKey("AppUserId");

                            b1.ToTable("AppUser", "acc");

                            b1.WithOwner()
                                .HasForeignKey("AppUserId");

                            b1.HasData(
                                new
                                {
                                    AppUserId = 1L,
                                    Email = "Mr_lotfi@ymail.com",
                                    Phone = "+989199906342"
                                });
                        });

                    b.Navigation("UserContact")
                        .IsRequired();
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.ClientAggregate.Client", b =>
                {
                    b.OwnsOne("AUA.ProjectName.DomainEntities.Entities.Accounting.ClientAggregate.TokenExpirationTime", "ClientTokenExpiration", b1 =>
                        {
                            b1.Property<int>("ClientId")
                                .HasColumnType("int");

                            b1.Property<int>("AccessTokenExpirationMinutes")
                                .HasColumnType("int");

                            b1.Property<int>("NotBeforeMinutes")
                                .HasColumnType("int");

                            b1.Property<int>("RefreshTokenExpirationMinutes")
                                .HasColumnType("int");

                            b1.HasKey("ClientId");

                            b1.ToTable("Client", "acc");

                            b1.WithOwner()
                                .HasForeignKey("ClientId");

                            b1.HasData(
                                new
                                {
                                    ClientId = 1,
                                    AccessTokenExpirationMinutes = 60,
                                    NotBeforeMinutes = 0,
                                    RefreshTokenExpirationMinutes = 120
                                });
                        });

                    b.Navigation("ClientTokenExpiration")
                        .IsRequired();
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.RoleUserAccessAggregate.RoleUserAccess", b =>
                {
                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.RoleAggregate.Role", "Role")
                        .WithMany("UserRoleAccess")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccessAggregate.UserAccess", "UserAccess")
                        .WithMany("RoleAccesses")
                        .HasForeignKey("UserAccessId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("UserAccess");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccessAggregate.UserAccess", b =>
                {
                    b.OwnsOne("AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccessAggregate.PageInf", "PageInf", b1 =>
                        {
                            b1.Property<int>("UserAccessId")
                                .HasColumnType("int");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.Property<string>("Title")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.HasKey("UserAccessId");

                            b1.ToTable("UserAccess", "acc");

                            b1.WithOwner()
                                .HasForeignKey("UserAccessId");

                            b1.HasData(
                                new
                                {
                                    UserAccessId = 1,
                                    Description = "User Management",
                                    Title = "User Management"
                                },
                                new
                                {
                                    UserAccessId = 2,
                                    Description = "Access level management",
                                    Title = "Access level management"
                                },
                                new
                                {
                                    UserAccessId = 3,
                                    Description = "Role Management",
                                    Title = "Role Management"
                                },
                                new
                                {
                                    UserAccessId = 4,
                                    Description = "Report access to to users",
                                    Title = "Report access to users"
                                },
                                new
                                {
                                    UserAccessId = 5,
                                    Description = "Reset Password",
                                    Title = "Reset User Password"
                                },
                                new
                                {
                                    UserAccessId = 6,
                                    Description = "Assign access to roles",
                                    Title = "Assign access to roles"
                                },
                                new
                                {
                                    UserAccessId = 7,
                                    Description = "",
                                    Title = "Account "
                                });
                        });

                    b.Navigation("PageInf")
                        .IsRequired();
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AccountAggregate.Account", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.AppUserAggregate.AppUser", b =>
                {
                    b.Navigation("UserAccounts");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.RoleAggregate.Role", b =>
                {
                    b.Navigation("UserRoleAccess");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccessAggregate.UserAccess", b =>
                {
                    b.Navigation("RoleAccesses");
                });
#pragma warning restore 612, 618
        }
    }
}
