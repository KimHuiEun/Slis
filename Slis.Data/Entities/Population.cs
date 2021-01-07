using Slis.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public partial class Population
    {
        public string AgeText //TODO : 차트에서 사용해야하는것.
        {
            get
            {
                return AgeLookUp.Instance[AgeCode]; //Instance[] : 인덱서사용
            }
        }

        public override string ToString()
        {
            return $"{LibraryId} / {IsMale} / {AgeCode} / {Value}";
        }
    }
}
