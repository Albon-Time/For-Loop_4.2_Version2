using System;
namespace Uppg_4_2
{
    class Program
    {
        static void Main(string[] arg)
        {
            for (int år = 1495; år >= 1400; år -= 5)
                Console.WriteLine(år);
        }
    }
}