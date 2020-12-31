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
        protected override Expression<Func<Book, string>> KeySelector => x => x.Isbn;
    }
}
