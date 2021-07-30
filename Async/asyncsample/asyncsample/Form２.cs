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
    /// 同期的なプログラムを行う
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UIスレッドと別の操作を規定する
            var t = new System.Threading.Thread(GetData);
            t.Start();
        }

        /// <summary>
        /// IDと名前のデータ情報を作成する
        /// </summary>
        /// <returns>IDと名前のデータ情報</returns>
        private void GetData()
        {
            var result = new List<DTO>();
            for (int i=0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }
            //UIスレッドに戻す
            this.Invoke((Action)delegate ()
            {
                dataGridView1.DataSource = result;
            });
        }
    }
}
