using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Request = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserFriend",
                columns: table => new
                {
                    FriendsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserFriend", x => new { x.FriendsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AppUserFriend_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserFriend_Friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "Friends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("23cb94d0-813f-4482-8d47-2d061149d74d"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4691), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null },
                    { new Guid("f59e242d-5811-4a23-8b99-783c700a516d"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4686), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0ecae2aa-d7a9-43ab-afbf-8ec7a19f11c5"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4629), false, "Adventure", null },
                    { new Guid("16a24b16-0183-49ff-9f87-78668fa7bbbb"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4644), false, "Platformer ", null },
                    { new Guid("69114181-00bc-4cc1-b79c-7bebf1ce1143"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4624), false, "Action", null },
                    { new Guid("78bf9077-28ec-4f00-aee9-cdb9d60bb711"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4641), false, "Shooter", null },
                    { new Guid("7dcaa73f-66dd-4fed-98d5-b0a8f2b6a379"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4633), false, "Strategy", null },
                    { new Guid("95da1490-4853-4f23-9f06-6039b32260ba"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4631), false, "Survival", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1553a37a-d34a-47fc-b99e-0a8009f9a4a2"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4505), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null },
                    { new Guid("626040cb-6a88-42e4-8a09-90ab360fd185"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4536), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("68d82063-e22e-4b8d-b9a0-5c9fbc6f5cdd"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4544), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null },
                    { new Guid("c3c5c3ef-d272-4968-b90d-3c8b4c09215d"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4533), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("ce657291-48b2-4e77-9eba-6ba124078d1e"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4538), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("eae0e592-1b67-4fdd-a236-3b3341c89bd6"), new DateTime(2024, 5, 17, 20, 20, 57, 551, DateTimeKind.Utc).AddTicks(4516), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserFriend_UsersId",
                table: "AppUserFriend",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserFriend");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("23cb94d0-813f-4482-8d47-2d061149d74d"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f59e242d-5811-4a23-8b99-783c700a516d"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("0ecae2aa-d7a9-43ab-afbf-8ec7a19f11c5"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("16a24b16-0183-49ff-9f87-78668fa7bbbb"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("69114181-00bc-4cc1-b79c-7bebf1ce1143"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("78bf9077-28ec-4f00-aee9-cdb9d60bb711"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("7dcaa73f-66dd-4fed-98d5-b0a8f2b6a379"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("95da1490-4853-4f23-9f06-6039b32260ba"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1553a37a-d34a-47fc-b99e-0a8009f9a4a2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("626040cb-6a88-42e4-8a09-90ab360fd185"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("68d82063-e22e-4b8d-b9a0-5c9fbc6f5cdd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c3c5c3ef-d272-4968-b90d-3c8b4c09215d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ce657291-48b2-4e77-9eba-6ba124078d1e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("eae0e592-1b67-4fdd-a236-3b3341c89bd6"));

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
    }
}
