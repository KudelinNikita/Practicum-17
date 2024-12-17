using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_16_Куделин.Н_215гр
{
    class Program
    {
        static void Main(string [] args)
        {
            //ЗАДАНИЕ 1:Создать коллекцию из разных оттенков цвета.

            //List <string>people=new list<string>();
            //List<string> people = new List<string>() { "Jhon", "Kate", "Peter" };
            //var people2 = new List<string>() { "Borch", "Ivan", "Vodka" };
            //var enployer = new List<string>(people 2);


            List<string> list = new List<string>();
            list.Add("Red");
            list.Add("Yellow");
            list.Add("Black");
            Output(list);
            Console.WriteLine(list.Count);
            Output1(list);
            list.Add("Blue");
            Output(list);
            list.Insert(0, "Black");
            Output(list);
            list.Remove("Yellow");
            Output(list);
            list.Reverse();
            Output(list);
            Console.ReadKey();
        }
        static void Output(List<string>List)
            {
            foreach(var el in List)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
        static void Output1(List<string> List)
        {
            foreach (var el in List)
            {
                Console.WriteLine(el.ToUpper());
            }
            Console.WriteLine();
        }
    }
}
