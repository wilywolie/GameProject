using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class SaleManager:IGamerService
    {
        IUserValidationService _userValidationService;

        public SaleManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyun satışı eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız oyun satışı eklenemedi!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyun satışı silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyun satışı güncellendi");
        }
    }
}
