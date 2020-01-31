using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] result = LeetCode.TwoSum2(new int[] { 11, 11, 2, 7 }, 9);
                Console.WriteLine(result[0]);
                Console.WriteLine(result[1]);
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
