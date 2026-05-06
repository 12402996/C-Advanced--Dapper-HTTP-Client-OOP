using Dapper;
using Fruitshop.Domain;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruitshop.Infrastructure.Repository
{
    internal class FruitRepository
    {
        private readonly string _connectionString;
        public FruitRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<Fruit> LoadAllFruits()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
                return connection.Query<Fruit>("Select * FROM Fruits");
        }

        public bool Delete (int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = connection.Execute
                    (
                        "DELETE FROM Fruits WHERE Id = @id", new { id }
                    );
                return rowsAffected > 0;
            }
        }
    }
}
