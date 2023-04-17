using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("메소드 호출 1");
            Thread.Sleep(1000);
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 2");
            Thread.Sleep(2000);
            Console.SetCursorPosition(0, 0);
            Console.Write("메서드 호출 3");
        }
    }
}
