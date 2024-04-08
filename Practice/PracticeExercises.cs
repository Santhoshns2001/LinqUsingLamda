using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaAndLinq.Practice
{
    internal class PracticeExercises
    {

        public static void Exercise1()
        {
            int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // using quary syntax 
            var nQuery = from arr in arrays where (arr % 2 == 0)  select arr;
                    //or
            //Using method syntax
            var result=arrays.Where(a=> a%2==0);

            Console.WriteLine("printing using method syntax");
            foreach (var r in result)
            {
                Console.Write("{0}",r+" ");
            }
            Console.WriteLine();

                        //or

            Console.WriteLine("printing using query syntax");
            foreach (var arr in nQuery)
            {
                Console.Write("{0}",arr+" ");
            }
            Console.WriteLine();
        }

        public static void Exercise2()
        {
            int[] ar = {-1,-2,-3,-4,-5,-6,-7,-8,-9,-10,0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //query syntax
            //  var result = from a in ar where (a > 0) select a;

            var result = from a in ar
                         where a > 0
                         where a <= 10
                         select a;

            foreach(var a in result)
                Console.WriteLine(a);

            //method syntax

            var res = ar.Where(a => a > 0);

            foreach(var a in res)
                Console.WriteLine(a);
        }

    }
}
