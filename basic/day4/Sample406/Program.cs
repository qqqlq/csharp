using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample406
{
    class Program
    {
        static void Main(string[] args)
        {
            // 乱数の初期化
            Random rnd = new Random();
            Console.WriteLine("6が出たら終了");
            // 無限ループ
            while (true){
                int dice = rnd.Next(1, 7);
                Console.WriteLine(dice);
                if (dice == 6){
                    break;
                }
            }
            Console.WriteLine("終了");
        }
    }
}