using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    class Person2
    {
        // 情報の設定
        public void SetAgeAndName(string name, int age)
        {
            Name = name;  // 対応するフィールドがないため、直接プロパティに対して書き込み・読み込みを行う
            Age = age;
        }
        // 情報の表示(メソッド)
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前:{0} 年齢:{1}", Name, Age);
        }
        // 情報の設定
        // 自動実装プロパティ(読み込み専用)
        public string Name
        {
            private set; get;
        }
        // 情報の設定
        // 自動実装プロパティ(読み書き可能)
        public int Age
        {
            set; get;
        }
    }
}