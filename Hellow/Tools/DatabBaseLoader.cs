using System;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                        }
                    }

                    //Directors
                    string queryDirectors = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(queryDirectors, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }

                    //Series
                    string querySeries = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(querySeries, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }

                    //Episodes
                    string queryEpisodes = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(queryEpisodes, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }

                    //Ratings
                    string queryRatings = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(queryRatings, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }

                    //Users
                    string queryUsers = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(queryUsers, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }

                    //Relational databases:

                    //MovieActor
                    string queryMovieActor = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(queryMovieActor, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }

                    //MovieDirector
                    string queryMovieDirector = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(queryMovieDirector, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }

                    //SeriesActor
                    string querySeriesActor = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(querySeriesActor, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Title: {reader["TITLE"]}, Length: {reader["LENGTH"]}");
                        }
                    }

                   
                    //SeriesDirector
                    string querySeriesDirector = "SELECT TOP 5 * FROM Movies";
                    using (var command = new SqlCommand(querySeriesDirector, connection))
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
