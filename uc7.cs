using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
    public  class uc7
    {
        public static int employeewagesforcompany(string company,int employeewageperhour,int employeeworkinghour,int employeeworkingdays)
        {
            int emphours = 0, totalemphours = 0, totalworkingdays = 0;
            int employeewages = 0;
            while(totalemphours < employeeworkinghour || totalworkingdays < employeeworkingdays)
            {
                Random rem = new Random();
                int check = rem.Next(0, 3);
                totalworkingdays++;
                if (check == 0)
                {
                    emphours += 8;
                }
                else if (check == 1)
                {
                    emphours += 4;

                }
                else if (check == 2)
                {
                    emphours += 0;
                }
            }
            employeewages = employeewageperhour * emphours;
            Console.WriteLine("company is " + company);
            Console.WriteLine("employee total salary for this month is --- > " + employeewages);
            Console.WriteLine("----------------------------------------------------------------------");
            return employeewages;
        }
    }
}
