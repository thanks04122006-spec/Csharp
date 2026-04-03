using System;
using System.Collections.Generic;
using System.Text;

namespace cs_0403
{
    internal class FileName
    {
        public static void Main(string[] args)
        {
            string[] arry = { "Potao", "Tomato" };

            for (int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
                Thread.Sleep(1000);
            }
        }
    }
}
