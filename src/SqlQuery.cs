using System.Data;
using System.Data.SqlClient;

namespace CI_DEMO
{
    public class SqlQuery
    {
        public string Query { get; set; }
        public string ConnectionString { get; set; }

        public SqlQuery(string query, string connectionString)
        {
            Query = query;
            ConnectionString = connectionString;            
        }
        public DataTable GetData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }

            }
            return null;
        }
    }
}
