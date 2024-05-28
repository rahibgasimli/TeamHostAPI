using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<double>(
                name: "Wallet",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesAppUser",
                columns: table => new
                {
                    ActivitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesAppUser", x => new { x.ActivitiesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ActivitiesAppUser_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitiesAppUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesAppUser_UserId",
                table: "ActivitiesAppUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesAppUser");

            migrationBuilder.DropTable(
                name: "Activities");

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

            migrationBuilder.DropColumn(
                name: "Wallet",
                table: "AspNetUsers");

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
        }
    }
}
