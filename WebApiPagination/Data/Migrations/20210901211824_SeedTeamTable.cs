using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiPagination.Data.Migrations
{
    public partial class SeedTeamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Name", "Slug" },
                values: new object[,]
                {
                    { 1610610023L, "Packers", "Anderson", "" },
                    { 1610612746L, "Clippers", "LA", "clippers" },
                    { 1610612747L, "Lakers", "Los Angeles", "lakers" },
                    { 1610612748L, "Heat", "Miami", "heat" },
                    { 1610612749L, "Bucks", "Milwaukee", "bucks" },
                    { 1610612750L, "Timberwolves", "Minnesota", "timberwolves" },
                    { 1610612751L, "Nets", "Brooklyn", "nets" },
                    { 1610612752L, "Knicks", "New York", "knicks" },
                    { 1610612753L, "Magic", "Orlando", "magic" },
                    { 1610612754L, "Pacers", "Indiana", "pacers" },
                    { 1610612755L, "76ers", "Philadelphia", "sixers" },
                    { 1610612756L, "Suns", "Phoenix", "suns" },
                    { 1610612757L, "Trail Blazers", "Portland", "blazers" },
                    { 1610612758L, "Kings", "Sacramento", "kings" },
                    { 1610612759L, "Spurs", "San Antonio", "spurs" },
                    { 1610612760L, "Thunder", "Oklahoma City", "thunder" },
                    { 1610612761L, "Raptors", "Toronto", "raptors" },
                    { 1610612762L, "Jazz", "Utah", "jazz" },
                    { 1610612763L, "Grizzlies", "Memphis", "grizzlies" },
                    { 1610612764L, "Wizards", "Washington", "wizards" },
                    { 1610612745L, "Rockets", "Houston", "rockets" },
                    { 1610612765L, "Pistons", "Detroit", "pistons" },
                    { 1610612744L, "Warriors", "Golden State", "warriors" },
                    { 1610612742L, "Mavericks", "Dallas", "mavericks" },
                    { 1610610024L, "Bullets", "Baltimore", "" },
                    { 1610610025L, "Stags", "Chicago", "" },
                    { 1610610026L, "Rebels", "Cleveland", "" },
                    { 1610610027L, "Nuggets", "Denver", "" },
                    { 1610610028L, "Falcons", "Detroit", "" },
                    { 1610610029L, "Jets", "Indianapolis", "" },
                    { 1610610030L, "Olympians", "Indianapolis", "" },
                    { 1610610031L, "Ironmen", "Pittsburgh", "" },
                    { 1610610032L, "Steamrollers", "Providence", "" },
                    { 1610610033L, "Redskins", "Sheboygan", "" },
                    { 1610610034L, "Bombers", "St. Louis", "" },
                    { 1610610035L, "Huskies", "Toronto", "" },
                    { 1610610036L, "Capitols", "Washington", "" },
                    { 1610610037L, "Hawks", "Waterloo", "" },
                    { 1610612737L, "Hawks", "Atlanta", "hawks" },
                    { 1610612738L, "Celtics", "Boston", "celtics" },
                    { 1610612739L, "Cavaliers", "Cleveland", "cavaliers" },
                    { 1610612740L, "Pelicans", "New Orleans", "pelicans" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Name", "Slug" },
                values: new object[] { 1610612741L, "Bulls", "Chicago", "bulls" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Name", "Slug" },
                values: new object[] { 1610612743L, "Nuggets", "Denver", "nuggets" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Name", "Slug" },
                values: new object[] { 1610612766L, "Hornets", "Charlotte", "hornets" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610023L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610024L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610025L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610026L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610027L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610028L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610029L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610030L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610031L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610032L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610033L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610034L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610035L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610036L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610610037L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612737L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612738L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612739L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612740L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612741L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612742L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612743L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612744L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612745L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612746L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612747L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612748L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612749L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612750L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612751L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612752L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612753L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612754L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612755L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612756L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612757L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612758L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612759L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612760L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612761L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612762L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612763L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612764L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612765L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1610612766L);
        }
    }
}
