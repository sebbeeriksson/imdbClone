using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hellow.Content;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace Hellow
{
    internal class DataBaseLoader
    {
        private readonly string connectionString;
        public Imdb imdb;

        public DataBaseLoader(string connectionString, Imdb imdb)
        {
            this.connectionString = connectionString;
            this.imdb = imdb;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


        public async Task LoadDataFromDBToObjects()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    await connection.OpenAsync();
                    Console.WriteLine("Connected to database");



                    int tableCount = 0;

                    

                    // Query to count the number of tables
                    string countQuery = "SELECT COUNT(*) AS TableCount FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE';";
                    using (var command = new SqlCommand(countQuery, connection))
                    {

                        tableCount = (int)await command.ExecuteScalarAsync();
                        Console.WriteLine($"Table count: {tableCount}");
                    }
                    



                    //Movies
                    string queryMovies = "SELECT * FROM Movies";
                    using (var command = new SqlCommand(queryMovies, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {

                            Movie movieInstance = new Movie((String)reader["TITLE"], (int)reader["LENGTH"]);
                            imdb.listOfAllMovies.Add(movieInstance);

                        }
                    }

                    //Actors
                    string queryActors = "SELECT * FROM Actors";
                    using (var command = new SqlCommand(queryActors, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Actor actorInstance = new Actor((String)reader["NAME"], (int)reader["AGE"]);
                            actorInstance.OscarWins = (int)reader["OSCAR_WINS"];
                            imdb.listOfAllActors.Add(actorInstance);

                        }
                    }

                    //Directors
                    string queryDirectors = "SELECT * FROM Directors";
                    using (var command = new SqlCommand(queryDirectors, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Director directorInstance = new Director((String)reader["NAME"], (int)reader["AGE"]);
                            directorInstance.OscarWins = (int)reader["OSCAR_WINS"];
                            imdb.listOfAllDirectors.Add(directorInstance);
                        }
                    }

                    //Series
                    string querySeries = "SELECT * FROM Series";
                    using (var command = new SqlCommand(querySeries, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Series seriesInstance = new Series((String)reader["TITLE"]);
                            imdb.listOfAllSeries.Add(seriesInstance);
                        }
                    }

                    //Episodes
                    string queryEpisodes = "SELECT * FROM Episodes";
                    using (var command = new SqlCommand(queryEpisodes, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Episode episodeInstance = new Episode((String)reader["TITLE_EPISODE"], (int)reader["LENGTH"], (int)reader["SEASON"]);

                            foreach (Series series in imdb.listOfAllSeries) 
                            {
                                if(series.Id == (int)reader["SERIES_ID"]) 
                                {
                                    series.AddEpisodeToShow(episodeInstance);
                                }
                                
                            }
                            imdb.listOfAllEpisodes.Add(episodeInstance);
                        }
                    }

                    //Users
                    string queryUsers = "SELECT * FROM Users";
                    using (var command = new SqlCommand(queryUsers, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {

                            User user = new User((String)reader["NAME"], (int)reader["AGE"]);
                            imdb.listOfAllUsers.Add(user);
                        }
                    }

                    //Ratings
                    string queryRatings = "SELECT * FROM Ratings";
                    using (var command = new SqlCommand(queryRatings, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int userId = (int)reader["USER_ID"];
                            var user = imdb.listOfAllUsers.FirstOrDefault(u => u.Id == userId);

                            if (user == null)
                            {
                                continue;
                            }

                            int contentId = (int)reader["CONTENT_ID"];
                            bool isMovie = (int)reader["IS_MOVIE"] == 1;

                            MediaContent content;
                            if (isMovie)
                            {
                                content = imdb.listOfAllMovies.FirstOrDefault(m => m.Id == contentId);
                            }
                            else
                            {
                                content = imdb.listOfAllSeries.FirstOrDefault(s => s.Id == contentId);
                            }

                            if (content == null)
                            {
                                // If content is not found, skip this rating
                                continue;
                            }

                            float ratingValue = Convert.ToSingle(reader["RATING"]);
                            Rating rating = new Rating(ratingValue, user, content);
                            user.UsersRatings.Add(rating);
                            content.AddNewRating(rating);
                            imdb.listOfAllRatings.Add(rating);
                            
                        }
                    }



                    //Relational databases:

                    //MovieActor
                    string queryMovieActor = "SELECT * FROM MovieActor";
                    using (var command = new SqlCommand(queryMovieActor, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int movieID = (int)reader["MOVIE_ID"];
                            int actorID = (int)reader["ACTOR_ID"];


                            Movie movie = imdb.listOfAllMovies.FirstOrDefault(m => m.Id == movieID);
                            Actor actor = imdb.listOfAllActors.FirstOrDefault(m => m.Id == actorID);

                            movie.AddNewActor(actor);
                            actor.AddContentToActor(movie);


                        }
                    }

                    //MovieDirector
                    string queryMovieDirector = "SELECT * FROM MovieDirector";
                    using (var command = new SqlCommand(queryMovieDirector, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int movieID = (int)reader["MOVIE_ID"];
                            int directorID = (int)reader["DIRECTOR_ID"];


                            Movie movie = imdb.listOfAllMovies.FirstOrDefault(m => m.Id == movieID);
                            Director director = imdb.listOfAllDirectors.FirstOrDefault(m => m.Id == directorID);

                            movie.AddNewDirector(director);
                            director.AddContentToDirector(movie);
                        }
                    }

                    //SeriesActor
                    string querySeriesActor = "SELECT * FROM SeriesActor";
                    using (var command = new SqlCommand(querySeriesActor, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int SeriesID = (int)reader["SERIES_ID"];
                            int ActorID = (int)reader["ACTOR_ID"];


                            Series series = imdb.listOfAllSeries.FirstOrDefault(m => m.Id == SeriesID);
                            Actor actor = imdb.listOfAllActors.FirstOrDefault(m => m.Id == ActorID);

                            series.AddNewActor(actor);
                            actor.AddContentToActor(series);
                        }
                    }

                   
                    //SeriesDirector
                    string querySeriesDirector = "SELECT * FROM SeriesDirector";
                    using (var command = new SqlCommand(querySeriesDirector, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int SeriesID = (int)reader["SERIES_ID"];
                            int DirectorID = (int)reader["DIRECTOR_ID"];


                            Series series = imdb.listOfAllSeries.FirstOrDefault(m => m.Id == SeriesID);
                            Director director = imdb.listOfAllDirectors.FirstOrDefault(m => m.Id == DirectorID);

                            series.AddNewDirector(director);
                            director.AddContentToDirector(series);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

            }
        }



        public async Task TestConnectionAsync()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    await connection.OpenAsync();
                    Console.WriteLine("Connection successful!");

                    string query = "SELECT TOP 5 * FROM Movies";  
                    using (var command = new SqlCommand(query, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

       
       

        // Method to execute a non-query command (e.g., insert, update)
        public async Task ExecuteNonQueryAsync(string query)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand(query, connection);
                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine("Command executed successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
