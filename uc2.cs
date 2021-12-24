using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
    public class uc2
    {
        public static int employeewagescount()
        {
            int employeedailywages = 20;
            int employeedailyhour = 8;
            int empwages=0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                empwages = employeedailyhour * employeedailywages;
            }
            else
            {
                Console.WriteLine("expecting money without work ");
            }
            return empwages;
        }
   
         



        
        
            


    }
}
