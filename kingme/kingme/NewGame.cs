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
    public partial class NewGame: Form
    {
        public string matchId { get; private set; }
        public string matchPassword { get; private set; }
        ErrorHandler errorHandler = new ErrorHandler();
        public NewGame()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        }

        private void btnCreateNewMatch_Click(object sender, EventArgs e)
        {
            string groupName = "Guardiões de Windsor";
            string newMatchName = txtMatchName.Text.Trim();
            string newMatchPassword = txtPasswordMatch.Text.Trim();
            
            if (errorHandler.IsFieldBlank("Nome da partida", newMatchName) ||
                errorHandler.IsFieldBlank("Senha", newMatchPassword))
            {
                return;
            }

            string id = Jogo.CriarPartida(newMatchName, newMatchPassword, groupName);

            if (errorHandler.checkForError(id))
            {
                return;
            }
            
            string matchCreatedMessage = "A partida de id " + id + " foi criada com sucesso!";
            MessageBox.Show(matchCreatedMessage, "Partida criada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            matchId = id;
            matchPassword = newMatchPassword;
            DialogResult = DialogResult.OK;
            cleanFields();
            Close();
        }

        private void cleanFields()
        {
            txtMatchName.Clear();
            txtPasswordMatch.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
