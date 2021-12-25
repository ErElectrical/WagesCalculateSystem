using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewagesproblem
{
    public interface computeempwage
    {
        public void addCompanyEmpWage(string company, int emprateperhour, int totalworkingdays, int maxworkinghour);
        public void computeempwage();
        public int gettotalwage(string company);

        //An interface may not declare instance data such as fields, auto-implemented properties, or property-like events.
        //By using interfaces, you can, for example, include behavior from multiple sources in a
        //class. That capability is important in C# because the language doesn't support multiple inheritance of classes.
        //which we are performing here.


    }
    public class companyempwage
    {
        public string company;
        public int emprateperhour;
        public int numofworkingdays;
        public int maxhourpermonth;
        public int totalempwage;

        public companyempwage(string company,int emprateperhour,int numofworkingdays, int maxhourpermonth)
        {
            this.company = company;
            // this method is call here varible of class fields having same name.
            // it verifies that the value is effected by class fields not method field.
            this.emprateperhour = emprateperhour;
            this.numofworkingdays = numofworkingdays;
            this.maxhourpermonth = maxhourpermonth;
            this.totalempwage = 0;

        }
        public void settotalempwage(int totalempwage)
        {
            this.totalempwage = totalempwage;

        }
        public string tostring()
        {
            return "total employee wage of company ------ > "+this.company+"  and wage is "+this.totalempwage;
        }
    }
   
}
