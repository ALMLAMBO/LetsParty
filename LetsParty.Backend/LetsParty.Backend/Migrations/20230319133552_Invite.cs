using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsParty.Backend.Migrations
{
    /// <inheritdoc />
    public partial class Invite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    table.PrimaryKey("PK_party_invites", x => new { x.PartyId, x.OwnerId, x.ReceiverId });
                    table.ForeignKey(
                        name: "FK_party_invites_parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "party_invites");
        }
    }
}
