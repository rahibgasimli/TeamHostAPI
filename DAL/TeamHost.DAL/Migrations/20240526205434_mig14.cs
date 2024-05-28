using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("0610ead0-1fce-48b2-8bf9-2a77e34fd8f1"), new DateTime(2024, 5, 26, 23, 54, 33, 828, DateTimeKind.Local).AddTicks(7010), false, "CS:GO", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 15.0, null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "93592c5c-4fbf-42b5-94b0-9a52987a37fc", "e6d5483e-c268-4a95-a65d-0370a2d850ad", "Admin", "ADMİN" },
                    { "abc804e5-bc7c-42d8-b52b-abc22305fd70", "c09295d9-522e-4d0e-a07a-bc6f3a7bfb51", "None", "NONE" },
                    { "b6f67aa3-aa50-4c7a-8b32-3df0fc25e8bb", "c2bd4672-1325-41ee-a6d5-59c95d4baafc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("18f7250a-778b-454e-b7ec-d6a9329b9ad2"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6970), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null },
                    { new Guid("9611b72d-09f7-41b0-a303-766f9640ad63"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6978), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("27221d89-73bb-47ca-bea5-731f088d11a3"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6914), false, "Shooter", null },
                    { new Guid("57397a05-4e13-4f56-9d6f-368272a847fb"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6918), false, "Platformer ", null },
                    { new Guid("a1defbf6-5e84-4fd2-9997-968da45dea49"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6901), false, "Adventure", null },
                    { new Guid("a28b8358-02b6-4c3e-902b-2f935aa6817e"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6904), false, "Survival", null },
                    { new Guid("b47c0136-6be2-4ea8-9785-4dfea14c4f19"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6896), false, "Action", null },
                    { new Guid("c0db0f93-0eb2-45c2-8fcd-7df7db222537"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6906), false, "Strategy", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("13510435-a7da-4a77-97a5-e49634773c3e"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6718), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("54d3bf9c-2a5d-44bd-9653-37b2a5902748"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6728), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("ae773116-cd89-400e-a26b-266ea564bfc7"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6696), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("b1dd2aa5-ed29-4fce-8580-5147ef48c4a3"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6715), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("c2614590-fc37-4523-b629-06f5dbb248fd"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6721), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("cec08206-7ae6-4504-a7d8-70fa03104b2d"), new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6686), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0610ead0-1fce-48b2-8bf9-2a77e34fd8f1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93592c5c-4fbf-42b5-94b0-9a52987a37fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abc804e5-bc7c-42d8-b52b-abc22305fd70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6f67aa3-aa50-4c7a-8b32-3df0fc25e8bb");

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("18f7250a-778b-454e-b7ec-d6a9329b9ad2"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("9611b72d-09f7-41b0-a303-766f9640ad63"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("27221d89-73bb-47ca-bea5-731f088d11a3"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("57397a05-4e13-4f56-9d6f-368272a847fb"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("a1defbf6-5e84-4fd2-9997-968da45dea49"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("a28b8358-02b6-4c3e-902b-2f935aa6817e"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("b47c0136-6be2-4ea8-9785-4dfea14c4f19"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("c0db0f93-0eb2-45c2-8fcd-7df7db222537"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("13510435-a7da-4a77-97a5-e49634773c3e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("54d3bf9c-2a5d-44bd-9653-37b2a5902748"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae773116-cd89-400e-a26b-266ea564bfc7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b1dd2aa5-ed29-4fce-8580-5147ef48c4a3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c2614590-fc37-4523-b629-06f5dbb248fd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("cec08206-7ae6-4504-a7d8-70fa03104b2d"));

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
    }
}
