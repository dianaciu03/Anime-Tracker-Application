using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDAL
    {
        protected const string connection = "Server = mssqlstud.fhict.local; Database=dbi505708_animedb; User Id = dbi505708_animedb; Password=AnimePlanet; TrustServerCertificate=True";

        public string Connection { get { return connection; } }

        public BaseDAL()
        {

        }
    }
}
