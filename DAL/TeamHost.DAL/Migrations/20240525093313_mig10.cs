using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("a661d1d9-658d-4fca-8f16-0447927d5e47"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("a8767d9d-45e3-4f88-b7e3-7456ac142c2c"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("26aca6c4-65ed-470f-bf00-89e90ecaffbb"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("3217dd6b-d147-4eac-af23-cf7e17fe1956"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("4546fe39-55ac-4452-a0a2-dd0fffc392d5"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("52f19da0-d9a9-4822-a31b-1e0283d6a4c2"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("8552c009-cdc0-48bb-9877-a42ffe6133a0"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("ad586c63-54e2-411b-8179-567e49c48580"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0bb48944-23ef-437e-90d5-d552b3158dc9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1dfdbbad-7fd6-469c-9930-febd92fe0e7a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("378fae46-31aa-429d-99cc-790a96d16089"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3bc2b4b6-58f4-42fd-8050-893ef723a8eb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("71bbfd4e-5a62-429c-a87b-ee887bac118c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7d9175ad-5118-4e5f-adbc-d4ed3efbf195"));

            migrationBuilder.CreateTable(
                name: "UserComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ItemName", "PhotoPath", "Price", "UpdatedTime" },
                values: new object[] { new Guid("deea1fe4-b11f-40b4-9a25-584196dda12b"), new DateTime(2024, 5, 25, 12, 33, 13, 107, DateTimeKind.Local).AddTicks(9519), false, "CS:GO", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 15.0, null });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("208c7374-672a-4758-a0b3-bad0e2069bd2"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9491), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null },
                    { new Guid("83e040dd-c582-457e-872a-987e1a2aa8bd"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9494), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("ab12404b-699e-47dd-998c-1d40f3d4b992"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9438), false, "Action", null },
                    { new Guid("cba85458-fd62-401f-ae21-d2ddf88ae3d7"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9452), false, "Platformer ", null },
                    { new Guid("df0c25aa-0ac9-4bef-a218-c786d9d31163"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9446), false, "Shooter", null },
                    { new Guid("efb16f35-2b5b-4131-9179-01f9b826c7f3"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9444), false, "Strategy", null },
                    { new Guid("fa1a062d-aeb2-4948-bdc3-b8229af9fc84"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9443), false, "Survival", null },
                    { new Guid("fa9c9fdc-a12e-4cd8-8a3d-42645d2461ee"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9441), false, "Adventure", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0373456b-fb00-47bc-86cb-ac8233ee3a77"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9379), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("39cae7d7-d9a9-4d79-9459-10a0b8d2bd02"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9372), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("7e9ba730-8be3-43bd-af1c-1148c21858bb"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9374), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("b1a5763a-1b3c-4913-9ffd-a07d802d10a7"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9356), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("b70cd03a-3e24-4c41-844b-3aeaba11eee6"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9358), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("e0ffbba8-5f1a-4ba0-8065-14863d7533d7"), new DateTime(2024, 5, 25, 9, 33, 13, 107, DateTimeKind.Utc).AddTicks(9349), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_AppUserId",
                table: "UserComments",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserComments");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("deea1fe4-b11f-40b4-9a25-584196dda12b"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("208c7374-672a-4758-a0b3-bad0e2069bd2"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("83e040dd-c582-457e-872a-987e1a2aa8bd"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("ab12404b-699e-47dd-998c-1d40f3d4b992"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("cba85458-fd62-401f-ae21-d2ddf88ae3d7"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("df0c25aa-0ac9-4bef-a218-c786d9d31163"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("efb16f35-2b5b-4131-9179-01f9b826c7f3"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("fa1a062d-aeb2-4948-bdc3-b8229af9fc84"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("fa9c9fdc-a12e-4cd8-8a3d-42645d2461ee"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0373456b-fb00-47bc-86cb-ac8233ee3a77"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("39cae7d7-d9a9-4d79-9459-10a0b8d2bd02"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7e9ba730-8be3-43bd-af1c-1148c21858bb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b1a5763a-1b3c-4913-9ffd-a07d802d10a7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b70cd03a-3e24-4c41-844b-3aeaba11eee6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e0ffbba8-5f1a-4ba0-8065-14863d7533d7"));

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("a661d1d9-658d-4fca-8f16-0447927d5e47"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4390), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null },
                    { new Guid("a8767d9d-45e3-4f88-b7e3-7456ac142c2c"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4385), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("26aca6c4-65ed-470f-bf00-89e90ecaffbb"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4310), false, "Adventure", null },
                    { new Guid("3217dd6b-d147-4eac-af23-cf7e17fe1956"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4313), false, "Survival", null },
                    { new Guid("4546fe39-55ac-4452-a0a2-dd0fffc392d5"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4317), false, "Shooter", null },
                    { new Guid("52f19da0-d9a9-4822-a31b-1e0283d6a4c2"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4328), false, "Platformer ", null },
                    { new Guid("8552c009-cdc0-48bb-9877-a42ffe6133a0"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4304), false, "Action", null },
                    { new Guid("ad586c63-54e2-411b-8179-567e49c48580"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4315), false, "Strategy", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0bb48944-23ef-437e-90d5-d552b3158dc9"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4201), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("1dfdbbad-7fd6-469c-9930-febd92fe0e7a"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4198), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("378fae46-31aa-429d-99cc-790a96d16089"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4208), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("3bc2b4b6-58f4-42fd-8050-893ef723a8eb"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4176), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("71bbfd4e-5a62-429c-a87b-ee887bac118c"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4179), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("7d9175ad-5118-4e5f-adbc-d4ed3efbf195"), new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4165), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null }
                });
        }
    }
}
