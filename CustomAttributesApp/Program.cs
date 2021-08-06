using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CustomAttributesApp.Model;

namespace CustomAttributesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type info = typeof(MyAttributes);
            MemberInfo[] mi = info.GetMembers();
            int count = 0;
            for(int i = 0; i < mi.Length; i++)
            {
                Object[] attrs = mi[i].GetCustomAttributes(true);
                for(int j = 0; j < attrs.Length; j++)
                {
                    if (attrs[j].ToString() == "CustomAttributesApp.Model.Refactor")
                    {
                        Console.WriteLine("\nThe attributes of the member"+mi[i]+" are "+attrs[j]);
                        count += 1;
                    }
                }
            }
            Console.WriteLine("\nThe count for Custom Attribute is " + count);
            Console.ReadLine();
        }
    }
}
