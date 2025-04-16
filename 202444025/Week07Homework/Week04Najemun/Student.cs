using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Najemun
{
    class Student
    {
        public string Number;
        public string Name;
        public DateTime BirthInfo;
        public string DepartmentCode;
        public string AdvisorNumber;
        public int Year;
        public string RegStatus;
        public string Adress;
        public string Class;
        public string Contect;


        public override string ToString() {
            return $"[{this.Number}] {this.Name}";
        }


    }
}
