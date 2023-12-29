using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class mg_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac28974-e5aa-422a-a4ce-92130725b45d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc754df2-0b8c-4ac6-bcf9-5040b68998bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5601ffc-5938-488e-af71-c3f3330a3d23", "122a28e9-10d2-4b6e-afc8-90291479a790", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f350ae93-a6f7-4c5d-b797-9b89f0c7bbaa", "ec213afb-02e2-43c6-9098-871d5dc7dfeb", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5601ffc-5938-488e-af71-c3f3330a3d23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f350ae93-a6f7-4c5d-b797-9b89f0c7bbaa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ac28974-e5aa-422a-a4ce-92130725b45d", "33cdd647-ee41-4fd8-9ba0-796c0d97dd75", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc754df2-0b8c-4ac6-bcf9-5040b68998bb", "6edab70b-2839-433f-903f-ea2212335581", "User", "USER" });
        }
    }
}
