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
        internal LibraryDao() { }

        protected override Expression<Func<Library, int>> KeySelector => x => x.LibraryId;

        public Dictionary<string, int> ToDictionary()
        {
            using (var context = DbContextCreator.Create())
            {
                return context.Libraries.ToDictionary(x => x.Location, x => x.LibraryId);
            }
        }
    }
}
