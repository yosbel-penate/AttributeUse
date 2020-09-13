
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace AttributeUse
{
    public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        public LocalizedDisplayNameAttribute(string resourceId)
            : base(GetMessageFromResource(resourceId))
        {
          
        }

        private static string GetMessageFromResource(string resourceId)
        {
            using (var ctx=new ModelFierstEntities())
            {
                return ctx.Persons.Find(int.Parse(resourceId)).name??"";
            }
        }
    }
    class person
    {
        const string _attname="none";
        string name;

        public static string Noo()
        {
            return "none";
        }
        public person()
        {
            Name = name;
        }

        [LocalizedDisplayNameAttribute("1")]
        public string Name { get => name; set => name = value; }
        [LocalizedDisplayNameAttribute("2")]
        public string Name1 { get => name; set => name = value; }
        [LocalizedDisplayNameAttribute("3")]
        public string Name2 { get => name; set => name = value; }
        [LocalizedDisplayNameAttribute("4")]
        public string Name3 { get => name; set => name = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
