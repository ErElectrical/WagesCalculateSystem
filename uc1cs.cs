using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
    public  class uc1
    {
        static void Employeecheck()
        {
            Random random= new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is not present");

            }

        }
        
    }
}
