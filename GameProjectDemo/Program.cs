using GameProjectDemo.Adapters;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entites;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {Name="Ay sonu indirimi",Id=1,Discound="Bu ay sonuna özel %50 indirmler başladı." });

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Save(new Gamer {FirstName="Elyase Faruk", LastName="Keçeli",DateOfBirth= new DateTime(1996,2,2),Id=1,NationaltyId="67837025682"});

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { Name="Cs.Go",Id=3,Price=80,Description="Fps çoklu aksiyon oyunu"});

            Console.ReadLine();
        }
    }
}
