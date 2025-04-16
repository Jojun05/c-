using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Najemun
{
    //object 클래스를 상속한 Department
    class Department : object //: object는 붙이지 않아도 알아서 붙음
    {
       public string Code;
       public string Name;

        //python __str__()와 동일
        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }
    }
}
