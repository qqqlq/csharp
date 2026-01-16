using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample405
{
    class Program
    {
        static void Main(string[] args){
            int i, num;
            num = 1;
            //whileループで実行
            Console.WriteLine("whileループで実行");
            i = 1;
            while(i < num){
                Console.Write("*");
                i++;
            }
            Console.WriteLine();
            //do～whileループで実行
            Console.WriteLine("do～whileループで実行");
            i = 1;
            do{
                Console.Write("*");
                i++;
            }while(i < num);
            Console.WriteLine();
        }
    }
}