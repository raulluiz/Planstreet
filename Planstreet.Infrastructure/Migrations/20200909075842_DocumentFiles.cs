using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Planstreet.Infrastructure.Migrations
{
    public partial class DocumentFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentFiles",
                columns: table => new
                {
                    FileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(maxLength: 100, nullable: true),
                    FileNameOnDisk = table.Column<string>(maxLength: 100, nullable: true),
                    FolderId = table.Column<int>(nullable: true),
                    DefaultFolderId = table.Column<int>(nullable: true),
                    ResourceId = table.Column<int>(nullable: true),
                    ContentType = table.Column<string>(maxLength: 500, nullable: true),
                    FilePath = table.Column<string>(maxLength: 500, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: true),
                    UpdationTime = table.Column<DateTime>(nullable: true),
                    Creator = table.Column<int>(nullable: true),
                    Updater = table.Column<int>(nullable: true),
                    RemoteHost = table.Column<string>(maxLength: 50, nullable: true),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFiles", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_DocumentFiles_DefaultFolder_DefaultFolderId",
                        column: x => x.DefaultFolderId,
                        principalTable: "DefaultFolder",
                        principalColumn: "DefaultFolderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentFiles_DocumentFolder_FolderId",
                        column: x => x.FolderId,
                        principalTable: "DocumentFolder",
                        principalColumn: "FolderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFiles_DefaultFolderId",
                table: "DocumentFiles",
                column: "DefaultFolderId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFiles_FolderId",
                table: "DocumentFiles",
                column: "FolderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentFiles");
        }
    }
}
