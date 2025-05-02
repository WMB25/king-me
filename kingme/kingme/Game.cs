//Ultimo envio

using KingMeServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public string playerId { get; set; }
        public string playerPass { get; set; }
        public string matchId { get; set; }
        private string[] characterList { get; set; }
        private string[] avaliableCharacters { get; set; }
        private int[] sectorsList { get; set; }

        private int messageDisplayTime = 0;

        Match match = new Match();
        Player player = new Player();
        ErrorHandler errorHandler = new ErrorHandler();

        public Game(int playerId, string playerName, string playerPassword, int matchId, string matchPassword)
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;

            match.SetId(matchId);
            match.SetPassword(matchPassword);

            player.SetId(playerId);
            player.SetName(playerName);
            player.SetPassword(playerPassword);

            this.characterList = new string[]{
                "Adilson Konrad",
                "Beatriz Paiva",
                "Claro",
                "Douglas Baquiao",
                "Eduardo Takeo",
                "Guilherme Rey",
                "Heredia",
                "Kelly Kiyumi",
                "Leonardo Takuno",
                "Mario Toledo",
                "Quintas",
                "Ranulfo",
                "Toshio",
            };

            this.avaliableCharacters = new string[]{
                "Adilson Konrad",
                "Beatriz Paiva",
                "Claro",
                "Douglas Baquiao",
                "Eduardo Takeo",
                "Guilherme Rey",
                "Heredia",
                "Kelly Kiyumi",
                "Leonardo Takuno",
                "Mario Toledo",
                "Quintas",
                "Ranulfo",
                "Toshio",
            };

            this.sectorsList = new int[]
            {
                1,
                2,
                3,
                4,
                5,
            };

            tmrAutomacao.Enabled = true;
        }

        public void updateGameContent()
        {
            txtPlayerId.Text = player.GetId().ToString();
            txtPlayerPassword.Text = player.GetPassword();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void btnInitializeMatch_Click(object sender, EventArgs e)
        {
            int playerId = player.GetId();
            string playerPassword = player.GetPassword();


            MessageBox.Show("A partida foi iniciada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            player.initializeGame();
            automateVerifyTurn();
        }

        private void updatePlayerList()
        {
            List<string> players = match.GetPlayers(match.GetId());
            lstMatchPlayers.Items.Clear();

            for (int i = 0; i < players.Count; i++)
            {
                string player = players[i];
                lstMatchPlayers.Items.Add(player);
            }
        }

        private void btnUpdatePlayerList_Click(object sender, EventArgs e)
        {
            updatePlayerList();
        }

        private void btnListCards_Click(object sender, EventArgs e)
        {
            listPlayerCards();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listPlayerCards()
        {
            string playerCards = player.GetCards();

            if (String.IsNullOrEmpty(playerCards))
            {
                return;
            }

            char[] listPlayerCards = playerCards.ToCharArray();

            for (int i = 0; i < listPlayerCards.Length - 1; i++)
            {
                char cardPrefix = listPlayerCards[i];
                foreach (string character in this.characterList)
                {
                    if (character.StartsWith(cardPrefix.ToString()))
                    {
                        lstCards.Items.Add(character);
                    }
                }
            }

            return;
        }

        private void btnSetCharacter_Click(object sender, EventArgs e)
        {
            if (getCharacter() == "null" || lstSections.SelectedItem == null)
            {
                MessageBox.Show("Você deve selecionar um personagem e um setor", "Erro", MessageBoxButtons.OK);
                return;
            }

            string character = getCharacter();
            string section = (string)lstSections.SelectedItem;
            string characterInitialLetter = character.Substring(0, 1).ToUpper();

            string setCharacter = Jogo.ColocarPersonagem(Convert.ToInt32(this.playerId), this.playerPass, Convert.ToInt32(section), characterInitialLetter);

            if (errorHandler.checkForError(setCharacter))
            {
                return;
            }
            automateVerifyTurn();
        }

        private void btnVerifyTurn_Click(object sender, EventArgs e)
        {
            automateVerifyTurn();
        }

        public void automateVerifyTurn()
        {
            string turn = Jogo.VerificarVez(match.GetId());           

            turn = turn.Replace("\r", "");
            string[] turnStateList = turn.Split('\n');

            string currentTurnPlayer = turnStateList[0];
            string[] currentTurnPlayerContent = currentTurnPlayer.Split(',');

            for (int i = 0; i < turnStateList.Length; i++)
            {
                string currentTurn = turnStateList[i];
            }

            List<string> players = match.GetPlayers(match.GetId());

            for (int i = 0; i < players.Count - 1; i++)
            {
                string player = players[i];
                string[] playerContent = player.Split(',');

                if (playerContent[0] == currentTurnPlayerContent[0])
                {
                    lblPlayerIdValue.Text = currentTurnPlayerContent[0];
                    lblPlayerNameValue.Text = playerContent[1];
                }
            }
            if (turnStateList.Length > 2)
            {
                setCharacterInSector(turnStateList);
            }

        }

        public string getCharacter()
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

        public void setCharacterInSector(string[] gameState)
        {
            clearSectors();
            var sectors = new[]
            {
              new Tuple<int, PictureBox>(0, pboSetorZero),
              new Tuple<int, PictureBox>(1, pboSetorUm),
              new Tuple<int, PictureBox>(2, pboSetorDois),
              new Tuple<int, PictureBox>(3, pboSetorTres),
              new Tuple<int, PictureBox>(4, pboSetorQuatro),
              new Tuple<int, PictureBox>(5, pboSetorCinco),
              new Tuple<int, PictureBox>(10, pboSetorDez),
           };

            for (int i = 1; i < gameState.Length - 1; i++)
            {
                string[] characterDetails = gameState[i].Split(',');
                int characterSector = Convert.ToInt32(characterDetails[0]);
                string characterInitial = characterDetails[1];

                foreach (var sector in sectors)
                {
                    if (sector.Item1 == characterSector)
                    {
                        Button clonedButton = cloneButton(getCharacterButton(characterInitial));
                        AddButtonSmart(sector.Item2, clonedButton);
                    }
                }
            }
        }

        public Button getCharacterButton(string initialLetter)
        {
            var characterButtons = new[]
            {
              new Tuple<string, Button>("A", btnAdilson),
              new Tuple<string, Button>("B", btnBeatrizPaiva),
              new Tuple<string, Button>("C", btnClaro),
              new Tuple<string, Button>("D", btnDouglas),
              new Tuple<string, Button>("E", btnEduardo),
              new Tuple<string, Button>("G", btnGuilherme),
              new Tuple<string, Button>("H", btnHeredia),
              new Tuple<string, Button>("K", btnKelly),
              new Tuple<string, Button>("L", btnLeonardo),
              new Tuple<string, Button>("M", btnMario),
              new Tuple<string, Button>("Q", btnQuintas),
              new Tuple<string, Button>("R", btnRanulfo),
              new Tuple<string, Button>("T", btnToshio),
           };

            foreach (var characterButton in characterButtons)
            {
                if (characterButton.Item1 == initialLetter)
                {
                    return characterButton.Item2;
                }
            }

            return new Button();
        }
        public bool AddButtonSmart(PictureBox pictureBox, Button button)
        {
            Point originalPos = button.Location;

            if (!IsOverlapping(pictureBox, button))
            {
                pictureBox.Controls.Add(button);
                button.BringToFront();
                return true;
            }

            int maxX = pictureBox.ClientSize.Width - button.Width;
            int maxY = pictureBox.ClientSize.Height - button.Height;

            int gridSpacing = 10;

            for (int y = 0; y <= maxY; y += gridSpacing)
            {
                for (int x = 0; x <= maxX; x += gridSpacing)
                {
                    button.Location = new Point(x, y);

                    if (!IsOverlapping(pictureBox, button))
                    {
                        pictureBox.Controls.Add(button);
                        button.BringToFront();
                        return true;
                    }
                }
            }

            gridSpacing = 5;

            for (int y = 0; y <= maxY; y += gridSpacing)
            {
                for (int x = 0; x <= maxX; x += gridSpacing)
                {
                    button.Location = new Point(x, y);

                    if (!IsOverlapping(pictureBox, button))
                    {
                        pictureBox.Controls.Add(button);
                        button.BringToFront();
                        return true;
                    }
                }
            }

            button.Location = originalPos;

            pictureBox.Controls.Add(button);
            button.BringToFront();

            return false;
        }

        private bool IsOverlapping(PictureBox pictureBox, Button button)
        {
            foreach (Control control in pictureBox.Controls)
            {
                if (!(control is Button) || control == button)
                    continue;

                if (button.Bounds.IntersectsWith(control.Bounds))
                {
                    return true;
                }
            }

            return false;
        }

        public Button cloneButton(Button button)
        {
            Button characterBtn = new Button();

            characterBtn.Size = button.Size;
            characterBtn.FlatStyle = button.FlatStyle;
            characterBtn.BackgroundImage = button.BackgroundImage;
            characterBtn.Name = button.Name;
            characterBtn.BackColor = button.BackColor;
            characterBtn.ForeColor = button.ForeColor;
            characterBtn.FlatAppearance.BorderSize = button.FlatAppearance.BorderSize;
            return characterBtn;
        }

        public void clearSectors()
        {
            pboSetorZero.Controls.Clear();
            pboSetorUm.Controls.Clear();
            pboSetorDois.Controls.Clear();
            pboSetorTres.Controls.Clear();
            pboSetorQuatro.Controls.Clear();
            pboSetorCinco.Controls.Clear();
            pboSetorDez.Controls.Clear();
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (getCharacter() == "null" || lstSections.SelectedItem == null)
            {
                MessageBox.Show("Você deve selecionar um personagem e um setor", "Erro", MessageBoxButtons.OK);
                return;
            }

            string character = getCharacter();
            string characterInitialLetter = character.Substring(0, 1).ToUpper();
            Jogo.Promover(Convert.ToInt32(this.playerId), this.playerPass, characterInitialLetter);
            automateVerifyTurn();
        }

        private string[] getCurrentGameTurn(string[] turnStateList)
        {
            string currentState = turnStateList[0];
            string[] currentStateList = currentState.Split(',');
            return currentStateList;
        }

        private string[] getCurrentTablePosition(string[] turnStateList)
        {
            List<string> tablePositionList = new List<string>(turnStateList);
            tablePositionList.RemoveAt(0);
            turnStateList = tablePositionList.ToArray();
            return turnStateList;
        }

        private void updateAvaliableCharacters(string[] turnStateList)
        {
            string[] currentTablePositionList = getCurrentTablePosition(turnStateList);
            for (int i = 0; i < currentTablePositionList.Length - 1; i++)
            {
                string line = currentTablePositionList[i];
                if (String.IsNullOrEmpty(line))
                {
                    break;
                }

                string[] characterDetails = currentTablePositionList[i].Split(',');
                string initialLetter = characterDetails[1];
                removeCharacterFromList(initialLetter);
            }
        }

        private void removeCharacterFromList(string initialLetter)
        {
            List<string> characters = new List<string>(this.avaliableCharacters);
            characters.RemoveAll(item => item.StartsWith(initialLetter, StringComparison.OrdinalIgnoreCase));
            this.avaliableCharacters = characters.ToArray();
        }

        private void verifyTurn()
        {
            string gameState = Jogo.VerificarVez(match.GetId());
            
            gameState = gameState.Replace("\r", "");
            string[] gameStateList = gameState.Split('\n');
            automateVerifyTurn();

            string[] turn = getCurrentGameTurn(gameStateList);
            string turnPlayerId = turn[0];
            string playerId = player.GetId().ToString();
            if (turnPlayerId == playerId)
            {
                string phase = turn[turn.Length - 1].ToUpper();

                if (phase == "S")
                {
                    if (getCurrentTablePosition(gameStateList).Length != 0)
                    {
                        updateAvaliableCharacters(gameStateList);
                        updateAvaliableSectors(gameStateList);
                    }

                    string characterInitialLetter = this.avaliableCharacters[0].Substring(0, 1);
                    var setCharacter = Jogo.ColocarPersonagem(player.GetId(), player.GetPassword(), this.sectorsList[0], characterInitialLetter);

                    automateVerifyTurn();
                }
                else if (phase == "P")
                {
                    automatePromotion();
                }
                else if (phase == "V")
                {
                    automateVoting();
                }
            }

            return;
        }

        public void updateAvaliableSectors(string[] turnStateList)
        {
            int[] avaliableSectors = new int[] { };
            string[] currentTablePositionList = getCurrentTablePosition(turnStateList);
            for (int i = 0; i < currentTablePositionList.Length - 1; i++)
            {
                string line = currentTablePositionList[i];
                if (String.IsNullOrEmpty(line))
                {
                    break;
                }

                string[] characterDetails = currentTablePositionList[i].Split(',');
                int characterSector = Convert.ToInt32(characterDetails[0]);
                List<int> avaliableSectorsList = new List<int>();
                avaliableSectorsList.Add(characterSector);
                avaliableSectors = avaliableSectors.Concat(avaliableSectorsList.ToArray()).ToArray();
            }

            for (int j = 0; j < avaliableSectors.Length - 1; j++)
            {
                int sector = avaliableSectors[j];
                int sectorCount = avaliableSectors.Count(f => f == sector);
                if (sectorCount == 4)
                {
                    removeSectorFromList(sector);
                }
            }
        }

        private void removeSectorFromList(int sector)
        {
            List<int> sectors = new List<int>(this.sectorsList);
            sectors.Remove(sector);
            this.sectorsList = sectors.ToArray();
        }

        public void setCharacterAutomate()
        {
            clearSectors();
            var sectors = new[]
            {
                new Tuple<int, PictureBox>(0, pboSetorZero),
                new Tuple<int, PictureBox>(1, pboSetorUm),
                new Tuple<int, PictureBox>(2, pboSetorDois),
                new Tuple<int, PictureBox>(3, pboSetorTres),
                new Tuple<int, PictureBox>(4, pboSetorQuatro),
                new Tuple<int, PictureBox>(5, pboSetorCinco),
                new Tuple<int, PictureBox>(10, pboSetorDez),
            };

            foreach (string character in avaliableCharacters)
            {
                string characterInitialLetter = character.Substring(0, 1).ToUpper();
                bool characterPlaced = false;

                foreach (int sector in sectorsList)
                {
                    var result = Jogo.ColocarPersonagem(player.GetId(), player.GetPassword(), sector, characterInitialLetter);                    
                }

                if (!characterPlaced)
                {
                    foreach (int sector in sectorsList)
                    {
                        int upperSector = sector + 1;
                        if (!sectorsList.Contains(upperSector)) continue;

                        var result = Jogo.ColocarPersonagem(player.GetId(), player.GetPassword(), upperSector, characterInitialLetter);
                    }
                }
            }
        }

        private void tmrAutomacao_Tick(object sender, EventArgs e)
        {
            if (messageDisplayTime > 0)
            {
                messageDisplayTime -= tmrAutomacao.Interval;

            }
            verifyTurn();
        }

        private void automatePromotion()
        {
            List<string> charactersOnBoard = GetCharactersOnBoard();

            if (charactersOnBoard.Count == 0) { return; }

            //logica 

            foreach (string initial in charactersOnBoard)
            {
                var result = Jogo.Promover(player.GetId(), player.GetPassword(), initial);
            }

            automateVerifyTurn();
        }

        private void automateVoting()
        {
            if (avaliableCharacters.Length == 0)
            {
                return;
            }

            //Quest
            //DialogResult result = MessageBox.Show("Você deseja eleger o personagem?", "Confirmação de Voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //string vote = result == DialogResult.Yes ? "S" : "N";
            //Jogo.Votar(player.GetId(), player.GetPassword(), vote);            

            foreach (string character in avaliableCharacters)
            {
                string vote = "S";//Retirar voto fixo
                Jogo.Votar(player.GetId(), player.GetPassword(), vote);
            }

            tmrAutomacao.Enabled = false;
            automateVerifyTurn();
        }
        private List<string> GetCharactersOnBoard()
        {
            List<string> charactersOnBoard = new List<string>();

            var gameState = Jogo.VerificarVez(match.GetId());            

            gameState = gameState.Replace("\r", "");
            string[] gameStateList = gameState.Split('\n');

            foreach (string line in gameStateList)
            {
                if (string.IsNullOrEmpty(line)) continue;

                string[] characterDetails = line.Split(',');
                if (characterDetails.Length > 1)
                {
                    charactersOnBoard.Add(characterDetails[1]);
                }
            }
            return charactersOnBoard;
        }
    }
}
