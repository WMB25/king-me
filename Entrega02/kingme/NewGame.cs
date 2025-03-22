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
        ErrorHandler errorHandler = new ErrorHandler();
        public NewGame()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        }

        private void btnCreateNewMatch_Click(object sender, EventArgs e)
        {
            string newMatchName = txtMatchName.Text.Trim();
            string matchPassword = txtPasswordMatch.Text.Trim();
            string matchGroupName = txtGroupNameMatch.Text.Trim();
            
            if (errorHandler.IsFieldBlank("Nome da partida", newMatchName) ||
                errorHandler.IsFieldBlank("Senha", newMatchName) || 
                errorHandler.IsFieldBlank("Nome do grupo", newMatchName))
            {
                return;
            }

            string id = Jogo.CriarPartida(newMatchName, matchPassword, matchGroupName);

            if (errorHandler.IsGameMethodReturnError(id))
            {
                return;
            }
            
            string matchCreatedMessage = "A partida de id " + id + " foi criada com sucesso!";
            MessageBox.Show(matchCreatedMessage, "Partida criada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cleanFields();
        }

        private void cleanFields()
        {
            txtGroupNameMatch.Clear();
            txtMatchName.Clear();
            txtPasswordMatch.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
