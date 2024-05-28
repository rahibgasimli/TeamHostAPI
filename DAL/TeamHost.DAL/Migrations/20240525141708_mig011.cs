using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ItemName", "PhotoPath", "Price", "UpdatedTime" },
                values: new object[] { new Guid("03c0c437-ed3c-46e9-b48a-9a90654d662d"), new DateTime(2024, 5, 25, 17, 17, 7, 644, DateTimeKind.Local).AddTicks(280), false, "CS:GO", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 15.0, null });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("48175469-4c2b-46da-857d-7e90b72247fd"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(250), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null },
                    { new Guid("e41b9185-c518-4cac-a0a8-a9fc07503791"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(254), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("11555468-c41d-483f-9b28-cee750d4b317"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(210), false, "Adventure", null },
                    { new Guid("19f05ff7-3490-4f47-a658-c98fe0ee0a99"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(213), false, "Strategy", null },
                    { new Guid("3a780afd-8a8b-4a78-8efb-e6c8b309dc98"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(221), false, "Platformer ", null },
                    { new Guid("9a1b9263-5bd6-4110-b654-e6c48de6130f"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(212), false, "Survival", null },
                    { new Guid("bb726bc1-9e8f-4106-978f-c01f0205a2c5"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(205), false, "Action", null },
                    { new Guid("ff523379-1adb-4f9f-b95b-308cb76b22b6"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(215), false, "Shooter", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("3c8ed4aa-0dee-49bd-86f2-98359f44ce1c"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(139), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("610a937c-1e5f-43e8-a450-7751a40c0e06"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(159), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("c4d08464-fbbb-40e6-b976-4581191e90da"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(155), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("cc576b4d-3524-437f-bb25-2c764fe40fd8"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(137), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("da97c67a-1116-48be-88aa-ef60a90b3649"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(152), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("e8142033-cd61-4660-b6fb-aee481844798"), new DateTime(2024, 5, 25, 14, 17, 7, 644, DateTimeKind.Utc).AddTicks(127), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("03c0c437-ed3c-46e9-b48a-9a90654d662d"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("48175469-4c2b-46da-857d-7e90b72247fd"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e41b9185-c518-4cac-a0a8-a9fc07503791"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("11555468-c41d-483f-9b28-cee750d4b317"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("19f05ff7-3490-4f47-a658-c98fe0ee0a99"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("3a780afd-8a8b-4a78-8efb-e6c8b309dc98"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("9a1b9263-5bd6-4110-b654-e6c48de6130f"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("bb726bc1-9e8f-4106-978f-c01f0205a2c5"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("ff523379-1adb-4f9f-b95b-308cb76b22b6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3c8ed4aa-0dee-49bd-86f2-98359f44ce1c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("610a937c-1e5f-43e8-a450-7751a40c0e06"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c4d08464-fbbb-40e6-b976-4581191e90da"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("cc576b4d-3524-437f-bb25-2c764fe40fd8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("da97c67a-1116-48be-88aa-ef60a90b3649"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e8142033-cd61-4660-b6fb-aee481844798"));

            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "Friends");

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
        }
    }
}
