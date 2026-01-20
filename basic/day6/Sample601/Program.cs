using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();  // 一つ目のPersonクラスのメソッドのインスタンスを生成
            p2 = new Person();  // 二つ目のPersonクラスのメソッドのインスタンスを生成
            p1.name = "山田太郎";  // p1のnameフィールドに値を設定
            p1.age = 20;          // p1のageフィールドに値を
            p2.SetAgeAndName("鈴木花子", 18); // p2のフィールドにメソッドで値を設定
            p1.ShowAgeAndName(); // p1の情報を表示
            p2.ShowAgeAndName(); // p2の情報を表示
        }
    }
}