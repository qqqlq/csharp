using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    class Person
    {
        // フィールド
        private string name = "";
        private int age = 0;
        // 情報の設定
        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        // 情報の表示(メソッド)
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前:{0} 年齢:{1}", name, age);
        }
        // 情報の設定
        // プロパティ
        public string Name
        {
            set { name = value; } // setアクセサ(setterともいう) // valueに代入された値が入る
            get { return name; } // getアクセサ(getterともいう) // nameフィールドの値を返す
        }
        // 情報の設定
        // プロパティ
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}