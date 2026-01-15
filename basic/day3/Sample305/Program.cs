using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample305
{
    class Program
    {
        static void Main(string[] args)
        {
            // キーボードから数値を入力
            Console.Write("1から3の整数を入力:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("1が入力されました。");
                    break;
                case 2:
                    Console.WriteLine("2が入力されました。");
                    break;
                case 3:
                    Console.WriteLine("3が入力されました。");
                    break;
                default:
                    Console.WriteLine("範囲外の数値です。");
                    break;
            }
        }
    }
}