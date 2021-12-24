using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
   public  class uc5
    {
        public static void employeewagesmonth()
        {
            int employeewagesperhour = 200;
            int employeehour = 0;
            int workingdays = 20;
            int employeewages = 0;
            int i = 0;
            
            while(i < workingdays)
            {
                int dailywage=uc3.employeewagesparttime();
                Console.WriteLine("on  " + i + "  employee wages is ---> ", dailywage);
                employeewages += dailywage;
                i++;
            }
            Console.WriteLine("monthly wage is ----> ", employeewages);
        }
    }
}
