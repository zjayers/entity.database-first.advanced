using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.DatabaseFirst.Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoDbContext();
            var courses = context.GetCourses();
            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);   
            }
        }
    }
}
