using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public class RentDao : SingleKeyDao<Rent, int>
    {
        protected override Expression<Func<Rent, int>> KeySelector => x => x.RentId;

    }
}
