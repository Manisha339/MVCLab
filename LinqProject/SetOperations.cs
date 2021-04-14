using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqProject
{
    class SetOperations
    {
        static string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Apr", "Feb", "June", "Jan" };

        public static void DoDistinct()
        {
            var result = Months.Distinct();
            foreach(var month in result)
            {
                Console.WriteLine(month);
            }
        }
        public static void DoExcept()
        {
            string[] months2 = { "Sept", "Oct", "Apr", "June","Dec","Jan" };
            var result = Months.Except(months2);
            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }
        public static void DoIntersect()
        {
            string[] months2 = { "Sept", "Oct", "Apr", "June", "Dec", "Jan" };
            var result = Months.Intersect(months2);
            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }
        public static void DoUnion()
        {
            string[] months2 = { "Sept", "Oct", "Apr", "June", "Dec", "Jan" };
            var result = Months.Union(months2);
            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }
        public static void DoUnionAll()
        {
            string[] months2 = { "Sept", "Oct", "Apr", "June", "Dec", "Jan" };
            var result = Months.Concat(months2);
            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }
    }
}
