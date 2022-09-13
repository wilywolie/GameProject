using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() { BirthYear = 1999, GamerId = 1, GamerName = "Ahmet", IdentityNumber = 12345 };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);

            SaleManager saleManager = new SaleManager(new UserValidationManager());
            saleManager.Add(gamer);

            CampaignManager campaignManager = new CampaignManager(new UserValidationManager());
            campaignManager.Add(gamer);
        }
    }
}
