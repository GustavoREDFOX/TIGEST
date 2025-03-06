using System;
using System.Data.SqlClient;

public class Database
{
    private readonly string connectionString = "Server=dsqlapp039-01br;Database=db_tigest;User Id=ppe;Password=ppe;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public void ExecuteQuery(string query)
    {
        using (SqlConnection conn = GetConnection())
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
