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
    /// キャンセルする場合で推奨しない書き方
    /// </summary>
    public partial class Form6 : Form
    {
        private bool _iscancel = false;
        public Form6()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _iscancel = false;
            dataGridView1.DataSource = await Task.Run(() => GetData());
            if (_iscancel)
            {
                MessageBox.Show("キャンセルされました");
            }
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
                if (_iscancel)
                {
                    return null;
                }
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }
            return result;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _iscancel = true;
        }
    }
}
