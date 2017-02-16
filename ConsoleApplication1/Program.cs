            using System;
using System.Collections.Generic;
            using System.Configuration;
            using System.Linq;
using System.Net.Http;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PlayWithJsonImage");

            string imagePath = ConfigurationManager.AppSettings["ImageFilePath"];
            var class1 = new ClassLibrary1.Class1(imagePath);
            
            var json = class1.JsonObject;

            Console.ReadKey();
        }
    }

}
