using GameProjectDemo.Abstract;
using GameProjectDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu sistemden silindi : " + gamer.FirstName);
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu sisteme kaydedildi. : " + gamer.FirstName);
            }
            else
            {
                throw new Exception("Oyuncu kaydedilemedi.");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu sistemden güncellendi.  :" + gamer.FirstName);
        }
    }
}
