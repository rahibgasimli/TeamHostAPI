using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("0323c0d9-29a8-49ff-ab4a-1c621b1f38d6"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("04b66e50-02d9-4a2a-a5bb-5c0520ad2e85"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("6e922740-7eec-44b8-96d6-042e0233c32f"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("74c74bea-679f-4c58-aa2f-7d3d4fa87cca"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("bb3a30d1-949f-43fd-8477-8826f18eb284"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("d28c8e21-7df2-4ca6-b66b-9bfeff7d67b5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0500ccce-5a6a-4117-8320-e1ad08af8eb9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("19828b65-0863-4419-b3f9-257da3c48aa1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("946acb4d-87f4-4afd-85a9-78eafefc02d4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9fcdcc0c-7abb-4dd7-9f03-b947d8c79e79"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d4fc2ca2-d431-47c4-8b10-022f6e9b5a96"));

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("d8c9bfc5-05f7-46ac-96b6-2bd358616d4d"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8485), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null },
                    { new Guid("e20de67f-c1dd-4eb7-9a88-830b23e25349"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8489), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("09dc451c-bcd1-41a2-aa2a-c707616db1e8"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8443), false, "Action", null },
                    { new Guid("159db785-b1c6-4f20-ad52-b6c9fb8dce48"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8451), false, "Survival", null },
                    { new Guid("2af4f0f0-be42-470a-91e6-d8ee49c47ef2"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8452), false, "Strategy", null },
                    { new Guid("508ae1b8-65f6-4e26-a55b-e991e6685cad"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8454), false, "Shooter", null },
                    { new Guid("696f417d-c8e9-45dc-9bbf-fc1f5f89fc2b"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8457), false, "Platformer ", null },
                    { new Guid("d5b89253-8e2e-44c6-9804-4762c558dc66"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8449), false, "Adventure", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("2211148c-24c0-4bd7-ab09-75a7cd925367"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8369), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("2949a6e1-34ff-4eeb-8cc2-006db6d57a48"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8389), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("4ffa9d82-0b59-4e5a-9e0d-cb2269b1bca6"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8384), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("534d08ab-92aa-4668-8b49-f1129897b68b"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8373), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("7ef7188c-3672-413b-8b0f-0d00e716d45a"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8371), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("9dca105f-12e4-4621-98ae-63b684a35d1a"), new DateTime(2024, 5, 12, 21, 37, 50, 213, DateTimeKind.Utc).AddTicks(8362), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("d8c9bfc5-05f7-46ac-96b6-2bd358616d4d"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e20de67f-c1dd-4eb7-9a88-830b23e25349"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("09dc451c-bcd1-41a2-aa2a-c707616db1e8"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("159db785-b1c6-4f20-ad52-b6c9fb8dce48"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("2af4f0f0-be42-470a-91e6-d8ee49c47ef2"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("508ae1b8-65f6-4e26-a55b-e991e6685cad"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("696f417d-c8e9-45dc-9bbf-fc1f5f89fc2b"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("d5b89253-8e2e-44c6-9804-4762c558dc66"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2211148c-24c0-4bd7-ab09-75a7cd925367"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2949a6e1-34ff-4eeb-8cc2-006db6d57a48"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4ffa9d82-0b59-4e5a-9e0d-cb2269b1bca6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("534d08ab-92aa-4668-8b49-f1129897b68b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7ef7188c-3672-413b-8b0f-0d00e716d45a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9dca105f-12e4-4621-98ae-63b684a35d1a"));

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0323c0d9-29a8-49ff-ab4a-1c621b1f38d6"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5644), false, "Adventure", null },
                    { new Guid("04b66e50-02d9-4a2a-a5bb-5c0520ad2e85"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5656), false, "Platformer ", null },
                    { new Guid("6e922740-7eec-44b8-96d6-042e0233c32f"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5639), false, "Action", null },
                    { new Guid("74c74bea-679f-4c58-aa2f-7d3d4fa87cca"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5653), false, "Shooter", null },
                    { new Guid("bb3a30d1-949f-43fd-8477-8826f18eb284"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5645), false, "Survival", null },
                    { new Guid("d28c8e21-7df2-4ca6-b66b-9bfeff7d67b5"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5647), false, "Strategy", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0500ccce-5a6a-4117-8320-e1ad08af8eb9"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5588), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("19828b65-0863-4419-b3f9-257da3c48aa1"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5592), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("946acb4d-87f4-4afd-85a9-78eafefc02d4"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5590), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("9fcdcc0c-7abb-4dd7-9f03-b947d8c79e79"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5585), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("d4fc2ca2-d431-47c4-8b10-022f6e9b5a96"), new DateTime(2024, 5, 5, 10, 28, 22, 295, DateTimeKind.Utc).AddTicks(5561), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null }
                });
        }
    }
}
