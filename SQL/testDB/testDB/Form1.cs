using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DataTableReadButton_Click(object sender, EventArgs e)
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

            var connectionString = builder.ToString();

            var sql = @"select * from Product";

                DataTable dt = new DataTable();
            //SQLサーバーに接続できる
            //usingで書くことで接続を自動的に切ることができる
            using (var connection = new SqlConnection(connectionString))
                //sql実行することができるのがadapter
            using (var adapter = new SqlDataAdapter(sql,connection))
            {
                //接続
                connection.Open();

                //adapter実行する
                adapter.Fill(dt);
            }

            dataGridView1.DataSource = dt;

        }
    }
}
