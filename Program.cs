using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    /*
    Программа: Hello, world 123
    Эта программа, выводит в консоли "Hello world!"
     */
    class Program
    {
        static void Main(string[] args)
        { // Операторная скобка!!! Operator bracket
            Console.Write("Hello world!"); 
            // Объекту консоль мы передаём команду Врайт, в которой в качестве параметра(аргумента) передаём строку ХелоуВорд!
            // точка это синтаксический сахар, украшение кода которое используется для стиля и удобочитаемости
            // В круглых скобках - некое уточнение команды, параметры команды
            Console.ReadKey(); // объекту Консоль мы даём команду РидКи
        }
    }
}
