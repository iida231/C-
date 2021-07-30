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
    /// 同期プログラミングと似たように非同期プログラミングを実装できる
    /// </summary>
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //asyncを入れなければならない
        /// <summary>
        /// 別タスクで行うもの
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            // awaitはタスク処理がおわるまでまってね
            dataGridView1.DataSource = await Task.Run(()=>GetData());
            MessageBox.Show("完了");
        }
        /// <summary>
        /// IDと名前のデータ情報を作成する
        /// </summary>
        /// <returns>IDと名前のデータ情報</returns>
        private List<DTO> GetData()
        {
            var result = new List<DTO>();
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }
            return result;
        }
    }
}
