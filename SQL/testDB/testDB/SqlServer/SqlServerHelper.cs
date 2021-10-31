using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDB.SqlServer
{
    public static class SqlServerHelper
    {
        internal static string ConnectionString { get; }

        static SqlServerHelper()
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

            ConnectionString = builder.ToString();
        }

        public static DataTable GetDataTable(string sql)
        {

            DataTable dt = new DataTable();
            //SQLサーバーに接続できる
            //usingで書くことで接続を自動的に切ることができる
            using (var connection = new SqlConnection(ConnectionString))
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

        public static void Query(string sql,Action<SqlDataReader> action)
        {
            

            var result = new List<ProductEntity>();
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                //select分を一分一分返してくれる
                using (var reader = command.ExecuteReader())
                {
                    //読み込んでいるときはTrue
                    while (reader.Read())
                    {
                        action(reader);
                    }
                }
            }
        }

        public static int Execute(string sql,List<SqlParameter> sqlParametes)
        {
            //改行するときは@がいる

            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                if(sqlParametes != null)
                {
                    command.Parameters.AddRange(sqlParametes.ToArray());
                }

                return command.ExecuteNonQuery();
            }
        }
    }
}
