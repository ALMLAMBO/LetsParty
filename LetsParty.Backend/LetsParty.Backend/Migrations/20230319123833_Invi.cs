using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsParty.Backend.Migrations
{
    /// <inheritdoc />
    public partial class Invi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartyInv");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_PartyInvitePartyId_PartyInviteOwnerId_PartyInviteReceiverId",
                table: "Users",
                columns: new[] { "PartyInvitePartyId", "PartyInviteOwnerId", "PartyInviteReceiverId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_party_invites_PartyInvitePartyId_PartyInviteOwnerId_PartyInviteReceiverId",
                table: "Users",
                columns: new[] { "PartyInvitePartyId", "PartyInviteOwnerId", "PartyInviteReceiverId" },
                principalTable: "party_invites",
                principalColumns: new[] { "PartyId", "OwnerId", "ReceiverId" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_party_invites_PartyInvitePartyId_PartyInviteOwnerId_PartyInviteReceiverId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PartyInvitePartyId_PartyInviteOwnerId_PartyInviteReceiverId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PartyInviteOwnerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PartyInvitePartyId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PartyInviteReceiverId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "PartyInv",
                columns: table => new
                {
                    UsersUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartyInvitesPartyId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartyInvitesOwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartyInvitesReceiverId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyInv", x => new { x.UsersUserId, x.PartyInvitesPartyId, x.PartyInvitesOwnerId, x.PartyInvitesReceiverId });
                    table.ForeignKey(
                        name: "FK_PartyInv_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartyInv_party_invites_PartyInvitesPartyId_PartyInvitesOwnerId_PartyInvitesReceiverId",
                        columns: x => new { x.PartyInvitesPartyId, x.PartyInvitesOwnerId, x.PartyInvitesReceiverId },
                        principalTable: "party_invites",
                        principalColumns: new[] { "PartyId", "OwnerId", "ReceiverId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartyInv_PartyInvitesPartyId_PartyInvitesOwnerId_PartyInvitesReceiverId",
                table: "PartyInv",
                columns: new[] { "PartyInvitesPartyId", "PartyInvitesOwnerId", "PartyInvitesReceiverId" });
        }
    }
}
