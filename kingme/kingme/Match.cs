using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kingme
{
    class Match
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        private List<string> Players { get; set; }

        ErrorHandler errorHandler = new ErrorHandler();
        public Match()
        {

        }
        public Match(int id, string password)
        {
            this.Id = id;
            this.Password = password;
        }

        public int GetId() => this.Id;
        public void SetId(int id) => this.Id = id;
        public string GetName() => this.Name;
        public void SetName(string name) => this.Name = name;
        public string GetPassword() => this.Password;
        public void SetPassword(string password) => this.Password = password;
        public List<string> GetPlayers(int matchId)
        {
            SetPlayers();
            return this.Players;
        }
        private void SetPlayers()
        {
            string playersString = Jogo.ListarJogadores(this.Id);
            if (errorHandler.checkForError(playersString))
            {
                return;
            }
            List<string> playerList = playersString.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();
            this.Players = playerList;
        }
    }
}
