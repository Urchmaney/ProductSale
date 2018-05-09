using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BuySchoolMaterial.Data.Migrations
{
    public partial class AddedDateAnd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OwnerAcceptSale",
                table: "Requests",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDate",
                table: "Requests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "RequesterAcceptSale",
                table: "Requests",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Materials",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SoldDate",
                table: "Materials",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerAcceptSale",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequestDate",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequesterAcceptSale",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "SoldDate",
                table: "Materials");
        }
    }
}
