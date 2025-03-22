using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using static kingme.ErrorHandler;

namespace kingme
{
    public partial class Lobby: Form
    {
        ErrorHandler errorHandler = new ErrorHandler();
        public Lobby()
        {
            InitializeComponent();
            ListMatches();
            lblVersion.Text = Jogo.versao;
        }

        private void ListMatches()
        {
            string matchList = Jogo.ListarPartidas("T");
            if (errorHandler.IsGameMethodReturnError(matchList))
            {
                return;
            }

            string[] matchListValidated = errorHandler.SanitizeList(matchList);
            lstMatches.Items.Clear();
            for (int i = 0; i < matchListValidated.Length; i++)
            {
                lstMatches.Items.Add(matchListValidated[i]);
            }
        }

        private void BtnListMatches_Click(object sender, EventArgs e)
        {
            ListMatches();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSetRoom_Click(object sender, EventArgs e)
        {
            if (lstMatches.SelectedItem != null)
            {

                string selectedMatch = lstMatches.SelectedItem.ToString();
                string[] matchInfo = selectedMatch.Split(',');
                string matchId = matchInfo[0].Trim();

                if (this.Owner is Menu ownerMenu)
                {
                    ownerMenu.SetMatchID(matchId);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma partida antes de confirmar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
