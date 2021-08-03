using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncsample
{
    /// <summary>
    ///databaseにアクセスする関数
    /// </summary>
    class DataBase2
    {
        private bool _iscancel = false;

        /// <summary>
        /// IDと名前のデータ情報を作成する
        /// </summary>
        /// <returns>IDと名前のデータ情報</returns>
        internal List<DTO> GetData(System.Threading.CancellationToken token)
        {
            var result = new List<DTO>();
            for (int i = 0; i < 5; i++)
            {
                token.ThrowIfCancellationRequested();
                if (_iscancel)
                {
                     return null;
                }
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }
            return result;
        }
    }
}
