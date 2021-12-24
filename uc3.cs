using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
    public  class uc3
    {
        public static void employeewagesparttime()
        {
            int employeewageperhour = 200;
            int employeehour = 0 ;
            int empwages ;
            Random rem = new Random();
            int check = rem.Next(0, 3);
            if(check == 0)
            {
                Console.WriteLine("employee is working full time ");
                employeehour = 8;

            }
            else if (check == 1)
            {
                Console.WriteLine("employee is working part time ");
                employeehour = 4;


            }
            else if (check == 2)
            {
                Console.WriteLine("employee is not present");

                employeehour = 0;

            }
            empwages = employeewageperhour * employeehour;
            Console.WriteLine("employee salary is ", empwages);
        }
    }
}
