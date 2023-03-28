using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdividualLogicLayer
{
    public class Maintainer : User
    {
        public Maintainer(string name, string email, string password, DateTime joinDate) : base(name, email, password, joinDate)
        {

        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
