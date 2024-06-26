using Microsoft.EntityFrameworkCore.Migrations;

namespace ChaserFood.Migrations
{
    public partial class AddNewClientModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewClients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(nullable: false),
                    County = table.Column<string>(nullable: false),
                    CurrentAge = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Race = table.Column<string>(nullable: false),
                    EmploymentStatus = table.Column<string>(nullable: false),
                    StudentStatus = table.Column<string>(nullable: false),
                    NumberOfFamilyMembers = table.Column<int>(nullable: false),
                    NumberOfAdults = table.Column<int>(nullable: false),
                    NumberOfChildren = table.Column<int>(nullable: false),
                    AgesOfChildren = table.Column<string>(nullable: true),
                    AnyElderly = table.Column<bool>(nullable: false),
                    NumberOfEmployedFamilyMembers = table.Column<int>(nullable: false),
                    HousingStatus = table.Column<string>(nullable: false),
                    HasTransportation = table.Column<bool>(nullable: true),
                    HasStove = table.Column<bool>(nullable: true),
                    HasMicrowave = table.Column<bool>(nullable: true),
                    HasCanOpener = table.Column<bool>(nullable: true),
                    HasRunningWater = table.Column<bool>(nullable: true),
                    DietaryRestrictions = table.Column<string>(nullable: true),
                    FoodAllergies = table.Column<string>(nullable: true),
                    TypesOfFoodConsumed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewClients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewClients");
        }
    }
}
