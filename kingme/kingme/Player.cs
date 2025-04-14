using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kingme
{
    class Player
    {
        private int Id { get; set; }
        public string Name { get; set; }
        private string Password { get; set; }
        private string Cards { get; set; }

        ErrorHandler errorHandler = new ErrorHandler();
        public Player()
        {

        }

        public Player(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }

        public string positionCharacter(int section, string characterLetter)
        {
            if (section == 0 || section == 10)
            {
                string errorMessage = "Você não pode posicionar personagens no setor " + section;
                errorHandler.ThrowMessageError(errorMessage);
                return null;
            }

            string boardState = Jogo.ColocarPersonagem(this.Id, this.Password, section, characterLetter);

            if (errorHandler.checkForError(boardState))
            {
                string errorMessage = boardState.Substring(4);
                errorHandler.ThrowMessageError(errorMessage);
                return null;
            }

            return boardState;
        }

        public string promoteCharacter(string characterLetter)
        {
            string boardState = Jogo.Promover(this.Id, this.Password, characterLetter);
            if (errorHandler.checkForError(boardState))
            {
                string errorMessage = boardState.Substring(4);
                errorHandler.ThrowMessageError(errorMessage);
                return null;
            }
            return boardState;
        }

        public string voteToKing(string vote)
        {
            string boardState = Jogo.Votar(this.Id, this.Password, vote);
            if (errorHandler.checkForError(boardState))
            {
                string errorMessage = boardState.Substring(4);
                errorHandler.ThrowMessageError(errorMessage);
                return null;
            }
            return boardState;
        }
        
        public string initializeGame()
        {
            string firstone = Jogo.Iniciar(this.Id, this.Password);
            if (errorHandler.checkForError(firstone))
            {
                return null;
            }
            return firstone;
        }
        public string ListCards()
        {
            if (String.IsNullOrEmpty(this.Password))
            {
                return null;
            }
            
            string cards = Jogo.ListarCartas(this.Id, this.Password);

            if (errorHandler.checkForError(cards))
            {
                return null;
            }

            return cards;
        }
        public int GetId() => this.Id;
        public void SetId(int id) => this.Id = id;
        public string GetName() => this.Name;
        public void SetName(string name) => this.Name = name;
        public string GetPassword() => this.Password;
        public void SetPassword(string password) => this.Password = password;
        public string GetCards()
        {
            if (String.IsNullOrEmpty(this.Cards))
            {
                return ListCards();
            }
            return this.Cards;
       } 
        public void SetCards(string cards) => this.Cards = cards;
    }
}
