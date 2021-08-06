using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    public class Refactor : System.Attribute
    { }
    
    [Refactor]
    public class MyAttributes
    {
        [Refactor]
        public static void Fug()
        {
            Console.WriteLine("Inside Fug");
        }

        [Refactor]
        public static void Tower()
        {
            Console.WriteLine("Inside Tower");
        }

        [Refactor]
        public static void Fruit()
        {
            Console.WriteLine("Inside Fruit");
        }

        [Refactor]
        public static void Animal()
        {
            Console.WriteLine("Inside Animal");
        }

        [Refactor]
        public static void Game()
        {
            Console.WriteLine("Inside Game");
        }
    }
}
