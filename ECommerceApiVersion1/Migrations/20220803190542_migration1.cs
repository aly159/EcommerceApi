using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceApiVersion1.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
            table: "users",
            columns: new[] { "Id", "Username", "Age", "Gender", "Password", "Mail" , "Role" },
            values: new object[]
            {
                 1 , "admin" ,18 , false , "admin" ,"test@gmail.com" ,0});

            migrationBuilder.InsertData(
           table: "users",
           columns: new[] { "Id", "Username", "Age", "Gender", "Password", "Mail", "Role" },
           values: new object[]
           {
                 2 , "user" ,18 , false , "user" ,"test2@gmail.com" ,1});
        }
    


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DeleteData(
           table: "users",
           keyColumn: "Id",
           keyValue: 1);

            migrationBuilder.DeleteData(
          table: "users",
          keyColumn: "Id",
          keyValue: 2);
        }

    }
}
