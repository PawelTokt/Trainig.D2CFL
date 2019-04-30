﻿// <auto-generated />
using System;
using D2CFL.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace D2CFL.Database.Migrations.FantasyLeague
{
    [DbContext(typeof(FantasyLeagueContext))]
    [Migration("20190430125705_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.MatchEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("TournamentId");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Match","fantasyleague");
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.OrganizationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Organization","fantasyleague");
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.ParticipantEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<Guid>("MatchId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("OrganizationId");

                    b.Property<int>("Score");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Participant","fantasyleague");
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.PlayerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<int>("Age");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("OrganizationId");

                    b.Property<Guid?>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("PositionId");

                    b.ToTable("Player","fantasyleague");
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.PlayerStatisticsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<double>("AverageAssists")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0.0);

                    b.Property<double>("AverageDeaths")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0.0);

                    b.Property<double>("AverageKills")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0.0);

                    b.Property<double>("AveragePoints")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0.0);

                    b.Property<int>("MatchesPlayed")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("TotalAssists")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("TotalDeaths")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("TotalKills")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("TotalPoints")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("PlayerStatistics","fantasyleague");
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.PositionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<int>("AssistCoefficient");

                    b.Property<int>("DeathCoefficient");

                    b.Property<int>("KillCoefficient");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Position","fantasyleague");
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.TournamentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Tournament","fantasyleague");
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.MatchEntity", b =>
                {
                    b.HasOne("D2CFL.Data.FantasyLeague.Contract.TournamentEntity", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.ParticipantEntity", b =>
                {
                    b.HasOne("D2CFL.Data.FantasyLeague.Contract.MatchEntity", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("D2CFL.Data.FantasyLeague.Contract.OrganizationEntity", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.PlayerEntity", b =>
                {
                    b.HasOne("D2CFL.Data.FantasyLeague.Contract.OrganizationEntity", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("D2CFL.Data.FantasyLeague.Contract.PositionEntity", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("D2CFL.Data.FantasyLeague.Contract.PlayerStatisticsEntity", b =>
                {
                    b.HasOne("D2CFL.Data.FantasyLeague.Contract.PlayerEntity", "Player")
                        .WithOne("PlayerStatistics")
                        .HasForeignKey("D2CFL.Data.FantasyLeague.Contract.PlayerStatisticsEntity", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}