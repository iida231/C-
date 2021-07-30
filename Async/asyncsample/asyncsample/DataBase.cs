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
    class DataBase
    {
        private bool _iscancel = false;

        internal bool IsCancel
        {
            get
            {
                return _iscancel;
            }
        }
        /// <summary>
        /// IDと名前のデータ情報を作成する
        /// </summary>
        /// <returns>IDと名前のデータ情報</returns>
        internal List<DTO> GetData()
        {
            _iscancel = false;
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
        internal void Cancel()
        {
            _iscancel = true;
        }
    }
}
