using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anvil.Net;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AnvilMap a = new AnvilMap(@"C:\Users\Myvar\Desktop\world");
            a.Save();
        }
    }
}
