using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public class OwnDao : DualKeyDao<Own, int, int>
    {
        internal OwnDao() { }

        //protected override Expression<Func<Own, int, int>> KeySelector =>   
    }
}
