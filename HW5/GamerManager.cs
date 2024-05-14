using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Başarılı.");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Güncelleme Başarılı.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Silme İşlemi Başarılı.");
        }
    }
}
