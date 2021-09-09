using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectOdev
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.Write("Kayıt Eklendi");
            }
            else
            {
                Console.Write("Kayıt Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.Write("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.Write("Kayıt Güncellendi");
        }
    }
}
