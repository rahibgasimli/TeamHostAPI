using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class marketcardmig07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0b8662d5-a929-47a3-9d45-369ef7f2d246"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("476f35d8-34da-406a-ab8a-71d51136f63c"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("23b5e3e3-293b-4ab2-85e5-30c7fba13998"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("2ba1b4e3-bc22-43aa-b79a-a3ea24e4c1a6"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("83a34fa6-1459-452f-adeb-077379b747d1"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("b3aaa7e3-b319-46ca-bf35-ff1a3ccc64f4"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("d6974c2d-a939-4ebf-91ee-eea9848fbaa0"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("f719a7e4-7446-46dd-99e6-94fe57c2d986"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("106eced1-a698-4dc1-bd1c-a9cfac4b62ab"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("363cdc94-b983-45b8-a85a-6fdfb235abd1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5b4d0997-021d-4b30-87d8-26f43cd36f35"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("64be7c8b-fd1f-46a8-a2d1-5bfbd611bb9b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9c8bb37a-5f30-411c-8e8f-6e851b8fd35a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b9217e94-cbaf-4d40-857c-0bf98f3a0be2"));

            migrationBuilder.CreateTable(
                name: "MarketCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("5bad5161-34f1-4b25-8c08-8b1251ec0a49"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7826), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null },
                    { new Guid("ee5763b4-0842-487e-bdd2-4bfb86e18766"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7813), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1bf40315-61db-417f-a5f1-5f639cf2ae56"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7621), false, "Action", null },
                    { new Guid("7be500d4-f408-49e6-8c07-cdc4cd390617"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7669), false, "Strategy", null },
                    { new Guid("91381d18-322c-4714-b906-7465b36bb29a"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7684), false, "Platformer ", null },
                    { new Guid("a5bb0cd3-d204-4714-b62d-f268aced1454"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7642), false, "Adventure", null },
                    { new Guid("a667e9c2-61cc-4a76-912f-38061e3f3f7d"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7647), false, "Survival", null },
                    { new Guid("a93cdaf4-3958-4bde-b03f-911c239fa6a2"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7673), false, "Shooter", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1e12523b-152c-4b2a-a0cb-101bf1321d14"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7479), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("89d0c8c4-a462-4431-b601-094cf286983d"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7483), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("a87c75fc-5be7-4403-bf3b-fae493036c7e"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7456), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null },
                    { new Guid("b09b7e06-c941-4d38-8cda-40445fe505e2"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7496), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("f0015628-aa04-4cb3-949b-08ff1a4deaf9"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7474), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("f57f3668-b3d0-42f0-a79f-43846223aed0"), new DateTime(2024, 5, 14, 20, 30, 40, 137, DateTimeKind.Utc).AddTicks(7470), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketCards");

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("5bad5161-34f1-4b25-8c08-8b1251ec0a49"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ee5763b4-0842-487e-bdd2-4bfb86e18766"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("1bf40315-61db-417f-a5f1-5f639cf2ae56"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("7be500d4-f408-49e6-8c07-cdc4cd390617"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("91381d18-322c-4714-b906-7465b36bb29a"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("a5bb0cd3-d204-4714-b62d-f268aced1454"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("a667e9c2-61cc-4a76-912f-38061e3f3f7d"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("a93cdaf4-3958-4bde-b03f-911c239fa6a2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1e12523b-152c-4b2a-a0cb-101bf1321d14"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("89d0c8c4-a462-4431-b601-094cf286983d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a87c75fc-5be7-4403-bf3b-fae493036c7e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b09b7e06-c941-4d38-8cda-40445fe505e2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f0015628-aa04-4cb3-949b-08ff1a4deaf9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f57f3668-b3d0-42f0-a79f-43846223aed0"));

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0b8662d5-a929-47a3-9d45-369ef7f2d246"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4473), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null },
                    { new Guid("476f35d8-34da-406a-ab8a-71d51136f63c"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4484), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("23b5e3e3-293b-4ab2-85e5-30c7fba13998"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4407), false, "Action", null },
                    { new Guid("2ba1b4e3-bc22-43aa-b79a-a3ea24e4c1a6"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4418), false, "Strategy", null },
                    { new Guid("83a34fa6-1459-452f-adeb-077379b747d1"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4413), false, "Adventure", null },
                    { new Guid("b3aaa7e3-b319-46ca-bf35-ff1a3ccc64f4"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4426), false, "Platformer ", null },
                    { new Guid("d6974c2d-a939-4ebf-91ee-eea9848fbaa0"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4416), false, "Survival", null },
                    { new Guid("f719a7e4-7446-46dd-99e6-94fe57c2d986"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4420), false, "Shooter", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("106eced1-a698-4dc1-bd1c-a9cfac4b62ab"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4128), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("363cdc94-b983-45b8-a85a-6fdfb235abd1"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4114), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null },
                    { new Guid("5b4d0997-021d-4b30-87d8-26f43cd36f35"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4131), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("64be7c8b-fd1f-46a8-a2d1-5bfbd611bb9b"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4318), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("9c8bb37a-5f30-411c-8e8f-6e851b8fd35a"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4293), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("b9217e94-cbaf-4d40-857c-0bf98f3a0be2"), new DateTime(2024, 5, 14, 7, 29, 11, 661, DateTimeKind.Utc).AddTicks(4124), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null }
                });
        }
    }
}
