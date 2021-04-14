using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqProject
{
    class Program
    {
        static List<User> users = new List<User>();
        static void Main(string[] args)
        {
            Console.WriteLine("Distinct Function");
            SetOperations.DoDistinct();
            Console.WriteLine("\nExcept Function");
            SetOperations.DoExcept();
            Console.WriteLine("\nIntersect Function");
            SetOperations.DoIntersect();
            Console.WriteLine("\nUnion Function");
            SetOperations.DoUnion();
            Console.WriteLine("\nUnion All Function");
            SetOperations.DoUnionAll();
            /*Seed();
            Console.WriteLine("All Users\n");
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }
            Console.WriteLine("\nAll Users From pune city");

            //var UsersFromPune = users.Where(u => u.City == "Pune").Select(user => new { UserName=user.Name, Usercity = user.City});
            var UsersFromPune= from user in users 
                               where user.City == "Pune"
                               select new { UserName = user.Name, Usercity = user.City };
            foreach (var user in UsersFromPune)
            {
                Console.WriteLine("City= "+user.Usercity+" Name= "+user.UserName);
            }

            Console.WriteLine("\nUser with min age");
            var MinAge = users.Min(u => u.Age);
            Console.WriteLine(MinAge);
            Console.WriteLine("\nUser with max age");
            var MaxAge = users.Max(u => u.Age);
            Console.WriteLine(MaxAge);
            Console.WriteLine("\nTotal age");
            var TotalAge = users.Sum(u => u.Age);
            Console.WriteLine(TotalAge);
            Console.WriteLine("\nTotal count of users");
            var TotalCount = users.Count();
            Console.WriteLine(TotalCount);

            Console.WriteLine("\nSorting Functions");
            users = users.OrderBy(u => u.Name).ThenBy(x=> x.Age).ToList();
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }


            Console.WriteLine("\nPartition Functions");
            users = users.Skip(2).Take(5).ToList();
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }

            Console.WriteLine("\nElement Functions");
            var Fuser = users.First();
            Console.WriteLine(Fuser.ToString());*/
            Console.ReadLine();
        }


        static void Seed()
        {
            users = new Data().Get();
            /*users.Add(new User { ID = 1, Name = "Philip", Age = 20, City = "Mumbai" });
            users.Add(new User { ID = 2, Name = "Jon", Age = 21, City = "Pune" });
            users.Add(new User { ID = 3, Name = "Kabir", Age = 30, City = "Banglore" });
            users.Add(new User { ID = 4, Name = "Doe", Age = 50, City = "Pune" });
            users.Add(new User { ID = 5, Name = "Ram", Age = 26, City = "NY" });
            users.Add(new User { ID = 6, Name = "Shyam", Age = 29, City = "NY" });
            users.Add(new User { ID = 7, Name = "Pooja", Age = 50, City = "Pune" });
            users.Add(new User { ID = 8, Name = "Saurabh", Age = 26, City = "Delhi" });
            users.Add(new User { ID = 9, Name = "Pawan", Age = 39, City = "Delhi" });*/

        }
    }
}