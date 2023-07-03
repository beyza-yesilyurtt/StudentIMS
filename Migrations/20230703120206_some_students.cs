using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_IMS.Migrations
{
    public partial class some_students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Name", "StudentNumber", "Surname" },
                values: new object[,]
                {
                    { 1, 20, "John", 123456, "Doe" },
                    { 2, 21, "Jane", 654321, "Doe" },
                    { 3, 22, "John", 123654, "Smith" },
                    { 4, 23, "Jane", 321654, "Smith" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
