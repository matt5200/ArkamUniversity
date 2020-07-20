using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {

            var school = new ArkClassesEntities();

            // This accesses the ClassMaster table
            foreach (var classMaster in school.Classes)
            {
                Console.WriteLine("ClassId: {0}\nClassName: ", classMaster.ClassName);
            }

            Console.Write("Done.");
            Console.ReadLine();

        }
    }
}
