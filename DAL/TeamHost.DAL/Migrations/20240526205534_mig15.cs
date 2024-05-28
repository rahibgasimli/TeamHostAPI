using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("92e1689a-6f6e-46f7-b9e7-83aa2a21e51b"), new DateTime(2024, 5, 26, 23, 55, 33, 300, DateTimeKind.Local).AddTicks(9186), false, "CS:GO", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 15.0, null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d590d94a-38e1-4e5f-8d83-7cdc22ddb491", "f8fc27bf-5d16-4bb4-86c0-69529a29e194", "User", "USER" },
                    { "e536908f-2d40-4b58-a912-6b07cc4dda1b", "41b58a93-6968-416f-bc25-41b15d766b89", "None", "NONE" },
                    { "fb7367a7-2b13-4e16-b216-a6c24065c49b", "1622e954-8364-4599-bcd7-2a0a78c5db98", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("719e0cd5-8d54-4f4e-9808-a2230c22abd8"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9161), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null },
                    { new Guid("9693a513-68c6-42b7-991e-c81431298e85"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9158), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("171a8e0c-341a-42a1-8631-f69caf9514a5"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9115), false, "Adventure", null },
                    { new Guid("179dddd3-b45f-440d-940f-5bf2d6d810f6"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9120), false, "Shooter", null },
                    { new Guid("2463b393-673c-4e82-9cc1-c3d3360ab577"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9119), false, "Strategy", null },
                    { new Guid("5bc64b4f-5d3c-41e3-8038-7f2c279f131f"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9101), false, "Action", null },
                    { new Guid("721133bc-3944-47f5-bfad-e888d992fa6a"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9117), false, "Survival", null },
                    { new Guid("c9bb2b22-d1fb-4a92-a9ed-0541dc1e9ff6"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9123), false, "Platformer ", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("48efeec2-5161-42f0-9e12-2fc7a2b72ea9"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9040), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("5c74222a-94d7-40f6-a865-5bf6d084ad8f"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9032), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("62144089-383c-478b-a0b2-823db00a945a"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9020), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null },
                    { new Guid("c514f654-4ae9-427d-b829-6cde8c1f605d"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9034), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("ca986359-02b3-4178-91cc-139b7e36de2e"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9028), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("db033f09-d6f2-4d91-993f-70e960aae7e6"), new DateTime(2024, 5, 26, 20, 55, 33, 300, DateTimeKind.Utc).AddTicks(9030), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("92e1689a-6f6e-46f7-b9e7-83aa2a21e51b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d590d94a-38e1-4e5f-8d83-7cdc22ddb491");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e536908f-2d40-4b58-a912-6b07cc4dda1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb7367a7-2b13-4e16-b216-a6c24065c49b");

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("719e0cd5-8d54-4f4e-9808-a2230c22abd8"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("9693a513-68c6-42b7-991e-c81431298e85"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("171a8e0c-341a-42a1-8631-f69caf9514a5"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("179dddd3-b45f-440d-940f-5bf2d6d810f6"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("2463b393-673c-4e82-9cc1-c3d3360ab577"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("5bc64b4f-5d3c-41e3-8038-7f2c279f131f"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("721133bc-3944-47f5-bfad-e888d992fa6a"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("c9bb2b22-d1fb-4a92-a9ed-0541dc1e9ff6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("48efeec2-5161-42f0-9e12-2fc7a2b72ea9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5c74222a-94d7-40f6-a865-5bf6d084ad8f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("62144089-383c-478b-a0b2-823db00a945a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c514f654-4ae9-427d-b829-6cde8c1f605d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca986359-02b3-4178-91cc-139b7e36de2e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("db033f09-d6f2-4d91-993f-70e960aae7e6"));

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
    }
}
