using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChaserFood.Migrations
{
    public partial class UpdatePhoneNumberToNvarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                schema: "donor",
                table: "individuals",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "phone_number",
                schema: "donor",
                table: "individuals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }
    }
}
