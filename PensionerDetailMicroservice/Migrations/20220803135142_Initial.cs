using Microsoft.EntityFrameworkCore.Migrations;

namespace PensionerDetailMicroservice.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pensionerDetailModels",
                columns: table => new
                {
                    aadharno = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pan = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    dob = table.Column<string>(nullable: true),
                    salaryearned = table.Column<long>(nullable: false),
                    allowances = table.Column<long>(nullable: false),
                    pensiontype = table.Column<string>(nullable: true),
                    accno = table.Column<string>(nullable: true),
                    bankname = table.Column<string>(nullable: true),
                    banktype = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pensionerDetailModels", x => x.aadharno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pensionerDetailModels");
        }
    }
}
