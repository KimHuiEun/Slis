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

        public bool Exists(string isbn, int libraryId)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Owns
                            where x.Isbn == isbn && x.LibraryId == libraryId
                            select x;

                return query.Count() > 0;
            }
        }
    }
}
