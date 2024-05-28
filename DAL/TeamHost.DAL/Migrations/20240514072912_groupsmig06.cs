using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class groupsmig06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "GroupsTables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post = table.Column<byte>(type: "tinyint", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserGroupsEntity",
                columns: table => new
                {
                    GroupsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MembersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserGroupsEntity", x => new { x.GroupsId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_AppUserGroupsEntity_AspNetUsers_MembersId",
                        column: x => x.MembersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserGroupsEntity_GroupsTables_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "GroupsTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AppUserGroupsEntity_MembersId",
                table: "AppUserGroupsEntity",
                column: "MembersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserGroupsEntity");

            migrationBuilder.DropTable(
                name: "GroupsTables");

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
    }
}
