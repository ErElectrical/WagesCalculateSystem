using System;
using System.Collections.Generic;
using System.Linq;
namespace employeewagesproblem
{
    public class program
    {
        static void Main(string[]  args)
        {
           Console.WriteLine("welcome to employee wages computation on master barnch ");
            uc1.Employeecheck();
            int salary = uc2.employeewagescount();
           Console.WriteLine("employee daily salary is ----->   ", salary);
            int wage=uc3.employeewagesparttime();
           uc4.employeeswitchcase();
            uc5.employeewagesmonth();
            Console.WriteLine(wage);
            uc6.employeemaxhour();
            uc7.employeewagesforcompany("jio", 500, 120, 22);
            empwagebuilderarray empwagebuilderarray = new empwagebuilderarray();
            empwagebuilderarray.addcompanyempwage("google", 200, 20, 120);
            empwagebuilderarray.addcompanyempwage("microsoft", 300, 20, 120);
            empwagebuilderarray.computeempwage();
            empwagebuilder empwagebuilder = new empwagebuilder();
            empwagebuilder.addcompanyempwage("google", 200, 20, 120);
            empwagebuilder.addcompanyempwage("microsoft", 300, 20, 120);
            empwagebuilder.computeempwage();
            Console.WriteLine("total wage for google company: " + empwagebuilder.gettotalwage("google"));
            Console.WriteLine("total wage for microsoft company: " + empwagebuilder.gettotalwage("microsoft"));






        }
    }
}
