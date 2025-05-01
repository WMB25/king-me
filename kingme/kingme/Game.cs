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

        private string SelectedCharacter;

        private void SelectedRandomCharacter()
        {
            try
            {

                if (characterList == null || characterList.Length == 0)
                {
                    throw new Exception("Lista de personagens não carregada");
                }

                Random rand = new Random();
                int index = rand.Next(characterList.Length);
                SelectedCharacter = characterList[index];

                MessageBox.Show($"Personagem selecionado: {SelectedCharacter}", "Seu Personagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                errorHandler.ThrowMessageError($"Erro a selecionar personagem: {ex.Message}");
            }
        }

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

            if (characterList == null || characterList.Length == 0)
            {
                throw new ArgumentException("Lista de personagens não foi carregada corretamente");
            }
            SelectedRandomCharacter();

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
            if (errorHandler.checkForError(turn))
            {
                return;
            }

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
                if (character.Item1.Checked && !string.IsNullOrEmpty(character.Item2) && avaliableCharacters.Contains(character.Item2))
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
            if (errorHandler.checkForError(gameState)) { return; }

            string[] parts = gameState.Split(',');
            if (parts.Length < 4) { return; }

            string phase = parts[3].Trim().ToUpper();
            string currentPlayeerId = parts[0].Trim();

            if(currentPlayeerId != player.GetId().ToString())
            {
                if (!isMessageDisplayed)
                {
                    errorHandler.ThrowMessageError("Não é a vez deste jogador");
                    isMessageDisplayed = true;
                }
                return;
            }
            isMessageDisplayed = false;
            
            switch (phase)
            {
                case "S":
                    automateSetup();
                    break;
                case "P":
                    automatePromotion();
                    break;
                case "V":
                    automateVoting();
                    break;
            }

        }

        private IEnumerable<string> GetPrioritizedCharacters()
        {
            string playerCards = player.GetCards();
            char[] cardsInitial = playerCards.ToCharArray();

            return this.avaliableCharacters.OrderByDescending(c => cardsInitial.Contains(c[0])).ThenBy(c => c);
        }

        private void SelectCharacterByInitial(string initial)
        {
            var characterMap = new Dictionary<string, RadioButton>
            {
                {"A", rdoAdilson}, {"B", rdoBeatriz}, {"C", rdoClaro},
                {"D", rdoDouglas}, {"E", rdoEduardo}, {"G", rdoGuilherme},
                {"H", rdoHeredia}, {"K", rdoKelly}, {"L", rdoLeonardo},
                {"M", rdoMario}, {"Q", rdoQuintas}, {"R", rdoRanulfo},
                {"T", rdoToshio}
            };

            if (characterMap.TryGetValue(initial, out RadioButton radioButton))
            {
                radioButton.Checked = true;
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

            foreach (string character in avaliableCharacters)
            {
                string characterInitialLetter = character.Substring(0, 1).ToUpper();
                bool characterPlaced = false;

                foreach (int sector in sectorsList)
                {
                    var result = Jogo.ColocarPersonagem(player.GetId(), player.GetPassword(), sector, characterInitialLetter);

                    if (errorHandler.checkForError(result))
                    {
                        characterPlaced = true;
                        break;
                    }
                }

                if (!characterPlaced)
                {
                    foreach (int sector in sectorsList)
                    {
                        int upperSector = sector + 1;
                        if (!sectorsList.Contains(upperSector)) continue;

                        var result = Jogo.ColocarPersonagem(player.GetId(), player.GetPassword(), upperSector, characterInitialLetter);

                        if (errorHandler.checkForError(result))
                        {
                            characterPlaced = true;
                            break;
                        }
                    }
                }
            }
        }

        private bool isProcessing = false;
        private void tmrAutomacao_Tick(object sender, EventArgs e)
        {
            if (isProcessing) { return; }

            isProcessing = true;

            try
            {
                string gameState = Jogo.VerificarVez(match.GetId());
                if (errorHandler.checkForError(gameState))
                {
                    if (!isMessageDisplayed)
                    {
                        errorHandler.ThrowMessageError("Erro ao verificar o estado do jogo.");
                        isMessageDisplayed = true;
                    }
                    return;
                }

                if (gameState.Contains(",J,"))
                {
                    verifyTurn();
                }
                else if (!isMessageDisplayed)
                {
                    errorHandler.ThrowMessageError("A partida não iniciou");
                    isMessageDisplayed = true;
                }
            }
            catch (Exception ex)
            {
                if (!isMessageDisplayed)
                {
                    errorHandler.ThrowMessageError($"Erro na automação: {ex.Message}");
                    isMessageDisplayed = true;
                }
            }
            finally
            {
                isProcessing = false;
            }
        }

        private void automatePromotion()
        {
            //Não mudado
            try
            {
                var characterBySector = GetCharacterBySector();

                foreach (var sectorEntry in characterBySector.OrderBy(s => s.Key))
                {
                    foreach (string characterInitial in sectorEntry.Value)
                    {
                        if (IsValidCharacter(characterInitial))
                        {
                            if (avaliableCharacters.Any(c => c.StartsWith(characterInitial)))
                            {
                                SelectCharacterByInitial(characterInitial);

                                string result = Jogo.Promover(player.GetId(), player.GetPassword(), characterInitial);

                                if (!errorHandler.checkForError(result))
                                {
                                    removeCharacterFromList(characterInitial);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorHandler.ThrowMessageError($"Erro nas Promoções: {ex.Message}");
            }
        }

        private void automateVoting()
        {
            string turn = Jogo.VerificarVez(match.GetId());
            if (errorHandler.checkForError(turn)) { return; }

            string throneCharacter = GetThroneCharacter();
            if (throneCharacter == SelectedCharacter.Substring(0, 1).ToUpper())
            {
                DialogResult result = MessageBox.Show($"Seu Personagem ({SelectedCharacter}) esta no trono. Deseja votar Sim para elegê-lo como rei?", "Votação para Rei", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                bool vote = result == DialogResult.Yes;
                Jogo.Votar(player.GetId(), player.GetPassword(), (vote ? "S" : "N"));
            }
            else
            {
                Jogo.Votar(player.GetId(), player.GetPassword(), "N");
            }
            automateVerifyTurn();
        }

        private bool isMessageDisplayed = false;
        private void automateSetup()
        {
            if(avaliableCharacters == null || avaliableCharacters.Length == 0)
            {
                errorHandler.ThrowMessageError("Nenhum personagem disponivel para Setup");
                return;
            }
            
            foreach(string character in avaliableCharacters.ToArray())
            {
                string characterInitial = character.Substring(0, 1).ToUpper();
                foreach(int sector in new[] {3, 2, 1 })
                {
                    if(sectorsList.Count(s => s == sector) < 4)
                    {
                        string result = Jogo.ColocarPersonagem(player.GetId(), player.GetPassword(), sector, characterInitial);

                        if (!errorHandler.checkForError(result))
                        {
                            removeCharacterFromList(characterInitial);
                            break;
                        }
                    }
                }
            }
        }

        private bool IsValidCharacter(string initial)
        {
            return !string.IsNullOrEmpty(initial) && initial.Length == 1 && char.IsLetter(initial[0]);
        }

        private Dictionary<int, List<string>> GetCharacterBySector()
        {
            var characters = new Dictionary<int, List<string>>();
            string gameState = Jogo.VerificarVez(match.GetId());
            if (errorHandler.checkForErrorAutomate(gameState)) { return characters; }

            foreach (string line in gameState.Split('\n').Skip(1))
            {
                if (string.IsNullOrEmpty(line)) { continue; }

                string[] parts = line.Split(',');
                if (parts.Length >= 2 && int.TryParse(parts[0], out int sector))
                {
                    string initial = parts[1];
                    if (!characters.ContainsKey(sector))
                    {
                        characters[sector] = new List<string>();
                    }
                    characters[sector].Add(initial);
                }
            }
            return characters;
        }        

        private string GetThroneCharacter()
        {
            string gameState = Jogo.VerificarVez(match.GetId());
            if (errorHandler.checkForError(gameState)) { return null; }

            foreach (string line in gameState.Split('\n').Skip(1))
            {
                if (line.StartsWith("10, "))
                {
                    return line.Split(',')[1];
                }
            }
            return null;
        }

        private bool ShouldVoteFor(string characterInitial)
        {
            if (characterInitial == null) { return false; }

            string playerCards = player.GetCards();
            return playerCards.Contains(characterInitial);
        }
    }
}
