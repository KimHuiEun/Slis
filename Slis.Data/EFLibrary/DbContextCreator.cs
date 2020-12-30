using Slis.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/SlisModel.csdl|res://*/SlisModel.ssdl|res://*/SlisModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=Slis;user id=8F;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";

        public static SlisEntities Create()
        {
            SlisEntities context = new SlisEntities(ConnectionString);
            
            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }
    }
}

namespace Slis.Data
{
    public partial class SlisEntities
    {
        public SlisEntities(string connectionString) : base(connectionString)
        {
        }
    }
}
