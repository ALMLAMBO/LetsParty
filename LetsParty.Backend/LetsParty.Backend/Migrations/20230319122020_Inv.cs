using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsParty.Backend.Migrations
{
    /// <inheritdoc />
    public partial class Inv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartiesInvites_Users_UsersUserId",
                table: "PartiesInvites");

            migrationBuilder.DropForeignKey(
                name: "FK_PartiesInvites_party_invites_PartyInvitesPartyId_PartyInvitesOwnerId",
                table: "PartiesInvites");

            migrationBuilder.DropTable(
                name: "PartiesInvs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_party_invites",
                table: "party_invites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartiesInvites",
                table: "PartiesInvites");

            migrationBuilder.DropIndex(
                name: "IX_PartiesInvites_PartyInvitesPartyId_PartyInvitesOwnerId",
                table: "PartiesInvites");

            migrationBuilder.RenameTable(
                name: "PartiesInvites",
                newName: "PartyInv");

            migrationBuilder.AddColumn<int>(
                name: "PartyInvitesReceiverId",
                table: "PartyInv",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_party_invites",
                table: "party_invites",
                columns: new[] { "PartyId", "OwnerId", "ReceiverId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartyInv",
                table: "PartyInv",
                columns: new[] { "UsersUserId", "PartyInvitesPartyId", "PartyInvitesOwnerId", "PartyInvitesReceiverId" });

            migrationBuilder.CreateIndex(
                name: "IX_PartyInv_PartyInvitesPartyId_PartyInvitesOwnerId_PartyInvitesReceiverId",
                table: "PartyInv",
                columns: new[] { "PartyInvitesPartyId", "PartyInvitesOwnerId", "PartyInvitesReceiverId" });

            migrationBuilder.AddForeignKey(
                name: "FK_party_invites_Parties_PartyId",
                table: "party_invites",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartyInv_Users_UsersUserId",
                table: "PartyInv",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartyInv_party_invites_PartyInvitesPartyId_PartyInvitesOwnerId_PartyInvitesReceiverId",
                table: "PartyInv",
                columns: new[] { "PartyInvitesPartyId", "PartyInvitesOwnerId", "PartyInvitesReceiverId" },
                principalTable: "party_invites",
                principalColumns: new[] { "PartyId", "OwnerId", "ReceiverId" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_party_invites_Parties_PartyId",
                table: "party_invites");

            migrationBuilder.DropForeignKey(
                name: "FK_PartyInv_Users_UsersUserId",
                table: "PartyInv");

            migrationBuilder.DropForeignKey(
                name: "FK_PartyInv_party_invites_PartyInvitesPartyId_PartyInvitesOwnerId_PartyInvitesReceiverId",
                table: "PartyInv");

            migrationBuilder.DropPrimaryKey(
                name: "PK_party_invites",
                table: "party_invites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartyInv",
                table: "PartyInv");

            migrationBuilder.DropIndex(
                name: "IX_PartyInv_PartyInvitesPartyId_PartyInvitesOwnerId_PartyInvitesReceiverId",
                table: "PartyInv");

            migrationBuilder.DropColumn(
                name: "PartyInvitesReceiverId",
                table: "PartyInv");

            migrationBuilder.RenameTable(
                name: "PartyInv",
                newName: "PartiesInvites");

            migrationBuilder.AddPrimaryKey(
                name: "PK_party_invites",
                table: "party_invites",
                columns: new[] { "PartyId", "OwnerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartiesInvites",
                table: "PartiesInvites",
                columns: new[] { "UsersUserId", "PartyInvitesPartyId", "PartyInvitesOwnerId" });

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
                name: "FK_PartiesInvites_Users_UsersUserId",
                table: "PartiesInvites",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartiesInvites_party_invites_PartyInvitesPartyId_PartyInvitesOwnerId",
                table: "PartiesInvites",
                columns: new[] { "PartyInvitesPartyId", "PartyInvitesOwnerId" },
                principalTable: "party_invites",
                principalColumns: new[] { "PartyId", "OwnerId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
