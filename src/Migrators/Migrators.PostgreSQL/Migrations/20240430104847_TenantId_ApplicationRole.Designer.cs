﻿// <auto-generated />
using System;
using CleanArchitecture.Blazor.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CleanArchitecture.Blazor.Migrators.PostgreSQL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240430104847_TenantId_ApplicationRole")]
    partial class TenantId_ApplicationRole
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.AuditTrail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AffectedColumns")
                        .HasColumnType("text")
                        .HasColumnName("affected_columns");

                    b.Property<string>("AuditType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("audit_type");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_time");

                    b.Property<string>("NewValues")
                        .HasColumnType("text")
                        .HasColumnName("new_values");

                    b.Property<string>("OldValues")
                        .HasColumnType("text")
                        .HasColumnName("old_values");

                    b.Property<string>("PrimaryKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("primary_key");

                    b.Property<string>("TableName")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("table_name");

                    b.Property<string>("UserId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_audit_trails");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_audit_trails_user_id");

                    b.ToTable("audit_trails", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("created_by");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_customers");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)")
                        .HasColumnName("content");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("created_by");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("document_type");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("boolean")
                        .HasColumnName("is_public");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("last_modified_by");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("TenantId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("tenant_id");

                    b.Property<string>("Title")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("title");

                    b.Property<string>("URL")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("url");

                    b.HasKey("Id")
                        .HasName("pk_documents");

                    b.HasIndex("CreatedBy")
                        .HasDatabaseName("ix_documents_created_by");

                    b.HasIndex("LastModifiedBy")
                        .HasDatabaseName("ix_documents_last_modified_by");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("ix_documents_tenant_id");

                    b.ToTable("documents", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.KeyValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("created_by");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Text")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("text");

                    b.Property<string>("Value")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_key_values");

                    b.ToTable("key_values", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.Logger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientAgent")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("client_agent");

                    b.Property<string>("ClientIP")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("client_ip");

                    b.Property<string>("Exception")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)")
                        .HasColumnName("exception");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("level");

                    b.Property<string>("LogEvent")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("log_event");

                    b.Property<string>("Message")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)")
                        .HasColumnName("message");

                    b.Property<string>("MessageTemplate")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("message_template");

                    b.Property<string>("Properties")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("properties");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("time_stamp");

                    b.Property<string>("UserName")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_loggers");

                    b.HasIndex("Exception")
                        .HasDatabaseName("ix_loggers_exception");

                    b.HasIndex("Level")
                        .HasDatabaseName("ix_loggers_level");

                    b.HasIndex("Message")
                        .HasDatabaseName("ix_loggers_message");

                    b.HasIndex("TimeStamp")
                        .HasDatabaseName("ix_loggers_time_stamp");

                    b.ToTable("loggers", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("brand");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("created_by");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("name");

                    b.Property<string>("Pictures")
                        .HasColumnType("text")
                        .HasColumnName("pictures");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<string>("Unit")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("unit");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.Tenant", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_tenants");

                    b.ToTable("tenants", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_name");

                    b.Property<string>("TenantId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("tenant_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_roles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("ix_asp_net_roles_tenant_id");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("claim_value");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<string>("Group")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("group");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_role_claims");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_asp_net_role_claims_role_id");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("display_name");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("email_confirmed");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<bool>("IsLive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_live");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("ProfilePictureDataUrl")
                        .HasMaxLength(450)
                        .HasColumnType("text")
                        .HasColumnName("profile_picture_data_url");

                    b.Property<string>("Provider")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("provider");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("refresh_token");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("refresh_token_expiry_time");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("security_stamp");

                    b.Property<string>("SuperiorId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("superior_id");

                    b.Property<string>("TenantId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("tenant_id");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_users");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("SuperiorId")
                        .HasDatabaseName("ix_asp_net_users_superior_id");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("ix_asp_net_users_tenant_id");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("claim_value");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_user_claims");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_asp_net_user_claims_user_id");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("provider_key");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("provider_display_name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_asp_net_user_logins");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_asp_net_user_logins_user_id");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.Property<string>("RoleId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_asp_net_user_roles");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_asp_net_user_roles_role_id");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_asp_net_user_tokens");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FriendlyName")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("friendly_name");

                    b.Property<string>("Xml")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)")
                        .HasColumnName("xml");

                    b.HasKey("Id")
                        .HasName("pk_data_protection_keys");

                    b.ToTable("data_protection_keys", (string)null);
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.AuditTrail", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_audit_trails_asp_net_users_user_id");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Entities.Document", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_documents_users_created_by");

                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", "Editor")
                        .WithMany()
                        .HasForeignKey("LastModifiedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_documents_users_last_modified_by");

                    b.HasOne("CleanArchitecture.Blazor.Domain.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .HasConstraintName("fk_documents_tenants_tenant_id");

                    b.Navigation("Editor");

                    b.Navigation("Owner");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationRole", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .HasConstraintName("fk_asp_net_roles_tenants_tenant_id");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationRoleClaim", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_role_claims_asp_net_roles_role_id");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", "Superior")
                        .WithMany()
                        .HasForeignKey("SuperiorId")
                        .HasConstraintName("fk_asp_net_users_asp_net_users_superior_id");

                    b.HasOne("CleanArchitecture.Blazor.Domain.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .HasConstraintName("fk_asp_net_users_tenants_tenant_id");

                    b.Navigation("Superior");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUserClaim", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_claims_asp_net_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUserLogin", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_logins_asp_net_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUserRole", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_roles_role_id");

                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_users_user_id");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUserToken", b =>
                {
                    b.HasOne("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_tokens_asp_net_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationRole", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CleanArchitecture.Blazor.Domain.Identity.ApplicationUser", b =>
                {
                    b.Navigation("Logins");

                    b.Navigation("Tokens");

                    b.Navigation("UserClaims");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}