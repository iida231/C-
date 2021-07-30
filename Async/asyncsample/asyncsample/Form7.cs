using asyncsample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asyncsample1
{
    /// <summary>
    /// 非同期プログラミングを行う（async await編）
    /// boolでキャンセルする場合のデメリット
    /// </summary>
    public partial class Form7 : Form
    {
        private DataBase _dataBase = new DataBase();
        public Form7()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await Task.Run(() => _dataBase.GetData());
            if (_dataBase.IsCancel)
            {
                MessageBox.Show("キャンセルされました");
            }
        }
       

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _dataBase.Cancel();
        }
    }
}
