using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public partial class Population
    {
        public override string ToString()
        {
            return $"{LibraryId} / {IsMale} / {AgeCode} / {Value}";
        }
    }
}
