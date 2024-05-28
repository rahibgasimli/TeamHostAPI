using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1d2dcf3c-f2ed-40c8-a224-f20e5ed2e88c"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8515), false, "Platformer ", null },
                    { new Guid("51b302cb-b2e1-42c7-87ea-3723291b88fa"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8501), false, "Survival", null },
                    { new Guid("536fcf2e-f2c1-4edd-9764-624813b15a34"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8506), false, "Shooter", null },
                    { new Guid("6c9c5007-e3df-4db2-8b6d-d04f9861d979"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8504), false, "Strategy", null },
                    { new Guid("9975d7da-5b13-4b04-9e16-71786f1d853d"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8498), false, "Adventure", null },
                    { new Guid("fc235475-fb4a-4621-87dd-0d3a1a3c7d73"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8493), false, "Action", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("4781b2ce-885a-45cc-b9c9-6d3eabda79e7"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8400), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("49d19064-87d4-475c-8646-0ccba58a93f2"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8397), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("848f4ea1-2dbe-41aa-a318-8b880e017df5"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8376), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("c83714f5-09c1-4788-a0a3-52b7c3a6ce05"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8246), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null },
                    { new Guid("d577b81f-ef99-4780-9696-bc5664270096"), new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8403), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("1d2dcf3c-f2ed-40c8-a224-f20e5ed2e88c"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("51b302cb-b2e1-42c7-87ea-3723291b88fa"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("536fcf2e-f2c1-4edd-9764-624813b15a34"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("6c9c5007-e3df-4db2-8b6d-d04f9861d979"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("9975d7da-5b13-4b04-9e16-71786f1d853d"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("fc235475-fb4a-4621-87dd-0d3a1a3c7d73"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4781b2ce-885a-45cc-b9c9-6d3eabda79e7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("49d19064-87d4-475c-8646-0ccba58a93f2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("848f4ea1-2dbe-41aa-a318-8b880e017df5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c83714f5-09c1-4788-a0a3-52b7c3a6ce05"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d577b81f-ef99-4780-9696-bc5664270096"));
        }
    }
}
