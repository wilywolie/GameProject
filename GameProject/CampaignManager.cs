using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager:IGamerService
    {
        IUserValidationService _userValidationService;

        public CampaignManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) is true)
            {
                Console.WriteLine("Kampanya Eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız kampanya eklenemedi!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
