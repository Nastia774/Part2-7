using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_7._3
{
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            ClassTaker(myClass);
            StruktTaker(myStruct);
            // В даном случае мы увидим, что будет в change класса, но не увидим, что будет в change струтуры 
            //так как в случае структуры мы не передаем ссылку на даное поле, а даем копию и для того чтобы 
            //получить значение надо выводить из метода как и другие локальные переменные.
            Console.WriteLine($"Class : {myClass.change}, Struct : {myStruct.change}");
            myStruct.change = "не изменено";
            myClass.change = "не изменено";//Даную инициализацию мы можем провести и в самом классе в отличии от структуры.
            Console.WriteLine($"Class : {myClass.change}, Struct : {myStruct.change}");

            Console.ReadKey();
        }
    }
}
