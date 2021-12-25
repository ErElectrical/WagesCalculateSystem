using System;
using System.Collections.Generic;
using System.Linq;
namespace employeewagesproblem
{
    public class Companyempwage
    {
        public string company;
        public int emprateperhour;
        public int numofworkingdays;
        public int maxhourpermonth;
        public int totalempwage;

        public Companyempwage(string company, int emprateperhour, int numofworkingdays, int maxhourpermonth)
        {
            this.company = company;
            this.emprateperhour = emprateperhour;
            this.numofworkingdays = numofworkingdays;
            this.maxhourpermonth = maxhourpermonth;
        }

        public void settotalempwage(int totalempwage)
        {
            this.totalempwage = totalempwage;
        }
        public string tostring()
        {
            return "total emp wage for company :   " + this.company + "  is:  " + this.totalempwage;
        }
    }
    public class empwagebuilderarray
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        private int numofcompany = 0;
        private Companyempwage[] companyempwagearray;
        public empwagebuilderarray()
        {
            this.companyempwagearray = new Companyempwage[5];
        }
        public void addcompanyempwage(string company, int emprateperhour, int numofworkingdays, int maxhourpermonth)
        {
            companyempwagearray[this.numofcompany] = new Companyempwage(company, emprateperhour, numofworkingdays, maxhourpermonth);
            numofcompany++;
        }
        public void computeempwage()
        {
            for (int i = 0; i < numofcompany; i++)
            {
                companyempwagearray[i].settotalempwage(this.computeempwage(this.companyempwagearray[i]));
                Console.WriteLine(this.companyempwagearray[i].tostring());
            }
        }
        private int computeempwage(Companyempwage companyempwage)
        {
            int emphrs = 0, totalemphrs = 0, totalworkingdays = 0;
            while (totalemphrs <= companyempwage.maxhourpermonth && totalworkingdays <= companyempwage.numofworkingdays)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case is_part_time:
                        {
                            emphrs = 4;
                            break;
                        }
                    case is_full_time:
                        emphrs = 8;
                        break;
                    default:
                        {
                            emphrs = 0;
                            break;
                        }
                }
                totalemphrs += emphrs;
                Console.WriteLine("Emp hrs " + totalemphrs + "  emp days" + totalworkingdays);
            }
            return totalemphrs * companyempwage.emprateperhour;
        }

    }
}
