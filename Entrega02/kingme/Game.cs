using KingMeServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kingme
{
    public partial class Game : Form
    {
        public string PlayerId { get; set; }
        public string PlayerPass { get; set; }
        public string MatchId { get; set; }
        private string[] MatchPlayersList { get; set; }
        private string[] CharacterList { get; set; }

        Player player = new Player();
        public Game()
        {
            InitializeComponent();
            ListCharacters();
            lblVersion.Text = Jogo.versao;
        }

        public void UpdateGameContent()
        {
            txtPlayerId.Text = player.Id.ToString();
            txtPlayerPassword.Text = PlayerPass;
        }
        private void Game_Load(object sender, EventArgs e)
        {
        }
        private void BtnInitializeMatch_Click(object sender, EventArgs e)
        {            
            if (!InitializeMatchValidations(this.PlayerId, this.PlayerPass))
            {
                return;
            }

            string inicio = Jogo.Iniciar(Convert.ToInt32(this.PlayerId), this.PlayerPass);

            if (ErrorPopUpGenerate(inicio))
            {
                return;
            }

            MessageBox.Show("A partida foi iniciada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LstMatchPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public bool InitializeMatchValidations(string playerId, string playerPassword)
        {
            //SIMPLIFICADO

            var validations = new[]            
            {                        
             new Tuple<string, string>(playerId, "O id do jogador não pode ser vazio"),
             new Tuple<string, string>(playerPassword, "A senha do jogador não pode ser vazia"),
            };

                foreach (var entry in validations)
                {
                    if (string.IsNullOrWhiteSpace(entry.Item1))
                    {
                        MessageBox.Show(entry.Item2, "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            return true;
        }

        private void GetListOfPlayers()
        {
            //Reorganizado
            string matchPlayersContent = Jogo.ListarJogadores(Convert.ToInt32(this.MatchId));
            MatchPlayersList = matchPlayersContent.Replace("\r", "").Split('\n');
        }

        private void UpdatePlayerList()
        {

            GetListOfPlayers();
            lstMatchPlayers.Items.Clear();

            if (this.MatchPlayersList[0] == "")
            {
                MessageBox.Show("Sem jogadores na partida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < MatchPlayersList.Length; i++)
            {
                string player = MatchPlayersList[i];
                lstMatchPlayers.Items.Add(MatchPlayersList[i]);
            }          
        }

        private void BtnUpdatePlayerList_Click(object sender, EventArgs e)
        {
            UpdatePlayerList();
        }

        private void BtnListCards_Click(object sender, EventArgs e)
        {
            string playerCards = ListPlayerCards();
            if (playerCards.Contains("Error"))
            {
                return;
            }
        }

        public bool ErrorPopUpGenerate(string content)
        {
            if (content.Contains("ERRO"))
            {
                string errorMessage = content.Substring(5);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void ListCharacters()
        {

            string characters = Jogo.ListarPersonagens();
            CharacterList = characters.Replace("\r", "").Split('\n');

            for (int i = 0; i < this.CharacterList.Length - 1; i++)
            {
                string character = this.CharacterList[i];
                lstFavorites.Items.Add(character);
            }
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ListPlayerCards()
        {
            string playerCards = Jogo.ListarCartas(Convert.ToInt32(txtPlayerId.Text), txtPlayerPassword.Text);

            if (ErrorPopUpGenerate(playerCards))
            {
                return "Error";
            }

            var listPlayerCards = playerCards.ToCharArray();

            foreach (var cardPrefix in listPlayerCards)
            {
                foreach (var character in CharacterList)
                {
                    if (character.StartsWith(cardPrefix.ToString()))
                    {
                        lstCards.Items.Add(character);
                    }
                }
            }

            return "Cartas listadas";
        }

        private void BtnSetCharacter_Click(object sender, EventArgs e)
        {
            if (GetCharacter() == "null" || lstSections.SelectedItem == null)
            {
                MessageBox.Show("Você deve selecionar um personagem e um setor", "Erro", MessageBoxButtons.OK);
                return;
            }

            string character = GetCharacter();
            string section = (string)lstSections.SelectedItem;
            string characterInitialLetter = character.Substring(0, 1).ToUpper();

            string setCharacter = Jogo.ColocarPersonagem(Convert.ToInt32(PlayerId), this.PlayerPass, Convert.ToInt32(section), characterInitialLetter);

            if (ErrorPopUpGenerate(setCharacter))
            {
                return;
            }

            setCharacter = setCharacter.Replace("\r", "");
            string[] listOfSections = setCharacter.Split('\n');


            for (int i = 0; i < listOfSections.Length; i++)
            {
                string currentSection = listOfSections[i];
            }           
        }

        private void BtnVerifyTurn_Click(object sender, EventArgs e)
        {
            string turn = Jogo.VerificarVez(Convert.ToInt32(this.MatchId));
            if (ErrorPopUpGenerate(turn))
            {
                return;
            }

            var turnStateList = turn.Replace("\r", "").Split('\n');
            var currentTurnPlayerContent = turnStateList[0].Split(',');
            GetListOfPlayers();

            foreach (var player in MatchPlayersList)
            {
                var playerContent = player.Split(',');

                if (playerContent[0] == currentTurnPlayerContent[0])
                {
                    lblPlayerIdValue.Text = currentTurnPlayerContent[0];
                    lblPlayerNameValue.Text = playerContent[1];
                    return;
                }
            }
        }

        public string GetCharacter()
        {
            var characters = new[]
            {
                    new Tuple<RadioButton, string>(rdoBeatriz, "Beatriz Paiva"),
                    new Tuple<RadioButton, string>(rdoAdilson, "Adilson Konrad"),
                    new Tuple<RadioButton, string>(rdoMario, "Mario Toledo"),
                    new Tuple<RadioButton, string>(rdoDouglas, "Douglas Baquiao"),
                    new Tuple<RadioButton, string>(rdoHeredia, "Heredia"),
                    new Tuple<RadioButton, string>(rdoClaro, "Claro"),
                    new Tuple<RadioButton, string>(rdoEduardo, "Eduardo Takeo"),
                    new Tuple<RadioButton, string>(rdoGuilherme, "Guilherme Rey"),
                    new Tuple<RadioButton, string>(rdoKelly, "Kelly Kiyumi"),
                    new Tuple<RadioButton, string>(rdoLeonardo, "Leonardo Takuno"),
                    new Tuple<RadioButton, string>(rdoToshio, "Toshio"),
                    new Tuple<RadioButton, string>(rdoQuintas, "Quintas"),
                    new Tuple<RadioButton, string>(rdoRanulfo, "Ranulfo"),
                };

            foreach (var character in characters)
            {
                if (character.Item1.Checked)
                {
                    return character.Item2;
                }
            }
            return "null";
        }

        private void btnRanulfo_Click(object sender, EventArgs e)
        {

        }
    }
}
