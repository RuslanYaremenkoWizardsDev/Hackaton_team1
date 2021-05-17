using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TournamentManager
{
    public static class DataHelper
    {
        private const string connectionString = "Data Source=DESKTOP-8AL13S1;Initial Catalog=TournamentManager;Integrated Security=True";

        public static void TournamentDataInsert(
            string name, string description, string type, string location, string gameStart, string registrationEnd,
            string tournamentLevel, int participantsNumber, string tournamentScenario, int result)
        {
            string sqlExpression = "INSERT INTO Tournament" +
                " VALUES (@name, @description, @type, @location, @gameStart, @registrationEnd, @tournamentLevel, @participantsNumber, @tournamentScenario, @result)";

            var connection = new SqlConnection(connectionString);

            connection.Open();

            var command = new SqlCommand(sqlExpression, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@gameStart", gameStart);
            command.Parameters.AddWithValue("@registrationEnd", registrationEnd);
            command.Parameters.AddWithValue("@tournamentLevel", tournamentLevel);
            command.Parameters.AddWithValue("@participantsNumber", participantsNumber);
            command.Parameters.AddWithValue("@tournamentScenario", tournamentScenario);
            command.Parameters.AddWithValue("@result", result);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void TeamDataInsert(string name, int quantity, int score)
        {
            string sqlExpression = "INSERT INTO Team Values (@name, @quantity, @score)";

            var connection = new SqlConnection(connectionString);

            connection.Open();

            var command = new SqlCommand(sqlExpression, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@score", score);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
