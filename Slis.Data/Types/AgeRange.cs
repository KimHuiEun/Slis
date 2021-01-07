using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data.Types
{
    //보통 코드테이블을 만들어서 입력하지만 열거형을 만들어서 사용하였음.
    public enum AgeRange 
    {
        Under10 = 0,
        Ten = 1,
        Twenty = 2,
        Thirty = 3,
        Forty = 4,
        Fifty= 5,
        Over60 = 6
    }
}
