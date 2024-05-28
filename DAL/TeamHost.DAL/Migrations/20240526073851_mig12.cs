using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6d37eaed-7b62-4522-9f02-82b712664a96"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8deffe91-1ac9-49ef-a884-78f2f2be47c2"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("af089b59-4970-4def-bb92-b2360fcdf818"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("469b3ed3-573b-4c95-a3fb-8f9f788f1991"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("46cab964-7635-436a-a8ee-b70b6020c211"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("bad4d19d-0899-4424-a1e6-564bb7d35762"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("c46d2d22-3f40-4b2b-b24c-c1220732885b"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("e9b9c8c4-36a9-4fc2-b17c-706a3cddd9be"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("f788ea4e-06f6-4b9c-a59f-5c470ed392d6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("283f1ec6-8e03-44d8-95f7-dfc69261f590"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34df34a7-e7c7-420b-bdfb-c71eaa918bfd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3c855320-1382-4da3-94eb-11bfe774b66f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6df4447d-0ffa-40db-a79c-e28b87de820c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("70d59cad-aba0-4946-9854-9743ec41fbd0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d9df09f8-7ce1-40c5-bd0b-ba15044e4c68"));

            migrationBuilder.DropColumn(
                name: "Request",
                table: "Friends");

            migrationBuilder.AddColumn<int>(
                name: "Pending",
                table: "Friends",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ItemName", "PhotoPath", "Price", "UpdatedTime" },
                values: new object[] { new Guid("0f04055e-e148-4201-9dfe-c8c3bc9e39c8"), new DateTime(2024, 5, 26, 10, 38, 50, 395, DateTimeKind.Local).AddTicks(1956), false, "CS:GO", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 15.0, null });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0796e6f3-1b6f-4a35-9540-58afbe9550aa"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1931), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null },
                    { new Guid("cfde734f-9779-4b87-8cef-b9095e1fa9a4"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1928), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0b8d996d-02d5-4b81-bf07-828e702db632"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1887), false, "Strategy", null },
                    { new Guid("1922175e-9613-4143-98df-52c29ff8d5aa"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1889), false, "Shooter", null },
                    { new Guid("4e941473-079c-4a69-b345-a362d440c867"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1886), false, "Survival", null },
                    { new Guid("569898ec-92fc-48e6-be7e-c52d10b82f2f"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1895), false, "Platformer ", null },
                    { new Guid("a8f71341-b982-4762-aec9-5b4ab776330c"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1881), false, "Action", null },
                    { new Guid("fc36f508-8bc3-4ddc-9d03-b354728334ec"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1884), false, "Adventure", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("15317366-9ecb-4e02-8a0b-ce591f32dbf8"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1829), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("2dbcc1bd-2b69-4b9b-9208-323920951f89"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1835), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("91f2dd20-b51d-408f-8c53-0349c6ce4072"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1807), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null },
                    { new Guid("b14fe150-3366-4b9f-9548-59b3d567e3dd"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1831), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("b8073866-476b-407a-a7da-ae13ebe4a5ab"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1814), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("e291bb09-1f95-41bb-a064-8d3dc4faa0f5"), new DateTime(2024, 5, 26, 7, 38, 50, 395, DateTimeKind.Utc).AddTicks(1816), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0f04055e-e148-4201-9dfe-c8c3bc9e39c8"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0796e6f3-1b6f-4a35-9540-58afbe9550aa"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("cfde734f-9779-4b87-8cef-b9095e1fa9a4"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("0b8d996d-02d5-4b81-bf07-828e702db632"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("1922175e-9613-4143-98df-52c29ff8d5aa"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("4e941473-079c-4a69-b345-a362d440c867"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("569898ec-92fc-48e6-be7e-c52d10b82f2f"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("a8f71341-b982-4762-aec9-5b4ab776330c"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("fc36f508-8bc3-4ddc-9d03-b354728334ec"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("15317366-9ecb-4e02-8a0b-ce591f32dbf8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2dbcc1bd-2b69-4b9b-9208-323920951f89"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("91f2dd20-b51d-408f-8c53-0349c6ce4072"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b14fe150-3366-4b9f-9548-59b3d567e3dd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b8073866-476b-407a-a7da-ae13ebe4a5ab"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e291bb09-1f95-41bb-a064-8d3dc4faa0f5"));

            migrationBuilder.DropColumn(
                name: "Pending",
                table: "Friends");

            migrationBuilder.AddColumn<bool>(
                name: "Request",
                table: "Friends",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ItemName", "PhotoPath", "Price", "UpdatedTime" },
                values: new object[] { new Guid("6d37eaed-7b62-4522-9f02-82b712664a96"), new DateTime(2024, 5, 25, 17, 30, 48, 137, DateTimeKind.Local).AddTicks(2931), false, "CS:GO", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 15.0, null });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("8deffe91-1ac9-49ef-a884-78f2f2be47c2"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2878), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null },
                    { new Guid("af089b59-4970-4def-bb92-b2360fcdf818"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2887), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("469b3ed3-573b-4c95-a3fb-8f9f788f1991"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2817), false, "Platformer ", null },
                    { new Guid("46cab964-7635-436a-a8ee-b70b6020c211"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2783), false, "Action", null },
                    { new Guid("bad4d19d-0899-4424-a1e6-564bb7d35762"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2809), false, "Survival", null },
                    { new Guid("c46d2d22-3f40-4b2b-b24c-c1220732885b"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2806), false, "Adventure", null },
                    { new Guid("e9b9c8c4-36a9-4fc2-b17c-706a3cddd9be"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2813), false, "Shooter", null },
                    { new Guid("f788ea4e-06f6-4b9c-a59f-5c470ed392d6"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2811), false, "Strategy", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("283f1ec6-8e03-44d8-95f7-dfc69261f590"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2641), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("34df34a7-e7c7-420b-bdfb-c71eaa918bfd"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2654), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("3c855320-1382-4da3-94eb-11bfe774b66f"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2606), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null },
                    { new Guid("6df4447d-0ffa-40db-a79c-e28b87de820c"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2639), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("70d59cad-aba0-4946-9854-9743ec41fbd0"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2636), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("d9df09f8-7ce1-40c5-bd0b-ba15044e4c68"), new DateTime(2024, 5, 25, 14, 30, 48, 137, DateTimeKind.Utc).AddTicks(2644), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null }
                });
        }
    }
}
