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
        private string MatchID;
        public Menu()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        }

        private void BtnMatches_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.Owner = this;
            lobby.ShowDialog();
        }

        private void BtnNewGame_Click_1(object sender, EventArgs e)
        {
            NewGame game = new NewGame();
            game.Owner = this;
            game.ShowDialog();
        }

        public void SetMatchID(string id)
        {
            MatchID = id;
            txtIdMatch.Text = id;
        }


        private void BtnPlay_Click(object sender, EventArgs e)
        {
            string matchId = txtIdMatch.Text;
            string playerName = txtPlayerName.Text;
            string passCurrentMatch = txtPasswordCurrentMatch.Text;

            if (errorHandler.IsFieldBlank("Id da partida", matchId) || 
                errorHandler.IsFieldBlank("Nome do jogador", playerName) ||
                errorHandler.IsFieldBlank("Senha da partida", passCurrentMatch) ||
                errorHandler.IsFieldContainsSpecialCharacters("Id da partida", matchId))
            {
                ClearFields();
                return;
            }

            string credentials = Jogo.Entrar(Convert.ToInt32(matchId), playerName, passCurrentMatch);

            if (errorHandler.IsGameMethodReturnError(credentials))
            {
                ClearFields();
                return;
            }

            credentials = credentials.Replace("\r", "");
            credentials = credentials.Substring(0, credentials.Length);
            string[] matchListSanitized = credentials.Split(',');

            player.Id = Convert.ToInt32(matchListSanitized[0]);
            player.Password = matchListSanitized[1];

            Game game = new Game();
            game.PlayerId = player.Id.ToString();
            game.PlayerPass = player.Password;
            game.MatchId = txtIdMatch.Text;

            game.UpdateGameContent();
            game.ShowDialog();
        }

        private void ClearFields()
        {
            txtIdMatch.Clear();
            txtPasswordCurrentMatch.Clear();
            txtPlayerName.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdMatch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
