using GameProjectDemo.Abstract;
using GameProjectDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun sisteme eklendi : " + game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun sistemden silindi : " + game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun sistemden güncellendi : " + game.Name);
        }
    }
}
