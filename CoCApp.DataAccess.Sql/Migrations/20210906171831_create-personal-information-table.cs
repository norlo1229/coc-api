using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoCApp.DataAccess.Sql.Migrations
{
    public partial class createpersonalinformationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Residence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestigatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalInformation_Investigator_InvestigatorId",
                        column: x => x.InvestigatorId,
                        principalTable: "Investigator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_InvestigatorId",
                table: "PersonalInformation",
                column: "InvestigatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalInformation");
        }
    }
}
