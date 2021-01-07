using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public class PopulationDao : TripleKeyDao<Population,int,bool,int>
    {
        public List<Population> GetByLibraryId(int libraryId)
        {
            using (SlisEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Populations
                            where x.LibraryId == libraryId
                            select x;

                return query.ToList();
            }
        }

        /*public List<Population> GetByIsMale(bool isMale)
        {
            using (SlisEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Populations
                            where x.IsMale == true
                            select x;

                return query.Count();
            }
        }
*/
        public List<Population> GetByAgeCode(int ageCode)
        {
            using (SlisEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Populations
                            where x.AgeCode == ageCode
                            select x;

                return query.ToList();
            }
        }
    }
}
