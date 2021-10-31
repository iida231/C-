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
using testDB.Models;
using testDB.SqlServer;

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


            dataGridView1.DataSource = ProductSqlServer.GetDataTable();

        }

        private void ReaderReadButton_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource=ProductSqlServer.GetDataReader();
        }

        private void InsertCommandButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdBox.Text);
            string productName = ProductNameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);

            ProductSqlServer.Insert(new ProductEntity(productId,productName,price));
        }

        private void UpdateCommand_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdBox.Text);
            string productName = ProductNameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);

            ProductSqlServer.Update(new ProductEntity(productId, productName, price));
        }

        private void DeleteCommandButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdBox.Text);

            ProductSqlServer.Delete(productId);
        }

        private void DapperReadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductSqlServer.GetDapper();
        }

        private void DapperInsertButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdBox.Text);
            string productName = ProductNameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, price);
            ProductSqlServer.DapperInsert(entity);
        }

        private void EFreadButton_Click(object sender, EventArgs e)
        {
            var source = new List<Product>();
            using (var db = new testDBContext())
            {
                source.AddRange(db.Products);
            }

            dataGridView1.DataSource = source;
        }

        private void EFInsertButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductId = Convert.ToInt32(ProductIdBox.Text);
            p.ProductName= ProductNameTextBox.Text;
            p.Price = Convert.ToInt32(PriceTextBox.Text);

            using (var db = new testDBContext())
            {
                db.Products.Add(p);
                //確定
                db.SaveChanges();
            }
        }

        private void EFUpdateButton_Click(object sender, EventArgs e)
        {
            using (var db = new testDBContext())
            {
                //検索
                var p = db.Products.Find(Convert.ToInt32(ProductIdBox.Text));
                p.ProductName = ProductNameTextBox.Text;
                p.Price = Convert.ToInt32(PriceTextBox.Text);
                //変更確定
                db.SaveChanges();
            }
        }

        private void EFDelete_Click(object sender, EventArgs e)
        {
            using (var db = new testDBContext())
            {
                var p = db.Products.Find(Convert.ToInt32(ProductIdBox.Text));
                db.Products.Remove(p);
                db.SaveChanges();
            }
        }

        private void create50000_Click(object sender, EventArgs e)
        {
            for(int i=10;i<= 5000; i++)
            {
                ProductSqlServer.Insert(new ProductEntity(
                    i,
                    "product:"+i,
                    i+10));
            }

            MessageBox.Show("完了");
        }
    }
}
