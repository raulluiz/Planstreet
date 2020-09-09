using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Planstreet.Infrastructure.Migrations
{
    public partial class DocumentFolder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentFolder",
                columns: table => new
                {
                    FolderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caption = table.Column<string>(maxLength: 100, nullable: true),
                    ParentFolderId = table.Column<int>(nullable: true),
                    ResourceId = table.Column<int>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: true),
                    UpdationTime = table.Column<DateTime>(nullable: true),
                    Creator = table.Column<int>(nullable: true),
                    Updater = table.Column<int>(nullable: true),
                    RemoteHost = table.Column<string>(maxLength: 50, nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    FolderSize = table.Column<string>(maxLength: 50, nullable: true),
                    DefaultFolderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFolder", x => x.FolderId);
                    table.ForeignKey(
                        name: "FK_DocumentFolder_DefaultFolder_DefaultFolderId",
                        column: x => x.DefaultFolderId,
                        principalTable: "DefaultFolder",
                        principalColumn: "DefaultFolderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFolder_DefaultFolderId",
                table: "DocumentFolder",
                column: "DefaultFolderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentFolder");
        }
    }
}
