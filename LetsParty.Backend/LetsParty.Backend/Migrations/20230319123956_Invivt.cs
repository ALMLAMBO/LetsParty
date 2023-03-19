using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsParty.Backend.Migrations
{
    /// <inheritdoc />
    public partial class Invivt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_party_invites_Parties_PartyId",
                table: "party_invites");

            migrationBuilder.DropForeignKey(
                name: "FK_PartyUser_Parties_PartiesPartyId",
                table: "PartyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_PartyUser_Users_UsersUserId",
                table: "PartyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_party_invites_PartyInvitePartyId_PartyInviteOwnerId_PartyInviteReceiverId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PartyInvitePartyId_PartyInviteOwnerId_PartyInviteReceiverId",
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

            migrationBuilder.DropColumn(
                name: "PartyInviteOwnerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PartyInvitePartyId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PartyInviteReceiverId",
                table: "Users");

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

            migrationBuilder.AddForeignKey(
                name: "FK_party_invites_parties_PartyId",
                table: "party_invites",
                column: "PartyId",
                principalTable: "parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_party_invites_parties_PartyId",
                table: "party_invites");

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

            migrationBuilder.AddColumn<int>(
                name: "PartyInviteOwnerId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartyInvitePartyId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartyInviteReceiverId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_PartyInvitePartyId_PartyInviteOwnerId_PartyInviteReceiverId",
                table: "Users",
                columns: new[] { "PartyInvitePartyId", "PartyInviteOwnerId", "PartyInviteReceiverId" });

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
                name: "FK_party_invites_Parties_PartyId",
                table: "party_invites",
                column: "PartyId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_party_invites_PartyInvitePartyId_PartyInviteOwnerId_PartyInviteReceiverId",
                table: "Users",
                columns: new[] { "PartyInvitePartyId", "PartyInviteOwnerId", "PartyInviteReceiverId" },
                principalTable: "party_invites",
                principalColumns: new[] { "PartyId", "OwnerId", "ReceiverId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
