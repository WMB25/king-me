using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kingme
{
    class Match
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public static void Initialize(int PlayerId, string PlayerPassword)
        {
            Jogo.Iniciar(PlayerId, PlayerPassword);
        }
    }
}
