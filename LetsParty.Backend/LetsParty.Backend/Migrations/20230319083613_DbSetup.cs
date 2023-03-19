using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsParty.Backend.Migrations
{
    /// <inheritdoc />
    public partial class DbSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Locations",
                newName: "LocationId");

            migrationBuilder.CreateTable(
                name: "games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfPlayers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "parties",
                columns: table => new
                {
                    PartyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPrivate = table.Column<bool>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    Limit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parties", x => x.PartyId);
                });

            migrationBuilder.CreateTable(
                name: "PartiesGames",
                columns: table => new
                {
                    GamesGameId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartiesPartyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiesGames", x => new { x.GamesGameId, x.PartiesPartyId });
                    table.ForeignKey(
                        name: "FK_PartiesGames_games_GamesGameId",
                        column: x => x.GamesGameId,
                        principalTable: "games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartiesGames_parties_PartiesPartyId",
                        column: x => x.PartiesPartyId,
                        principalTable: "parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartiesItems",
                columns: table => new
                {
                    ItemsItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartiesPartyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiesItems", x => new { x.ItemsItemId, x.PartiesPartyId });
                    table.ForeignKey(
                        name: "FK_PartiesItems_items_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartiesItems_parties_PartiesPartyId",
                        column: x => x.PartiesPartyId,
                        principalTable: "parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartiesLocations",
                columns: table => new
                {
                    LocationsLocationId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartiesPartyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiesLocations", x => new { x.LocationsLocationId, x.PartiesPartyId });
                    table.ForeignKey(
                        name: "FK_PartiesLocations_Locations_LocationsLocationId",
                        column: x => x.LocationsLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartiesLocations_parties_PartiesPartyId",
                        column: x => x.PartiesPartyId,
                        principalTable: "parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartiesUsers",
                columns: table => new
                {
                    PartiesPartyId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartiesUsers", x => new { x.PartiesPartyId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_PartiesUsers_parties_PartiesPartyId",
                        column: x => x.PartiesPartyId,
                        principalTable: "parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartiesUsers_users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartiesGames_PartiesPartyId",
                table: "PartiesGames",
                column: "PartiesPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PartiesItems_PartiesPartyId",
                table: "PartiesItems",
                column: "PartiesPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PartiesLocations_PartiesPartyId",
                table: "PartiesLocations",
                column: "PartiesPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PartiesUsers_UsersUserId",
                table: "PartiesUsers",
                column: "UsersUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartiesGames");

            migrationBuilder.DropTable(
                name: "PartiesItems");

            migrationBuilder.DropTable(
                name: "PartiesLocations");

            migrationBuilder.DropTable(
                name: "PartiesUsers");

            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "parties");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Locations",
                newName: "Id");
        }
    }
}
