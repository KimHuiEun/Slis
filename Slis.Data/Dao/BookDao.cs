using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public class BookDao : SingleKeyDao<Book, string>
    {
        internal BookDao() { }

        protected override Expression<Func<Book, string>> KeySelector => x => x.Isbn;

        public bool Exists(string isbn)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Books
                            select x;

                return true;
            }
        }
    }
}
