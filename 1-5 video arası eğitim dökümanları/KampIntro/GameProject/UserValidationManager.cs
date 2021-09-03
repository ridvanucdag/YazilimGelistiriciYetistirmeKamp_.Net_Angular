using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectOdev
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1995 && gamer.FirstName=="RIDVAN" && gamer.LastName=="ÜÇDAĞ" && gamer.IdentityNumber==123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
