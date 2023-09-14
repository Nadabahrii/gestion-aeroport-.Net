using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightid",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planes",
                table: "Planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropIndex(
                name: "IX_FlightPassenger_PassengersId",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "Planes",
                newName: "MyPlane");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "Reservation");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Passengers",
                newName: "PassLastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Passengers",
                newName: "PassFirstName");

            migrationBuilder.RenameColumn(
                name: "Flightid",
                table: "Flights",
                newName: "FlightId");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "MyPlane",
                newName: "PlaneCapacity");

            migrationBuilder.RenameColumn(
                name: "ManufactureDate",
                table: "MyPlane",
                newName: "ManifacturalDate");

            migrationBuilder.RenameColumn(
                name: "FlightsFlightid",
                table: "Reservation",
                newName: "flightsFlightId");

            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "Passengers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "Passengers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Healthinformation",
                table: "Passengers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Function",
                table: "Passengers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Passengers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "Passengers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "PassLastName",
                table: "Passengers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PassFirstName",
                table: "Passengers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Passengers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IsTraveller",
                table: "Passengers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Flights",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "Flights",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Airline",
                table: "Flights",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlane",
                table: "MyPlane",
                column: "PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                columns: new[] { "PassengersId", "flightsFlightId" });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    numTicket = table.Column<int>(type: "int", nullable: false),
                    passengerfk = table.Column<int>(type: "int", nullable: false),
                    flightfk = table.Column<int>(type: "int", nullable: false),
                    dateachat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prixTicket = table.Column<float>(type: "real", nullable: false),
                    siege = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    vip = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.passengerfk, x.flightfk, x.numTicket });
                    table.ForeignKey(
                        name: "FK_Tickets_Flights_flightfk",
                        column: x => x.flightfk,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_passengerfk",
                        column: x => x.passengerfk,
                        principalTable: "Passengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_flightsFlightId",
                table: "Reservation",
                column: "flightsFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_flightfk",
                table: "Tickets",
                column: "flightfk");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlane_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Flights_flightsFlightId",
                table: "Reservation",
                column: "flightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Passengers_PassengersId",
                table: "Reservation",
                column: "PassengersId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlane_PlaneId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Flights_flightsFlightId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Passengers_PassengersId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_flightsFlightId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlane",
                table: "MyPlane");

            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "IsTraveller",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "MyPlane",
                newName: "Planes");

            migrationBuilder.RenameColumn(
                name: "PassLastName",
                table: "Passengers",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "PassFirstName",
                table: "Passengers",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "Flights",
                newName: "Flightid");

            migrationBuilder.RenameColumn(
                name: "flightsFlightId",
                table: "FlightPassenger",
                newName: "FlightsFlightid");

            migrationBuilder.RenameColumn(
                name: "PlaneCapacity",
                table: "Planes",
                newName: "Capacity");

            migrationBuilder.RenameColumn(
                name: "ManifacturalDate",
                table: "Planes",
                newName: "ManufactureDate");

            migrationBuilder.AlterColumn<int>(
                name: "PassportNumber",
                table: "Passengers",
                type: "int",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Healthinformation",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Function",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Passengers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Passengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Airline",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightid", "PassengersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planes",
                table: "Planes",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_PassengersId",
                table: "FlightPassenger",
                column: "PassengersId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightid",
                table: "FlightPassenger",
                column: "FlightsFlightid",
                principalTable: "Flights",
                principalColumn: "Flightid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersId",
                table: "FlightPassenger",
                column: "PassengersId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
