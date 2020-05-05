using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROLab.Migrations
{
    public partial class MediStatsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhysicalSampling",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeSampleTaken = table.Column<DateTime>(nullable: false),
                    BloodPressure = table.Column<string>(nullable: true),
                    Oxygenation = table.Column<string>(nullable: true),
                    BodyTemperature = table.Column<decimal>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalSampling", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhysicalSampling");
        }
    }
}
