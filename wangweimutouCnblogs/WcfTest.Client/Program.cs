using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfTest.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client proxy = new Service1Client();
            string strMsg = proxy.GetData(12);
            Console.WriteLine(strMsg);
            Console.Read();
        }
    }
}
