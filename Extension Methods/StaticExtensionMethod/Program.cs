using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  StaticExtensionMethod;

namespace StaticExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newString = StringExtensions.Shorten("Hello World", 5);
            // OK: extension method syntax still works.
            "Hello World".Shorten(5);
            // OK: static method syntax still works.
            StaticExtensionMethod.StringExtensions.Shorten("Hello World", 5);
            // Compile time error: extension methods can't be called as static without specifying class.
            Shorten("Hello World", 5);
            //If you remove the this modifier from the first argument of the Shorten method, the last line will compile.
        }
    }
}
