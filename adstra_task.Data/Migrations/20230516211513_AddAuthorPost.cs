using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace adstra_task.Data.Migrations
{
    public partial class AddAuthorPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authorPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    postAuthorPost = table.Column<string>(nullable: false),
                    PostTitle = table.Column<string>(nullable: false),
                    PostDescraption = table.Column<string>(nullable: false),
                    PostImageUrl = table.Column<string>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    AuthorsId = table.Column<int>(nullable: true),
                    AuthorPostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authorPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_authorPosts_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_authorPosts_authorPosts_AuthorPostId",
                        column: x => x.AuthorPostId,
                        principalTable: "authorPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_authorPosts_AuthorsId",
                table: "authorPosts",
                column: "AuthorsId");

            migrationBuilder.CreateIndex(
                name: "IX_authorPosts_AuthorPostId",
                table: "authorPosts",
                column: "AuthorPostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "authorPosts");
        }
    }
}
