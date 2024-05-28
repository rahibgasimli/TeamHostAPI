using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "UserId",
                table: "UserComments");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserComments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
