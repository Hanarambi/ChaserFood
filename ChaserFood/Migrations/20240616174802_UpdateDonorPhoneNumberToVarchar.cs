using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChaserFood.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDonorPhoneNumberToVarchar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "donor");

            migrationBuilder.CreateTable(
                name: "individuals",
                schema: "donor",
                columns: table => new
                {
                    phone_number = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    street_address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    state = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    zip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    email_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    with_school = table.Column<bool>(type: "bool", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_individuals", x => x.phone_number);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "individuals",
                schema: "donor");
        }
    }
}
