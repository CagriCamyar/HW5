using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1995 && gamer.FirstName == "ÇAĞRI" && gamer.LastName == "ÇAMYAR" && gamer.NationalityId == "21593567558")
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
