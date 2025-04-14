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
        public string SelectedItem { get; private set; }
        ErrorHandler errorHandler = new ErrorHandler();
        public Lobby()
        {
            InitializeComponent();
            listMatches();
            lblVersion.Text = Jogo.versao;
        }

        private void listMatches()
        {
            string matchList = Jogo.ListarPartidas("T");
            if (errorHandler.checkForError(matchList))
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
        private void btnListMatches_Click(object sender, EventArgs e)
        {
            listMatches();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = lstMatches.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
