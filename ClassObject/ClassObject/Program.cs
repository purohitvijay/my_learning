using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobject
{
    public static class Pogram
    {

        public static void Main(string[] args)
        {

            student st = new student();
            st.name = "vijay";
            st.year = 10;
            Console.WriteLine(st.year);
            st.passtonextclass();
            Console.WriteLine(st.year);
            Console.WriteLine();
            Console.ReadKey();
        }
    }




}
