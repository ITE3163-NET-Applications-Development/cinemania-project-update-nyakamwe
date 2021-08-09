using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class InitialDbCreationAndDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 1, "A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.", "Action", "black_widow.jpg", new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 2, "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "Sci-Fi", "the_tomorrow_war.jpg", new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 3, "Beca, a freshman at Barden University, is cajoled into joining The Bellas, her school's all-girls singing group. Injecting some much needed energy into their repertoire, The Bellas take on their male rivals in a campus competition", "Comedy", "black_widow.jpg", new DateTime(2013, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pitch Perfect" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 4, "A family falls victim to a group of mutated cannibals in a desert far away from civilization.", "Horror", "hills_have_eyes.jpg", new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hills Have Eyes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 5, "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway", "Animation", "up.jpg", new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Up" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 6, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Crime", "pulp_fiction.jpg", new DateTime(1994, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 7, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] {"Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title"},
                values: new object[]
                {
                    8,
                    "Counterterrorism agent Jack Bauer fights the bad guys of the world, a day at a time. With each week's episode unfolding in real time, 24 covers a single day in the life of Bauer each season. Jack deals with assassination attempts, nuclear attacks, bioterrorism, torture, traitors, sleeper cells, other bad guys and the alarming tendency for his romances to end badly -- very badly.",
                    "Drama", "24-hours.jpg", new DateTime(2001, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 HOURS"
                });
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 9, "A genius level high school student makes money after developing elaborate methods to help other students cheat.", "Thriller Heist", "bad-genius.jpg", new DateTime(2017, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bad Genius" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 10, "Broken Vow is a 2012 Philippine television drama mystery series broadcast by GMA Network. Directed by Gil Tejada Jr., it stars Bianca King, Luis Alandy, Gabby Eigenmann and Rochelle Pangilinan. It premiered on February 6, 2012 on the network's Afternoon Prime line up replacing Kung Aagawin Mo ang Langit.", "Drama", "broken-vows.jpg", new DateTime(2012, 02, 06, 0, 0, 0, 0, DateTimeKind.Unspecified), "Broken Vows" });
   
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 11, "Carmen, 25, must flee Rio Muni, a Spanish colony in Africa, after having assassinated Victor, the son of the most powerful man in the region. In the hope of starting her life from scratch in Spain, she must leave behind Kiros, her great love and her family.", "Romantic", "deux-vies.jpg", new DateTime(2021, 01, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deux Vies" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 12, "Final Destination is an American horror franchise consisting of five films, two comic books, and nine novels. It is based on an unproduced spec script by Jeffrey Reddick, originally written for The X-Files television series, and was distributed by New Line Cinema.", "Mystery", "final_destination.jpg", new DateTime(2000, 01, 03, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Destination" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 13, " A Canadian romantic comedy film, directed by Alfons Adetuyi and released in 2018", "Romantic", "love_jacked.jpg", new DateTime(2018, 2, 08, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love Jacked" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 14, "An engineer installs himself in a prison he helped design, in order to save his falsely accused brother from a death sentence.", "Crime Drama", "prison-break.jpg", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prison Break" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 15, "A 2003 action beat 'em up developed by Vicarious Visions for the Game Boy Advance.", "Action", "return-of-legend.jpg", new DateTime(2003, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Return Of Legend" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 16, "An interpretation of the Superman story features young Clark Kent coming to grips with his emerging superpowers. He must hide his abilities from his friends, including Lana Lang, the girl of his dreams, and Lex Luthor, who will one day become Superman's nemesis. Complicating matters is the presence of kryptonite throughout Smallville, which causes strange mutations in locals and cripples Clark.", "Mystery Drama", "small-ville.jpg", new DateTime(2001, 10 , 16, 0, 0, 0, DateTimeKind.Unspecified), "Small Ville" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 17, "After being framed for his sister's murder, Alex is hell-bent on exacting revenge and finding the real culprit.", "Thriller", "who-killed-sara.jpg", new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Who Killed Sara?" });

}
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
