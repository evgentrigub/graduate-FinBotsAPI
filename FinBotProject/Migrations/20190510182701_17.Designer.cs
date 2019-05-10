﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Helpers;

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190510182701_17")]
    partial class _17
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Entities.Answers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerRate");

                    b.Property<string>("Content");

                    b.Property<Guid?>("QuestionsId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionsId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("WebApi.Entities.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("FinancialInstrument");

                    b.Property<int>("Industry");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("WebApi.Entities.BotsAssets", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AssetId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<Guid?>("TradingBotId");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("TradingBotId");

                    b.ToTable("BotsAssets");
                });

            modelBuilder.Entity("WebApi.Entities.Questions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("ObjContent");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("WebApi.Entities.Strategy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Photo");

                    b.Property<string>("StrategyOSEngine");

                    b.HasKey("Id");

                    b.ToTable("Strategy");
                });

            modelBuilder.Entity("WebApi.Entities.TradingBot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<double>("ESValue");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<double>("Profit");

                    b.Property<Guid?>("StrategyId");

                    b.Property<int>("Sum");

                    b.Property<int>("TimeFrame");

                    b.Property<string>("Type");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StrategyId");

                    b.HasIndex("UserId");

                    b.ToTable("TradingBots");
                });

            modelBuilder.Entity("WebApi.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Account");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<int>("RiskType");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApi.Entities.Answers", b =>
                {
                    b.HasOne("WebApi.Entities.Questions")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionsId");
                });

            modelBuilder.Entity("WebApi.Entities.BotsAssets", b =>
                {
                    b.HasOne("WebApi.Entities.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.HasOne("WebApi.Entities.TradingBot", "TradingBot")
                        .WithMany()
                        .HasForeignKey("TradingBotId");
                });

            modelBuilder.Entity("WebApi.Entities.TradingBot", b =>
                {
                    b.HasOne("WebApi.Entities.Strategy", "Strategy")
                        .WithMany()
                        .HasForeignKey("StrategyId");

                    b.HasOne("WebApi.Entities.User", "User")
                        .WithMany("TradingBots")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
