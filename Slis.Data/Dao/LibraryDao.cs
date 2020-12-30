using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public class LibraryDao : SingleKeyDao<Library, int>
    {
        protected override Expression<Func<Library, int>> KeySelector => x => x.LibraryId;

    }
}
