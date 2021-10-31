using Dapper;
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
        static ProductSqlServer()
        {
            
        }

        public static DataTable GetDataTable()
        {

            var sql = @"select * from Product";

            return SqlServerHelper.GetDataTable(sql);
        }

        public static List<ProductEntity> GetDataReader()
        {
            var sql = @"select * from Product";

            var result = new List<ProductEntity>();

            SqlServerHelper.Query(sql,
                reader =>
                {
                    result.Add(new ProductEntity(
                     Convert.ToInt32(reader["ProductId"]),
                     Convert.ToString(reader["ProductName"]),
                     Convert.ToInt32(reader["Price"])));
                });
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

            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@ProductId", product.ProductId));
            p.Add(new SqlParameter("@ProductName", product.ProductName));
            p.Add(new SqlParameter("@Price", product.Price));
            SqlServerHelper.Execute(sql, p);
        }

        public static void Update(ProductEntity product)
        {
            //改行するときは@がいる
            string sql = @"
update Product
set ProductName = @ProductName,
price=@Price
where ProductId = @ProductId";

            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@ProductId", product.ProductId));
            p.Add(new SqlParameter("@ProductName", product.ProductName));
            p.Add(new SqlParameter("@Price", product.Price));
            var updatecount = SqlServerHelper.Execute(sql, p);

            if(updatecount < 1)
            {
                Insert(product);
            }
        }

        public static void Delete(int productId)
        {
            //改行するときは@がいる
            string sql = @"
delete Product
where ProductId = @ProductId
";
            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@ProductId", productId));
            SqlServerHelper.Execute(sql, p);
        }

        //Nugetのdapperの使い方
        public static List<ProductEntity> GetDapper()
        {
            var sql = @"select * from Product";

            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            {
               return connection.Query<ProductEntity>(sql).ToList();
            }
        }

        public static void DapperInsert(ProductEntity product)
        {
            //改行するときは@がいる
            string sql = @"insert into Product
(ProductId,
ProductName,
Price)
values(@ProductId,@ProductName,@Price)";

            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                connection.Execute(sql,
                    new
                    {
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        Price = product.Price,
                    });
            }
        }
    }
}
