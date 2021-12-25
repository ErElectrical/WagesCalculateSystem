using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
    public  class uc6
    {
       public static void employeemaxhour()
        {
            int employeemaxhour = 100;
            int employeehour = 0;
            
            while(employeehour < employeemaxhour)
            {
                employeehour += uc5.employeewagesmonth();
            }
        }


    }
}
