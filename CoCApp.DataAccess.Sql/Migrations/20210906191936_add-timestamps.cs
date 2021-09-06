using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoCApp.DataAccess.Sql.Migrations
{
    public partial class addtimestamps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonalInformation_InvestigatorId",
                table: "PersonalInformation");

            migrationBuilder.DropIndex(
                name: "IX_Characteristics_InvestigatorId",
                table: "Characteristics");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Characteristics",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedDate",
                table: "Characteristics",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_InvestigatorId",
                table: "PersonalInformation",
                column: "InvestigatorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_InvestigatorId",
                table: "Characteristics",
                column: "InvestigatorId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonalInformation_InvestigatorId",
                table: "PersonalInformation");

            migrationBuilder.DropIndex(
                name: "IX_Characteristics_InvestigatorId",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Characteristics");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_InvestigatorId",
                table: "PersonalInformation",
                column: "InvestigatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_InvestigatorId",
                table: "Characteristics",
                column: "InvestigatorId");
        }
    }
}
