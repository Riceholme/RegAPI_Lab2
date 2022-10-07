using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegAPI_Lab2.Migrations
{
    public partial class firstcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "We like numbers and profit", "Economy" },
                    { 2, "System development and digitization", "IT" },
                    { 3, "Markets our company and products", "Marketing" },
                    { 4, "We sold our soul to sell", "Sales" }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Adress", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { 1, "fågelvägen 4", 1, "kalle@anka.se", "Kalle", "Man", "Anka", "0706655221", 30000m },
                    { 2, "fjädergatan 3", 2, "knatte@anka.se", "Knatte", "Man", "Anka", "0703343123", 30000m },
                    { 3, "näbbvägen 34", 3, "tjatte@anka.se", "Tjatte", "Man", "Anka", "0702122569", 30000m },
                    { 4, "luftgatan 40", 4, "fnatte@anka.se", "Fnatte", "Man", "Anka", "07032323223", 30000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentId",
                table: "employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
