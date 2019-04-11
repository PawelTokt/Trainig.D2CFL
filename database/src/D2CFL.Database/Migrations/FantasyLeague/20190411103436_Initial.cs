﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace D2CFL.Database.Migrations.FantasyLeague
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "fantasyLeague");

            migrationBuilder.CreateTable(
                name: "Organization",
                schema: "fantasyLeague",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "newsequentialid()"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                schema: "fantasyLeague",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "newsequentialid()"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    KillCoefficient = table.Column<int>(nullable: false),
                    AssistCoefficient = table.Column<int>(nullable: false),
                    DeathCoefficient = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                schema: "fantasyLeague",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "newsequentialid()"),
                    OrganizationId = table.Column<Guid>(nullable: true),
                    PositionId = table.Column<Guid>(nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "fantasyLeague",
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Player_Position_PositionId",
                        column: x => x.PositionId,
                        principalSchema: "fantasyLeague",
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_OrganizationId",
                schema: "fantasyLeague",
                table: "Player",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_PositionId",
                schema: "fantasyLeague",
                table: "Player",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player",
                schema: "fantasyLeague");

            migrationBuilder.DropTable(
                name: "Organization",
                schema: "fantasyLeague");

            migrationBuilder.DropTable(
                name: "Position",
                schema: "fantasyLeague");
        }
    }
}