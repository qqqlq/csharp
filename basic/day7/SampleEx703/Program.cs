using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();
            // 名前と年齢を設定
            p.SetAgeAndName("田中一郎", 25);
            // 年齢の変更
            p.Age = 30;
            // 名前の変更(できない)
            // p.Name = 36; // エラー
            // 名前と年齢を表示
            Console.WriteLine("名前:{0} 年齢:{1}", p.Name, p.Age);
        }
    }
}