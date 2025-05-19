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
        ErrorHandler errorHandler = new ErrorHandler();
        public Menu()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            using (Lobby lobby = new Lobby())
            {
                if (lobby.ShowDialog() == DialogResult.OK)
                {
                    string matchContent = lobby.SelectedItem;
                    string[] matchContentList = matchContent.Split(',');
                    txtIdMatch.Text = matchContentList[0];
                }
            }
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            clearFields();
            using (NewGame game = new NewGame())
            {
                if (game.ShowDialog() == DialogResult.OK)
                {
                    txtIdMatch.Text = game.matchId;
                    txtPasswordCurrentMatch.Text = game.matchPassword;
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string matchId = txtIdMatch.Text;
            string playerName = txtPlayerName.Text;
            string matchPassword = txtPasswordCurrentMatch.Text;

            if (errorHandler.IsFieldBlank("Id da partida", matchId) || 
                errorHandler.IsFieldBlank("Nome do jogador", playerName) ||
                errorHandler.IsFieldBlank("Senha da partida", matchPassword) ||
                errorHandler.IsFieldContainsSpecialCharacters("Id da partida", matchId))
            {
                return;
            }

            string credentials = Jogo.Entrar(Convert.ToInt32(matchId), playerName, matchPassword);

            if (errorHandler.checkForError(credentials))
            {
                return;
            }

            credentials = credentials.Replace("\r", "");
            credentials = credentials.Substring(0, credentials.Length);
            string[] matchListSanitized = credentials.Split(',');

            int playerId = Convert.ToInt32(matchListSanitized[0]);
            string playerPassword = matchListSanitized[1];

            Game game = new Game(playerId, playerName, playerPassword, Convert.ToInt32(txtIdMatch.Text), matchPassword);

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

        private void label6_Click(object sender, EventArgs e)
        {            
        }
    }
}
