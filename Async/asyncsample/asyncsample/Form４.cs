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
    /// 非同期プログラミングを行う（Task編）
    /// </summary>
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UIスレッドと別の操作を規定する
            var context = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Run(() => GetData()).ContinueWith(x =>
            {
                //UIスレッド上で行う処理をかける
                dataGridView1.DataSource = x.Result;
                MessageBox.Show("完了");
            }, context);

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
