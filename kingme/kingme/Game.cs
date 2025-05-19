using KingMeServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace kingme
{
    public partial class Game : Form
    {
        public string playerId { get; set; }
        public string playerPass { get; set; }
        public string matchId { get; set; }
        private string[] characterList { get; set; }
        private static string[] avaliableCharacters { get; set; }
        private int[] sectorsList { get; set; }

        private bool test = true;

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

            avaliableCharacters = new string[]{
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
            btnInitializeMatch.Enabled = false; // Impede múltiplos cliques

            int playerId = player.GetId();
            string playerPassword = player.GetPassword();

            MessageBox.Show("A partida foi iniciada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            player.initializeGame();

            string choseCharacter = RamdolySelectCharacter();
            MessageBox.Show($"O seu personagem é: {choseCharacter}", "foi o personagem selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (choseCharacter == null)
            {
                MessageBox.Show("Erro ao sortear um personagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = player.positionCharacter(3, choseCharacter.Substring(0, 1).ToUpper());
            removeCharacterFromList(choseCharacter.Substring(0, 1).ToUpper());

            if (result == null)
            {
                for (int sector = 2; sector >= 1; sector--)
                {
                    result = player.positionCharacter(sector, choseCharacter.Substring(0, 1).ToUpper());
                    if (result != null)
                    {
                        break;
                    }
                }
            }

            if (result == null)
            {
                MessageBox.Show("Não foi possivel colocar no tabuleiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateAvailableCharacters();

            automateVerifyTurn();
        }

        private string RamdolySelectCharacter()
        {
            if (avaliableCharacters.Length == 0) return null;

            Random random = new Random();
            int index = random.Next(avaliableCharacters.Length);
            string selectedCharacter = avaliableCharacters[index];

            removeCharacterFromList(selectedCharacter.Substring(0, 1).ToUpper());
            UpdateAvailableCharacters(); // Atualiza UI

            return selectedCharacter;
        }

        private void UpdateAvailableCharacters()
        {
            var radioButtons = Controls.OfType<RadioButton>();
            foreach (var rb in radioButtons) rb.Checked = false;

            // Atualiza quais personagens estão disponíveis
            foreach (Control control in Controls)
            {
                if (control is RadioButton rb)
                {
                    string charName = rb.Tag?.ToString(); // Associe cada RadioButton ao nome do personagem
                    rb.Enabled = avaliableCharacters.Any(c => c == charName);
                }
            }
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
            if (errorHandler.checkForError(turn))
            {
                return;
            }

            turn = turn.Replace("\r", "");
            string[] turnStateList = turn.Split('\n');



            if (turnStateList.Length == 0)
            {
                errorHandler.ThrowMessageError("Estado do jogo inválido.");
                return;
            }
            string currentPhase = turnStateList[turnStateList.Length - 1].Trim().ToUpper();
            lblCurrentPhase.Text = currentPhase;

            string currentTurnPlayer = turnStateList[0];
            string[] currentTurnPlayerContent = currentTurnPlayer.Split(',');

            lblPlayerIdValue.Text = currentTurnPlayerContent[0];
            lblPlayerNameValue.Text = currentTurnPlayerContent[1];

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
            
            if (currentPhase == "S")
            {
                if (currentTurnPlayerContent[0] == player.GetId().ToString())
                {
                    //Peraonagem aleatorio
                    if(this.test != false)
                    {
                        EnableCharacterSelection();
                    }
                    else
                    {
                        Console.WriteLine("Adicionou");
                    }
                }
            }
            else if (currentPhase == "P")
            {
                if (currentTurnPlayerContent[0] == player.GetId().ToString())
                {
                    EnablePromotion();
                }
            }
            else if (currentPhase == "V")
            {
                if (currentTurnPlayerContent[0] == player.GetId().ToString())
                {
                    EnableVoting();
                }
            }

            if (turnStateList.Length > 2)
            {
                setCharacterInSector(turnStateList);
            }
        }

        private void EnableCharacterSelection()
        {
            // Habilitar a seleção de personagem
            // Por exemplo, habilitar botões ou opções na interface
        }

        private void EnablePromotion()
        {
            // Habilitar a promoção de personagem
            // Por exemplo, habilitar botões ou opções na interface
        }

        private void EnableVoting()
        {
            // Habilitar a votação
            // Por exemplo, habilitar botões ou opções na interface
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
            List<string> characters = new List<string>(avaliableCharacters);
            characters.RemoveAll(item =>
                item.StartsWith(initialLetter, StringComparison.OrdinalIgnoreCase));
           avaliableCharacters = characters.ToArray();
        }

        private void verifyTurn()
        {
            string gameState = Jogo.VerificarVez(match.GetId());

            if (errorHandler.checkForErrorAutomate(gameState))
            {
                return;
            }

            gameState = gameState.Replace("\r", "");
            string[] gameStateList = gameState.Split('\n');

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

                    if (avaliableCharacters.Length == 0)
                    {
                        errorHandler.ThrowMessageError("Não há personagens disponíveis.");
                        return;
                    }

                    string characterInitialLetter = RamdolySelectCharacter();
                    MessageBox.Show($"O seu personagem é: {characterInitialLetter}", "foi o personagem selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string setCharacter = Jogo.ColocarPersonagem(player.GetId(), player.GetPassword(), this.sectorsList[0], characterInitialLetter.Substring(0, 1).ToUpper());

                    if (errorHandler.checkForError(setCharacter))
                    {
                        return;
                    }
                }
            }
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


            Button clonedButton = cloneButton(getCharacterButton(avaliableCharacters[0].Substring(0, 1)));
            AddButtonSmart(sectors[this.sectorsList[0]].Item2, clonedButton);
        }

        private void tmrAutomacao_Tick(object sender, EventArgs e)
        {
            tmrAutomacao.Enabled = false;
            verifyTurn();
            tmrAutomacao.Enabled = true;
        }

        private void lstMatchPlayers_SelectedIndexChanged(object sender, EventArgs e) { }
        
        private void lstCards_SelectedIndexChanged(object sender, EventArgs e) { }        
    }
}

//Consertar a atualização de tela para ver em tempo real; Algo com o verificar a vez!
//Verificar o reconhecimento de vez (tanto para inicio quanto iniciado).