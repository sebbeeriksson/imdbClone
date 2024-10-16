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
                new Series("Breaking Bad"),
                new Series("Game of Thrones"),
                new Series("Stranger Things"),
                new Series("The Office"),
                new Series("Friends"),
                new Series("The Mandalorian"),
                new Series("The Witcher"),
                new Series("The Crown"),
                new Series("The Boys"),
                new Series("Chernobyl"),
                new Series("The Umbrella Academy"),
                new Series("Peaky Blinders"),
                new Series("Sherlock"),
                new Series("Narcos"),
                new Series("Money Heist"),
                new Series("The Walking Dead"),
                new Series("House of Cards"),
                new Series("Westworld"),
                new Series("Better Call Saul"),
                new Series("The Queen's Gambit"),
                new Series("Lucifer"),
                new Series("The Handmaid's Tale"),
                new Series("Black Mirror"),
                new Series("The Flash"),
                new Series("Arrow"),
                new Series("Fargo"),
                new Series("True Detective"),
                new Series("Supernatural"),
                new Series("Rick and Morty"),
                new Series("Vikings"),
                new Series("Brooklyn Nine-Nine"),
                new Series("BoJack Horseman"),
                new Series("The Expanse"),
                new Series("Mr. Robot"),
                new Series("The Good Place"),
                new Series("Homeland"),
                new Series("How I Met Your Mother"),
                new Series("The Simpsons"),
                new Series("Grey's Anatomy"),
                new Series("Lost"),
                new Series("24"),
                new Series("Prison Break"),
                new Series("Dexter"),
                new Series("Smallville")
            };
       public static List<Movie> movies = new List<Movie>
            {
                new Movie("The Shawshank Redemption", 142),
                new Movie("The Godfather", 175),
                new Movie("The Dark Knight", 152),
                new Movie("Pulp Fiction", 154),
                new Movie("Schindler's List", 195),
                new Movie("The Lord of the Rings: The Return of the King", 201),
                new Movie("Forrest Gump", 142),
                new Movie("Inception", 148),
                new Movie("Fight Club", 139),
                new Movie("The Matrix", 136),
                new Movie("Goodfellas", 146),
                new Movie("Star Wars: Episode IV – A New Hope", 121),
                new Movie("Avengers: Endgame", 181),
                new Movie("Gladiator", 155),
                new Movie("Jurassic Park", 127),
                new Movie("The Lion King", 88),
                new Movie("Titanic", 195),
                new Movie("The Silence of the Lambs", 118),
                new Movie("Saving Private Ryan", 169),
                new Movie("Interstellar", 169)
            };
    }
}
