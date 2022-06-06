using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSongs.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumName", "Author", "Length", "Title" },
                values: new object[,]
                {
                    { new Guid("0ab73d2b-ab53-438f-8217-79a9bac414dd"), "Nevermind", "Nirvana", 5.0199999999999996, "Smells Like Teen Spirit" },
                    { new Guid("4a4a0c57-1ac5-4a6b-b4da-ed03732441e7"), "Ray of Light", "Madonna", 6.2000000000000002, "Frozen" },
                    { new Guid("8e529ff2-111b-4655-b956-e8cde2bd3946"), "HIStory: Past, Present and Future, Book I", "Michael Jackson", 6.9199999999999999, "Earth Song" },
                    { new Guid("a5228fde-ac2e-4c14-8219-ddc33485b472"), "Imagine", "John Lennon", 3.0499999999999998, "Imagine" },
                    { new Guid("d94cf4a0-6287-485d-896b-8e351b66e3c7"), "A Night at the Opera", "Queen", 5.9199999999999999, "Bohemian Rhapsody" },
                    { new Guid("fcad7381-12d8-4993-a466-17312bbe77d2"), "Help!", "The Beatles", 2.0499999999999998, "Yesterday" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
