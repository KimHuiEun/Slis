using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public partial class Library
    {
        public override string ToString()
        {
            return $"{LibraryId} / {Name} / {HomePage} / {Location} / {Address} / {SpecializedIn}";
        }
    }
}
