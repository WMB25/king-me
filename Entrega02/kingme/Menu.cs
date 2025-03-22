using KingMeServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kingme.ErrorHandler;

namespace kingme
{
    public partial class Menu: Form
    {
        Player player = new Player();
        ErrorHandler errorHandler = new ErrorHandler();
        public Menu()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.ShowDialog();
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            NewGame game = new NewGame();
            game.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string matchId = txtIdMatch.Text;
            string playerName = txtPlayerName.Text;
            string passCurrentMatch = txtPasswordCurrentMatch.Text;

            if (errorHandler.IsFieldBlank("Id da partida", matchId) || 
                errorHandler.IsFieldBlank("Nome do jogador", playerName) ||
                errorHandler.IsFieldBlank("Senha da partida", passCurrentMatch) ||
                errorHandler.IsFieldContainsSpecialCharacters("Id da partida", matchId))
            {
                clearFields();
                return;
            }

            string credentials = Jogo.Entrar(Convert.ToInt32(matchId), playerName, passCurrentMatch);

            if (errorHandler.IsGameMethodReturnError(credentials))
            {
                clearFields();
                return;
            }

            credentials = credentials.Replace("\r", "");
            credentials = credentials.Substring(0, credentials.Length);
            string[] matchListSanitized = credentials.Split(',');

            player.Id = Convert.ToInt32(matchListSanitized[0]);
            player.Password = matchListSanitized[1];

            Game game = new Game();
            game.playerId = player.Id.ToString();
            game.playerPass = player.Password;
            game.matchId = txtIdMatch.Text;

            game.updateGameContent();
            game.ShowDialog();
        }

        private void clearFields()
        {
            txtIdMatch.Clear();
            txtPasswordCurrentMatch.Clear();
            txtPlayerName.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
