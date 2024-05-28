using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ItemName", "PhotoPath", "Price", "UpdatedTime" },
                values: new object[] { new Guid("11920b06-d211-478d-a1e6-d3fb352fc3ca"), new DateTime(2024, 5, 26, 23, 46, 37, 879, DateTimeKind.Local).AddTicks(2440), false, "CS:GO", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 15.0, null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b181a76b-dad1-4417-be79-9d6a1c5776e2", "851a78b3-2ec9-42a9-babe-bf2afedf7d93", "Admin", "ADMİN" },
                    { "f6c610fd-d243-4fbb-bcaf-55d080e65ac0", "7aee8412-e9ce-4f92-996d-eb740379906b", "User", "USER" },
                    { "f93348b2-860c-4ad3-94d7-99673ddd6aa5", "139eacf5-4034-4639-9ca5-048ab3ba811e", "None", "NONE" }
                });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("5d955f6d-fe9c-427d-b77b-773a585addd5"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2266), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null },
                    { new Guid("6fd7d4b8-fee0-437c-8845-44b2793bf811"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2400), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("109eda1a-eb14-4f6f-8a6c-1d300940c12e"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2212), false, "Shooter", null },
                    { new Guid("620ac43e-faad-4da8-91ac-ffb58728a603"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2199), false, "Adventure", null },
                    { new Guid("883615b8-0b13-44e7-9407-c42d622c79ea"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2201), false, "Survival", null },
                    { new Guid("8a6556c3-ce49-48ce-8fe1-1dfec1b395d4"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2216), false, "Platformer ", null },
                    { new Guid("af10c60f-0cba-4f59-af88-b2839e445a43"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2193), false, "Action", null },
                    { new Guid("d098688e-591d-4a17-b6f0-6fa350cd0e9b"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2204), false, "Strategy", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1b5968f3-b5d1-4d9d-9f91-e4d0aaa7ec76"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2108), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("a0473da7-8837-4e36-8e32-15422e51b74b"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2102), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("d74f2aa5-7ef2-4323-9043-16de47b6ac26"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2117), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("e03a97b8-0d69-4afb-8862-f12ff3150d71"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2105), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("e2fa7c20-7efc-484f-bcac-03323d70f2f6"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2081), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("f74be486-9964-4621-b55f-b266ea055378"), new DateTime(2024, 5, 26, 20, 46, 37, 879, DateTimeKind.Utc).AddTicks(2070), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("11920b06-d211-478d-a1e6-d3fb352fc3ca"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b181a76b-dad1-4417-be79-9d6a1c5776e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6c610fd-d243-4fbb-bcaf-55d080e65ac0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f93348b2-860c-4ad3-94d7-99673ddd6aa5");

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("5d955f6d-fe9c-427d-b77b-773a585addd5"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("6fd7d4b8-fee0-437c-8845-44b2793bf811"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("109eda1a-eb14-4f6f-8a6c-1d300940c12e"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("620ac43e-faad-4da8-91ac-ffb58728a603"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("883615b8-0b13-44e7-9407-c42d622c79ea"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("8a6556c3-ce49-48ce-8fe1-1dfec1b395d4"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("af10c60f-0cba-4f59-af88-b2839e445a43"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("d098688e-591d-4a17-b6f0-6fa350cd0e9b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1b5968f3-b5d1-4d9d-9f91-e4d0aaa7ec76"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a0473da7-8837-4e36-8e32-15422e51b74b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d74f2aa5-7ef2-4323-9043-16de47b6ac26"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e03a97b8-0d69-4afb-8862-f12ff3150d71"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e2fa7c20-7efc-484f-bcac-03323d70f2f6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f74be486-9964-4621-b55f-b266ea055378"));

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
    }
}
