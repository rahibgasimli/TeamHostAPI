using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    public partial class mig16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserFriend");

            migrationBuilder.DropTable(
                name: "Friends");

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

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserFriendship",
                columns: table => new
                {
                    FriendsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FriendshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserFriendship", x => new { x.FriendsId, x.FriendshipsId });
                    table.ForeignKey(
                        name: "FK_AppUserFriendship_AspNetUsers_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserFriendship_Friendships_FriendshipsId",
                        column: x => x.FriendshipsId,
                        principalTable: "Friendships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ItemName", "PhotoPath", "Price", "UpdatedTime" },
                values: new object[] { new Guid("28fec8af-1160-4c7d-a284-5a54de4cb25e"), new DateTime(2024, 5, 27, 1, 2, 36, 676, DateTimeKind.Local).AddTicks(3849), false, "CS:GO", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 15.0, null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b6eb3d9-06a6-4b07-8cdc-58bed4219b17", "8d41dc81-6070-4eb0-b7f3-b100c5008fea", "User", "USER" },
                    { "971e3edc-1f29-4b95-b561-0fdb56826f38", "d3819e2f-c0b1-406b-bf75-60a4a7c5f50a", "None", "NONE" },
                    { "c27465a9-260e-4a25-b857-e1f9aa859fc7", "449f0989-3ab7-4158-86f9-0839fc59a277", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "BannerPhotos",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "PhotoPath", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("7ce9e710-8c63-42d8-9d8e-99033d100a68"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3809), false, "https://pro-theme.com/html/teamhost/assets/img/t2.jpg", null },
                    { new Guid("e15be664-e98e-41ed-abe5-d21093c0b3c3"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3797), false, "https://pro-theme.com/html/teamhost/assets/img/t1.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0476c786-2467-4c01-b622-3bcc03ee4b64"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3738), false, "Survival", null },
                    { new Guid("4023d419-0f62-4ee9-87fb-76bf44a835a5"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3743), false, "Shooter", null },
                    { new Guid("45905ed1-a10d-42c7-9053-c75b0dd25e48"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3740), false, "Strategy", null },
                    { new Guid("50159767-975b-4e77-adce-fc86b278c115"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3730), false, "Action", null },
                    { new Guid("72fecfdb-e9a8-4952-bda3-09f47f713dc5"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3736), false, "Adventure", null },
                    { new Guid("ee29d02e-49c5-4b5b-b9d6-643665ef8c13"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3747), false, "Platformer ", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "Reviews", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0cc10504-a53d-4b50-bc9d-49c3c9c11ceb"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3606), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Reckoning and Freedom", "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg", 49.990000000000002, 4.0999999999999996, null },
                    { new Guid("99616edf-3636-44ea-a2aa-06c3c945de71"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3600), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Struggle of Rivalry", "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg", 4.9900000000000002, 4.7999999999999998, null },
                    { new Guid("a44ce6c8-894c-44a1-89ee-9f55b29174f5"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3604), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Journey and Dimension", "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("aa78b2f0-d0bf-4bbd-8ac8-786a7146ff10"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3590), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Hunt of Duplicity", "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg", 9.9900000000000002, 4.5999999999999996, null },
                    { new Guid("adb645ef-3855-4e9f-9b2f-f47413aff453"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3609), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "Pillage of Redemption", "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg", 13.99, 4.7000000000000002, null },
                    { new Guid("e66dd685-60a2-4ac9-a7ee-bdebfd602d3f"), new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3634), "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.", false, "CS:GO", "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg", 12.99, 4.7999999999999998, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserFriendship_FriendshipsId",
                table: "AppUserFriendship",
                column: "FriendshipsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserFriendship");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("28fec8af-1160-4c7d-a284-5a54de4cb25e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b6eb3d9-06a6-4b07-8cdc-58bed4219b17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "971e3edc-1f29-4b95-b561-0fdb56826f38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c27465a9-260e-4a25-b857-e1f9aa859fc7");

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("7ce9e710-8c63-42d8-9d8e-99033d100a68"));

            migrationBuilder.DeleteData(
                table: "BannerPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e15be664-e98e-41ed-abe5-d21093c0b3c3"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("0476c786-2467-4c01-b622-3bcc03ee4b64"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("4023d419-0f62-4ee9-87fb-76bf44a835a5"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("45905ed1-a10d-42c7-9053-c75b0dd25e48"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("50159767-975b-4e77-adce-fc86b278c115"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("72fecfdb-e9a8-4952-bda3-09f47f713dc5"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("ee29d02e-49c5-4b5b-b9d6-643665ef8c13"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0cc10504-a53d-4b50-bc9d-49c3c9c11ceb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("99616edf-3636-44ea-a2aa-06c3c945de71"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a44ce6c8-894c-44a1-89ee-9f55b29174f5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("aa78b2f0-d0bf-4bbd-8ac8-786a7146ff10"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("adb645ef-3855-4e9f-9b2f-f47413aff453"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e66dd685-60a2-4ac9-a7ee-bdebfd602d3f"));

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pending = table.Column<int>(type: "int", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_AppUserFriend_UsersId",
                table: "AppUserFriend",
                column: "UsersId");
        }
    }
}
