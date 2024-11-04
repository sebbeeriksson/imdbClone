using Hellow.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    internal static class Data
    {
        public static List<Series> seriesList = new List<Series>
        {
            new Series(1,"Breaking Bad"),
            new Series(2,"Game of Thrones"),
            new Series(3,"Stranger Things"),
            new Series(4,"The Office"),
        };

        public static List<Movie> movies = new List<Movie>
        {
            new Movie(1,"The Shawshank Redemption", 142),
            new Movie(2,"The Godfather", 175),
            new Movie(3,"The Dark Knight", 152),
            new Movie(4,"Pulp Fiction", 154),
        };

        public static List<Episode> listOfBreakingBadEpisodes = new List<Episode>
        {
            // Season 1
            new Episode(1,"Breaking Bad S01E01 - Pilot", 58, 1),
            new Episode(1,"Breaking Bad S01E02 - Cat's in the Bag", 48, 1),
            new Episode(1, "Breaking Bad S01E03 - ...And the Bag's in the River", 47, 1),
            new Episode(1, "Breaking Bad S01E04 - Cancer Man", 46, 1),
            new Episode(1, "Breaking Bad S01E05 - Gray Matter", 48, 1),

            // Season 2
            new Episode(1,  "Breaking Bad S02E01 - Seven Thirty-Seven", 47, 2),
            new Episode(1, "Breaking Bad S02E02 - Grilled", 46, 2),
            new Episode(1, "Breaking Bad S02E03 - Bit by a Dead Bee", 47, 2),
            new Episode(1, "Breaking Bad S02E04 - Down", 48, 2),
            new Episode(1, "Breaking Bad S02E05 - Breakage", 49, 2),

            // Season 3
            new Episode(1, "Breaking Bad S03E01 - No Mas", 47, 3),
            new Episode(1, "Breaking Bad S03E02 - Caballo Sin Nombre", 48, 3),
            new Episode(1, "Breaking Bad S03E03 - I.F.T.", 47, 3),
            new Episode(1, "Breaking Bad S03E04 - Green Light", 46, 3),
            new Episode(1, "Breaking Bad S03E05 - Mas", 49, 3),
        };

        public static List<Episode> listOfGameOfThronesEpisodes = new List<Episode>
        {
            // Season 1
            new Episode(2,  "Game of Thrones S01E01 - Winter Is Coming", 62, 1),
            new Episode(2,   "Game of Thrones S01E02 - The Kingsroad", 56, 1),
            new Episode(2,"Game of Thrones S01E03 - Lord Snow", 58, 1),
            new Episode(2,"Game of Thrones S01E04 - Cripples, Bastards, and Broken Things", 56, 1),
            new Episode(2, "Game of Thrones S01E05 - The Wolf and the Lion", 55, 1),

            // Season 2
            new Episode(2, "Game of Thrones S02E01 - The North Remembers", 53, 2),
            new Episode(2, "Game of Thrones S02E02 - The Night Lands", 54, 2),
            new Episode(2, "Game of Thrones S02E03 - What Is Dead May Never Die", 53, 2),
            new Episode(2, "Game of Thrones S02E04 - Garden of Bones", 50, 2),
            new Episode(2, "Game of Thrones S02E05 - The Ghost of Harrenhal", 56, 2),

            // Season 3
            new Episode(2, "Game of Thrones S03E01 - Valar Dohaeris", 58, 3),
            new Episode(2, "Game of Thrones S03E02 - Dark Wings, Dark Words", 57, 3),
            new Episode(2, "Game of Thrones S03E03 - Walk of Punishment", 54, 3),
            new Episode(2, "Game of Thrones S03E04 - And Now His Watch Is Ended", 57, 3),
            new Episode(2, "Game of Thrones S03E05 - Kissed by Fire", 57, 3),
        };

        public static List<Episode> listOfStrangerThingsEpisodes = new List<Episode>
        {
            // Season 1
            new Episode(3,"Stranger Things S01E01 - The Vanishing of Will Byers", 47, 1),
            new Episode(3, "Stranger Things S01E02 - The Weirdo on Maple Street", 55, 1),
            new Episode(3,  "Stranger Things S01E03 - Holly, Jolly", 51, 1),
            new Episode(3,"Stranger Things S01E04 - The Body", 50, 1),
            new Episode(3,"Stranger Things S01E05 - The Flea and the Acrobat", 45, 1),

            // Season 2
            new Episode(3,"Stranger Things S02E01 - MADMAX", 48, 2),
            new Episode(3,"Stranger Things S02E02 - Trick or Treat, Freak", 56, 2),
            new Episode(3,"Stranger Things S02E03 - The Pollywog", 50, 2),
            new Episode(3,"Stranger Things S02E04 - Will the Wise", 46, 2),
            new Episode(3,"Stranger Things S02E05 - Dig Dug", 49, 2),

            // Season 3
            new Episode(3,"Stranger Things S03E01 - Suzie, Do You Copy?", 51, 3),
            new Episode(3,"Stranger Things S03E02 - The Mall Rats", 50, 3),
            new Episode(3,"Stranger Things S03E03 - The Case of the Missing Lifeguard", 47, 3),
            new Episode(3,"Stranger Things S03E04 - The Sauna Test", 52, 3),
            new Episode(3,"Stranger Things S03E05 - The Flayed", 53, 3),
        };

        public static List<Episode> listOfTheOfficeEpisodes = new List<Episode>
        {
            // Season 1
            new Episode(4,"The Office S01E01 - Pilot", 23, 1),
            new Episode(4,"The Office S01E02 - Diversity Day", 22, 1),
            new Episode(4,"The Office S01E03 - Health Care", 22, 1),
            new Episode(4,"The Office S01E04 - The Alliance", 21, 1),
            new Episode(4,"The Office S01E05 - Basketball", 22, 1),

            // Season 2
            new Episode(4,"The Office S02E01 - The Dundies", 28, 2),
            new Episode(4,"The Office S02E02 - Sexual Harassment", 22, 2),
            new Episode(4,"The Office S02E03 - Office Olympics", 23, 2),
            new Episode(4,"The Office S02E04 - The Fire", 22, 2),
            new Episode(4,"The Office S02E05 - Halloween", 22, 2),

            // Season 3
            new Episode(4,"The Office S03E01 - Gay Witch Hunt", 22, 3),
            new Episode(4,"The Office S03E02 - The Convention", 21, 3),
            new Episode(4,"The Office S03E03 - The Coup", 22, 3),
            new Episode(4,"The Office S03E04 - Grief Counseling", 21, 3),
            new Episode(4,"The Office S03E05 - Initiation", 22, 3),
        };
    }
}
