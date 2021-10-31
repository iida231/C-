using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDB.SqlServer
{
    public static class ProductSqlServer
    {
        private static string _connectionString;
        static ProductSqlServer()
        {
            //SQL接続にはDB名とテーブル名が必要である
            //DB接続するためのコネクション
            var builder = new SqlConnectionStringBuilder();

            //サーバ名
            //\があるとエラーになるため＠をつける
            builder.DataSource = @"LAPTOP-CTHD7A6U\SQLEXPRESS";

            //DB名
            builder.InitialCatalog = "TestDB";

            //認証方式(Windowsn認証)
            builder.IntegratedSecurity = true;

            _connectionString = builder.ToString();
        }

        public static DataTable GetDataTable()
        {

            var sql = @"select * from Product";

            DataTable dt = new DataTable();
            //SQLサーバーに接続できる
            //usingで書くことで接続を自動的に切ることができる
            using (var connection = new SqlConnection(_connectionString))
            //sql実行することができるのがadapter
            using (var adapter = new SqlDataAdapter(sql, connection))
            {
                //接続
                connection.Open();

                //adapter実行する
                //全部取る
                adapter.Fill(dt);
            }
            return dt;
        }

        public static List<ProductEntity> GetDataReader()
        {
            var sql = @"select * from Product";

            var result = new List<ProductEntity>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                //select分を一分一分返してくれる
                using (var reader = command.ExecuteReader())
                {
                    //読み込んでいるときはTrue
                    while (reader.Read())
                    {
                        //DATAを取り出すときはObject型になる
                        var productID = Convert.ToInt32(reader["ProductId"]);
                        var productName = Convert.ToString(reader["ProductName"]);
                        result.Add(new ProductEntity(
                            Convert.ToInt32(reader["ProductId"]),
                            Convert.ToString(reader["ProductName"]),
                            Convert.ToInt32(reader["Price"])));
                    }
                }
            }
            return result;
        }
        public static void Insert(ProductEntity product)
        {
            //改行するときは@がいる
            string sql = @"insert into Product
(ProductId,
ProductName,
Price)
values(@ProductId,@ProductName,@Price)";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ProductId", product.ProductId);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@Price", product.Price);

                command.ExecuteNonQuery();
            }
        }

        public static void Update(ProductEntity product)
        {
            //改行するときは@がいる
            string sql = @"
update Product
set ProductName = @ProductName,
price=@Price
where ProductId = @ProductId";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ProductId", product.ProductId);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@Price", product.Price);

                var updateCount = command.ExecuteNonQuery();
                if (updateCount < 1)
                {
                    Insert(product);
                }
            }
        }

        public static void Delete(int productId)
        {
            //改行するときは@がいる
            string sql = @"
delete Product
where ProductId = @ProductId
";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ProductId", productId);
 
                var updateCount = command.ExecuteNonQuery();
            }
        }
    }
}
