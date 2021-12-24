using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
    public class uc4
    {
        public const int emp_full_time = 0;
        public const int emp_parttime = 1;
        public const int emp_perhourrate = 200;

        public static void employeeswitchcase()
        {




            int emp_wages = 0;
            int emp_hour = 0;
            Random rem = new Random();
            int check = rem.Next(0, 3);
            switch (check)
            {
                case emp_full_time:
                    emp_hour = 8;
                    Console.WriteLine("you are full time ");
                    break;
                case emp_parttime:
                    Console.WriteLine("you are parttime ");
                    emp_hour = 4;
                    break;
                default:
                    emp_hour = 0;
                    Console.WriteLine("expecting salary without work funny!!!");
                    break;



            }
            emp_wages = emp_hour * emp_perhourrate;
            Console.WriteLine("your salary is -- " + emp_wages);

        }

    }
}
