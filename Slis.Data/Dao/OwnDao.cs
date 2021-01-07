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

        public List<Own> GetByIsbn(string isbn)
        {
            using (SlisEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Owns
                            where x.Isbn.Contains(isbn)
                            select x;

                return query.ToList();
            }
        }

        public List<Own> GetByLibraryId(int libraryId)
        {
            using (SlisEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Owns
                            where x.LibraryId == libraryId
                            select x;

                return query.ToList();
            }
        }

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
