using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTutorials
{
    class Module2
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employee = new Employee[] {
                new Employee { ID = 1,Name = "saud"},
                new Employee { ID = 2,Name = "sana"},
                new Employee { ID = 3,Name = "rashid"},
                new Employee { ID = 4,Name = "fahad"}
            };

            IEnumerable<Employee> liEmployee = new List<Employee>() {
                    new Employee { ID = 5,Name = "javed"},
                    new Employee { ID = 6,Name = "mubin"},
                    new Employee { ID = 7,Name = "rahil"},
            };

            //IEnumerator<Employee> enumerator = liEmployee.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}
            //Console.ReadLine();

            //int countresult = employee.myCount();
            //Console.WriteLine(countresult);
            //Console.ReadLine();

            //string text = "43.35";
            //double dResult = text.ToDouble();
            //Console.WriteLine(dResult);
            //Console.ReadLine();


            //foreach (var item in employee.Where(firstnamesatartswiths))
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.ReadLine();


            //foreach (var item in employee.Where(
            //    delegate (Employee emp)
            //    {
            //        return emp.Name.StartsWith("s");
            //    }))
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.ReadLine();


            //foreach (var item in employee.Where(emp => emp.Name.StartsWith("s")))
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.ReadLine();


            //Func<int, int> square = x => x * x;
            //Console.WriteLine(square(5));
            //Console.ReadLine();


            //Func<int, int, int> add = (x,y) => x + y;
            //Console.WriteLine(add(5,4));
            //Console.ReadLine();


            //Action<int> myWrite = X => Console.WriteLine(X);
            //myWrite(7);
            //Console.ReadLine();

            //var query = employee.Where(emp => emp.Name.StartsWith("s"));
            var query = from emp in employee
                        where emp.Name.StartsWith("s")
                        orderby emp.ID
                        select emp;

            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }

        private static bool firstnamesatartswiths(Employee employee)
        {
            return employee.Name.StartsWith("s");
        }
    }

    public static class stringExtensions
    {
        static public double ToDouble(this string data)
        {
            double result = double.Parse(data);
            return result;
        }
    }
}
