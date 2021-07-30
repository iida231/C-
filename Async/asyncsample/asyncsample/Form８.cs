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
    public partial class Form8 : Form
    {
        //キャンセル用のトークン
        System.Threading.CancellationTokenSource _token;
        private DataBase2 _dataBase = new DataBase2();
        public Form8()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _token = new System.Threading.CancellationTokenSource();
                dataGridView1.DataSource = await Task.Run(() => _dataBase.GetData(_token.Token), _token.Token);
            }
            catch(OperationCanceledException o)
            {
                MessageBox.Show("キャンセルされました");
            }
            finally
            {
                _token.Dispose();
                _token = null;
            }
        }
       

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _token?.Cancel();
        }
    }
}
