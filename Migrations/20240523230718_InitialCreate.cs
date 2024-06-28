using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChaserFood.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true), //consider allowing null, this might help us populate the db
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEligible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

        
            migrationBuilder.CreateTable(
                name: "AvailableItems",
                columns: table => new
                {
                    Barcode = table.Column<string>(nullable: false),
                    Location_id = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableItems", x => x.Barcode);
                });

            migrationBuilder.CreateTable(
         name: "Brands",
         columns: table => new
         {
             BrandId = table.Column<int>(nullable: false)
                 .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
             BrandName = table.Column<string>(nullable: true)
         },
         constraints: table =>
         {
             table.PrimaryKey("PK_Brands", x => x.BrandId);
         });

            migrationBuilder.CreateTable(
        name: "Businesses",
        columns: table => new
        {
            BusinessId = table.Column<int>(nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            PhoneNumber = table.Column<string>(nullable: true),
            BusinessName = table.Column<string>(nullable: false), // Assuming you want this to be non-nullable
            StreetAddress = table.Column<string>(nullable: true),
            City = table.Column<string>(nullable: true),
            State = table.Column<string>(nullable: true),
            Zip = table.Column<int>(nullable: false),
            Title = table.Column<string>(nullable: true),
            EmailAddress = table.Column<string>(nullable: true)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Businesses", x => x.BusinessId);
        });

            migrationBuilder.CreateTable(
        name: "Categories",
        columns: table => new
        {
            CategoryId = table.Column<int>(nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            CategoryName = table.Column<string>(nullable: true)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Categories", x => x.CategoryId);
        });

            migrationBuilder.CreateTable(
       name: "Clients",
       columns: table => new
       {
           StudentId = table.Column<int>(nullable: false)
               .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
           LastName = table.Column<string>(nullable: false),
           FirstName = table.Column<string>(nullable: false),
           PhoneNumber = table.Column<long>(nullable: false),
           StreetAddress = table.Column<string>(nullable: true),
           City = table.Column<string>(nullable: true),
           State = table.Column<string>(nullable: true),
           Zip = table.Column<int>(nullable: false),
           EmailAddress = table.Column<string>(nullable: true),
           HouseholdAdults = table.Column<int>(nullable: false),
           HouseholdChildren = table.Column<int>(nullable: false),
           HasStove = table.Column<bool>(nullable: false),
           HasMicrowave = table.Column<bool>(nullable: false),
           HasCanOpener = table.Column<bool>(nullable: false),
           HasRunningWater = table.Column<bool>(nullable: false),
           DietaryRestrictions = table.Column<string>(nullable: true),
           Allergies = table.Column<string>(nullable: true),
           Age = table.Column<int>(nullable: false),
           AfricanAmerican = table.Column<bool>(nullable: false),
           Asian = table.Column<bool>(nullable: false),
           Caucasian = table.Column<bool>(nullable: false),
           Latino = table.Column<bool>(nullable: false),
           MiddleEastern = table.Column<bool>(nullable: false),
           NativeAmerican = table.Column<bool>(nullable: false),
           PacificIslander = table.Column<bool>(nullable: false),
           Other = table.Column<bool>(nullable: false),
           OtherWriteIn = table.Column<string>(nullable: true),
           Gender = table.Column<string>(nullable: true),
           HasTransportation = table.Column<bool>(nullable: false),
           IsStaff = table.Column<bool>(nullable: false),
           IsFaculty = table.Column<bool>(nullable: false),
           FullTimeStudent = table.Column<bool>(nullable: false),
           PartTimeStudent = table.Column<bool>(nullable: false),
           TraditionalStudent = table.Column<bool>(nullable: false),
           NonTraditionalStudent = table.Column<bool>(nullable: false),
           IsEmployed = table.Column<bool>(nullable: false),
           EmploymentStatus = table.Column<string>(nullable: true),
           HouseholdEmployed = table.Column<int>(nullable: false),
           Housing = table.Column<string>(nullable: true),
           BenefitsReceived = table.Column<string>(nullable: true),
           LearnAboutBenefits = table.Column<bool>(nullable: false),
           LearnWhichBenefits = table.Column<string>(nullable: true)
       },
       constraints: table =>
       {
           table.PrimaryKey("PK_Clients", x => x.StudentId);
       });

            migrationBuilder.CreateTable(
        name: "Individuals",
        columns: table => new
        {
            IndividualId = table.Column<int>(nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            PhoneNumber = table.Column<string>(nullable: false),
            FirstName = table.Column<string>(nullable: false),
            LastName = table.Column<string>(nullable: false),
            StreetAddress = table.Column<string>(nullable: true),
            City = table.Column<string>(nullable: true),
            State = table.Column<string>(nullable: true),
            Zip = table.Column<int>(nullable: false),
            EmailAddress = table.Column<string>(nullable: true),
            WithSchool = table.Column<bool>(nullable: true)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Individuals", x => x.IndividualId);
        });

            migrationBuilder.CreateTable(
        name: "Locations",
        columns: table => new
        {
            LocationId = table.Column<int>(nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            LocationName = table.Column<string>(nullable: true)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Locations", x => x.LocationId);
        });

            migrationBuilder.CreateTable(
        name: "Purchases",
        columns: table => new
        {
            PurchasedId = table.Column<Guid>(nullable: false), // Assuming Guid as the type for the new ID
            Date = table.Column<DateTime>(nullable: false),
            Purchaser = table.Column<string>(nullable: true),
            PhoneNumber = table.Column<long>(nullable: true)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Purchases", x => x.PurchasedId);
        });

            migrationBuilder.CreateTable(
        name: "Receipts",
        columns: table => new
        {
            DonationNumber = table.Column<int>(nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            PhoneNumber = table.Column<string>(nullable: true),
            Barcode = table.Column<string>(nullable: true),
            DonatedCount = table.Column<int>(nullable: false),
            LocationId = table.Column<string>(nullable: true),
            DonationDate = table.Column<DateTime>(nullable: false)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Receipts", x => x.DonationNumber);
            // If there are foreign key relationships, you might need to add them here
        });

            migrationBuilder.CreateTable(
            name: "Requests",
            columns: table => new
            {
                RequestNumber = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                StudentId = table.Column<int>(nullable: false),
                Barcode = table.Column<string>(nullable: false),
                RequestCount = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Requests", x => x.RequestNumber);
                // Assuming there's a Students table with StudentId as a primary key
                table.ForeignKey(
                    name: "FK_Requests_Students_StudentId",
                    column: x => x.StudentId,
                    principalTable: "Students",
                    principalColumn: "StudentId",
                    onDelete: ReferentialAction.Cascade);
            });

            
            migrationBuilder.CreateTable(
            name: "Surveys",
            columns: table => new
            {
                SurveyId = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                StudentId = table.Column<int>(nullable: false),
                Focus = table.Column<int>(nullable: false),
                Attendance = table.Column<int>(nullable: false),
                Grades = table.Column<int>(nullable: false),
                Enrolled = table.Column<int>(nullable: false),
                WorkBetter = table.Column<int>(nullable: false),
                StayEmployed = table.Column<int>(nullable: false),
                Treatment = table.Column<int>(nullable: false),
                HoursGood = table.Column<int>(nullable: false),
                AdditionalProducts = table.Column<string>(nullable: true),
                AdditionalServices = table.Column<string>(nullable: true),
                Improvements = table.Column<string>(nullable: true),
                Comments = table.Column<string>(nullable: true),
                VolunteerDonor = table.Column<bool>(nullable: false),
                VolunteerCommittee = table.Column<bool>(nullable: false),
                VolunteerOther = table.Column<string>(nullable: true),
                NeedForPantry = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Surveys", x => x.SurveyId);
                // Assuming there's a Students table with StudentId as a primary key
                table.ForeignKey(
                    name: "FK_Surveys_Students_StudentId",
                    column: x => x.StudentId,
                    principalTable: "Students",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });
        }



    }


    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AvailableItems");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Surveys");


        }
    }
}
