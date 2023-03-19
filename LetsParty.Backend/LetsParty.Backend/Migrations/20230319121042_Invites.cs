using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsParty.Backend.Migrations
{
    /// <inheritdoc />
    public partial class Invites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartiesGames_games_GamesGameId",
                table: "PartiesGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiesGames_parties_PartiesPartyId",
                table: "PartiesGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiesItems_items_ItemsItemId",
                table: "PartiesItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiesItems_parties_PartiesPartyId",
                table: "PartiesItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiesLocations_Locations_LocationsLocationId",
                table: "PartiesLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiesLocations_parties_PartiesPartyId",
                table: "PartiesLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiesUsers_parties_PartiesPartyId",
                table: "PartiesUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiesUsers_users_UsersUserId",
                table: "PartiesUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_parties",
                table: "parties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_items",
                table: "items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_games",
                table: "games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartiesUsers",
                table: "PartiesUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartiesLocations",
                table: "PartiesLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartiesItems",
                table: "PartiesItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartiesGames",
                table: "PartiesGames");

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "parties",
                newName: "Parties");

            migrationBuilder.RenameTable(
                name: "items",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "games",
                newName: "Games");

            migrationBuilder.RenameTable(
                name: "PartiesUsers",
                newName: "PartyUser");

            migrationBuilder.RenameTable(
                name: "PartiesLocations",
                newName: "LocationParty");

            migrationBuilder.RenameTable(
                name: "PartiesItems",
                newName: "ItemParty");

            migrationBuilder.RenameTable(
                name: "PartiesGames",
                newName: "GameParty");

            migrationBuilder.RenameIndex(
                name: "IX_PartiesUsers_UsersUserId",
                table: "PartyUser",
                newName: "IX_PartyUser_UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_PartiesLocations_PartiesPartyId",
                table: "LocationParty",
                newName: "IX_LocationParty_PartiesPartyId");

            migrationBuilder.RenameIndex(
                name: "IX_PartiesItems_PartiesPartyId",
                table: "ItemParty",
                newName: "IX_ItemParty_PartiesPartyId");

            migrationBuilder.RenameIndex(
                name: "IX_PartiesGames_PartiesPartyId",
                table: "GameParty",
                newName: "IX_GameParty_PartiesPartyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parties",
                table: "Parties",
                column: "PartyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartyUser",
                table: "PartyUser",
                columns: new[] { "PartiesPartyId", "UsersUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationParty",
                table: "LocationParty",
                columns: new[] { "LocationsLocationId", "PartiesPartyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemParty",
                table: "ItemParty",
                columns: new[] { "ItemsItemId", "PartiesPartyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameParty",
                table: "GameParty",
                columns: new[] { "GamesGameId", "PartiesPartyId" });

            migrationBuilder.CreateTable(
                name: "party_invites",
                columns: table => new
                {
                    PartyId = table.Column<int>(type: "INTEGER", nullable: false),
                    OwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceiverId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_party_invites", x => new { x.PartyId, x.OwnerId });
                });

            migrationBuilder.CreateTable(
                name: "PartiesInvites",
                columns: table => new
                {
                    UsersUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartyInvitesPartyId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartyInvitesOwnerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiesInvites", x => new { x.UsersUserId, x.PartyInvitesPartyId, x.PartyInvitesOwnerId });
                    table.ForeignKey(
                        name: "FK_PartiesInvites_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartiesInvites_party_invites_PartyInvitesPartyId_PartyInvitesOwnerId",
                        columns: x => new { x.PartyInvitesPartyId, x.PartyInvitesOwnerId },
                        principalTable: "party_invites",
                        principalColumns: new[] { "PartyId", "OwnerId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartiesInvs",
                columns: table => new
                {
                    PartiesPartyId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartyInvitesPartyId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartyInvitesOwnerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiesInvs", x => new { x.PartiesPartyId, x.PartyInvitesPartyId, x.PartyInvitesOwnerId });
                    table.ForeignKey(
                        name: "FK_PartiesInvs_Parties_PartiesPartyId",
                        column: x => x.PartiesPartyId,
                        principalTable: "Parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartiesInvs_party_invites_PartyInvitesPartyId_PartyInvitesOwnerId",
                        columns: x => new { x.PartyInvitesPartyId, x.PartyInvitesOwnerId },
                        principalTable: "party_invites",
                        principalColumns: new[] { "PartyId", "OwnerId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartiesInvites_PartyInvitesPartyId_PartyInvitesOwnerId",
                table: "PartiesInvites",
                columns: new[] { "PartyInvitesPartyId", "PartyInvitesOwnerId" });

            migrationBuilder.CreateIndex(
                name: "IX_PartiesInvs_PartyInvitesPartyId_PartyInvitesOwnerId",
                table: "PartiesInvs",
                columns: new[] { "PartyInvitesPartyId", "PartyInvitesOwnerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_GameParty_Games_GamesGameId",
                table: "GameParty",
                column: "GamesGameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameParty_Parties_PartiesPartyId",
                table: "GameParty",
                column: "PartiesPartyId",
                principalTable: "Parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemParty_Items_ItemsItemId",
                table: "ItemParty",
                column: "ItemsItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemParty_Parties_PartiesPartyId",
                table: "ItemParty",
                column: "PartiesPartyId",
                principalTable: "Parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationParty_Locations_LocationsLocationId",
                table: "LocationParty",
                column: "LocationsLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationParty_Parties_PartiesPartyId",
                table: "LocationParty",
                column: "PartiesPartyId",
                principalTable: "Parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartyUser_Parties_PartiesPartyId",
                table: "PartyUser",
                column: "PartiesPartyId",
                principalTable: "Parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartyUser_Users_UsersUserId",
                table: "PartyUser",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameParty_Games_GamesGameId",
                table: "GameParty");

            migrationBuilder.DropForeignKey(
                name: "FK_GameParty_Parties_PartiesPartyId",
                table: "GameParty");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemParty_Items_ItemsItemId",
                table: "ItemParty");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemParty_Parties_PartiesPartyId",
                table: "ItemParty");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationParty_Locations_LocationsLocationId",
                table: "LocationParty");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationParty_Parties_PartiesPartyId",
                table: "LocationParty");

            migrationBuilder.DropForeignKey(
                name: "FK_PartyUser_Parties_PartiesPartyId",
                table: "PartyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_PartyUser_Users_UsersUserId",
                table: "PartyUser");

            migrationBuilder.DropTable(
                name: "PartiesInvites");

            migrationBuilder.DropTable(
                name: "PartiesInvs");

            migrationBuilder.DropTable(
                name: "party_invites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parties",
                table: "Parties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartyUser",
                table: "PartyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationParty",
                table: "LocationParty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemParty",
                table: "ItemParty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameParty",
                table: "GameParty");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Parties",
                newName: "parties");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "items");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "games");

            migrationBuilder.RenameTable(
                name: "PartyUser",
                newName: "PartiesUsers");

            migrationBuilder.RenameTable(
                name: "LocationParty",
                newName: "PartiesLocations");

            migrationBuilder.RenameTable(
                name: "ItemParty",
                newName: "PartiesItems");

            migrationBuilder.RenameTable(
                name: "GameParty",
                newName: "PartiesGames");

            migrationBuilder.RenameIndex(
                name: "IX_PartyUser_UsersUserId",
                table: "PartiesUsers",
                newName: "IX_PartiesUsers_UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_LocationParty_PartiesPartyId",
                table: "PartiesLocations",
                newName: "IX_PartiesLocations_PartiesPartyId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemParty_PartiesPartyId",
                table: "PartiesItems",
                newName: "IX_PartiesItems_PartiesPartyId");

            migrationBuilder.RenameIndex(
                name: "IX_GameParty_PartiesPartyId",
                table: "PartiesGames",
                newName: "IX_PartiesGames_PartiesPartyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_parties",
                table: "parties",
                column: "PartyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_items",
                table: "items",
                column: "ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_games",
                table: "games",
                column: "GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartiesUsers",
                table: "PartiesUsers",
                columns: new[] { "PartiesPartyId", "UsersUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartiesLocations",
                table: "PartiesLocations",
                columns: new[] { "LocationsLocationId", "PartiesPartyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartiesItems",
                table: "PartiesItems",
                columns: new[] { "ItemsItemId", "PartiesPartyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartiesGames",
                table: "PartiesGames",
                columns: new[] { "GamesGameId", "PartiesPartyId" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 1, "test@test.com", "test", "test", "test1234", "test" });

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesGames_games_GamesGameId",
                table: "PartiesGames",
                column: "GamesGameId",
                principalTable: "games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesGames_parties_PartiesPartyId",
                table: "PartiesGames",
                column: "PartiesPartyId",
                principalTable: "parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesItems_items_ItemsItemId",
                table: "PartiesItems",
                column: "ItemsItemId",
                principalTable: "items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesItems_parties_PartiesPartyId",
                table: "PartiesItems",
                column: "PartiesPartyId",
                principalTable: "parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesLocations_Locations_LocationsLocationId",
                table: "PartiesLocations",
                column: "LocationsLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesLocations_parties_PartiesPartyId",
                table: "PartiesLocations",
                column: "PartiesPartyId",
                principalTable: "parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesUsers_parties_PartiesPartyId",
                table: "PartiesUsers",
                column: "PartiesPartyId",
                principalTable: "parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesUsers_users_UsersUserId",
                table: "PartiesUsers",
                column: "UsersUserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
