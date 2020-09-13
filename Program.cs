
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
            List<string> cd = new List<string>
            {
                "hola",
                "pepe",
                "mama"
            };
            return cd[int.Parse(resourceId)];
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

        //[DisplayName(person.Noo())]
        [LocalizedDisplayNameAttribute("1")]
        public string Name { get => name; set => name = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
