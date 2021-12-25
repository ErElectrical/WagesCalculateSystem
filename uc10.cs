using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
    public  class empwagebuilder: computeempwage
    {
        public const int is_full_time = 1;
            
        public const int is_part_time=2;
        private LinkedList<companyempwage> companyempwagelist;
        private Dictionary<string, companyempwage> companytoempwagemap;
        public empwagebuilder()
        {
            this.companyempwagelist = new LinkedList<companyempwage>();
            this.companytoempwagemap=new Dictionary<string, companyempwage>();


        }
        public void addcompanyempwage(string company,int emprateperhour,int totalworkingdays,int maxworkinghour)
        {
            companyempwage companyempwage =new companyempwage(company,emprateperhour,totalworkingdays,maxworkinghour);
            this.companyempwagelist.AddLast(companyempwage);
            this.companytoempwagemap.Add(company,companyempwage);


        }
        public void computeempwage()
        {
            foreach (companyempwage companyempwage in this.companyempwagelist)
            {
                companyempwage.settotalempwage(this.computeempwage(companyempwage));
                Console.WriteLine(companyempwage.ToString);

            }

                
        }
        private int computeempwage(companyempwage companyempwage)
        {
            Random random=new Random();
            int workinghour = 0;
            int check = random.Next(1, 3);
            switch(check)
            {
                case is_full_time:
                    workinghour += 8;
                    break;
                case is_part_time:
                    workinghour += 4;
                    break;
                default:
                    workinghour += 0;
                    break;
            }
            return companyempwage.emprateperhour * workinghour;


        }
        public int gettotalwage(string company)
        {
            return this.companytoempwagemap[company].totalempwage;
        }






    }
}
