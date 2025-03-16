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

namespace kingme
{
    public partial class NewGame: Form
    {
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

            if (!createMatchValidation(newMatchName, matchPassword, matchGroupName))
            {
                return;
            }

            string id = Jogo.CriarPartida(newMatchName, matchPassword, matchGroupName);

            if (id.Contains("ERRO"))
            {
                string errorMessage = id.Substring(5);
                MessageBox.Show(errorMessage, "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string matchCreatedMessage = "A partida de id " + id + " foi criada com sucesso!";
                MessageBox.Show(matchCreatedMessage, "Partida criada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanFields();
            } 
        }

        public bool createMatchValidation(string newMatchName, string matchPassword, string matchGroupName)
        {
            var validations = new[]
            {
                new Tuple<string, string>(newMatchName, "O nome da partida não pode ser vazio"),
                new Tuple<string, string>(matchPassword, "A senha não pode ser vazia"),
                new Tuple<string, string>(matchGroupName, "O nome do grupo não pode ser vazio"),
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

        private void lblTeam_Click(object sender, EventArgs e)
        {

        }
    }
}
