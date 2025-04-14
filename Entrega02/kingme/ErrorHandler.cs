using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kingme
{
    class ErrorHandler
    {
        private string message { get; set; }
        private string title { get; set; }
        public bool checkForError(string content)
        {
            if (content.Contains("ERRO"))
            {
                string errorMessage = content.Substring(5);
                ThrowMessageError(errorMessage);
                return true;
            }
            return false;
        }

        public bool checkForErrorAutomate(string content)
        {
            return content.Contains("ERRO");
        }

        public bool IsFieldBlank(string field, string content)
        {
            string validationMessage = "O campo " + field + " não pode ser vazio";
            if (string.IsNullOrEmpty(content))
            {
                ThrowMessageError(validationMessage);
                return true;
            }

            return false;
        }

        public bool IsFieldContainsSpecialCharacters(string field, string content)
        {
          string validationMessage = "O campo " + field + " só pode conter números";
          if (!int.TryParse(content, out int result))
          {
                ThrowMessageError(validationMessage);
                return true;
          }
                return false;
        }

        public void ThrowMessageError(string errorMessage)
        {
            System.Windows.Forms.MessageBox.Show(errorMessage, "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public string[] SanitizeList(string content)
        {
            string[] list = new string[] {};
            if (string.IsNullOrEmpty(content))
            {
                return list;
            }
            content = content.Replace("\r", "");
            content = content.Substring(0, content.Length - 1);
            list = content.Split('\n');
            return list;
        }

        public bool IsCredentialsOk(string playerId, string playerPassword)
        {
            var validations = new[]
            {
             new Tuple<string, string>(playerId, "O id do jogador não pode ser vazio"),
             new Tuple<string, string>(playerPassword, "A senha do jogador não pode ser vazia"),
            };

            foreach (var entry in validations)
            {
                if (string.IsNullOrWhiteSpace(entry.Item1))
                {
                    ThrowMessageError(entry.Item2);
                    return false;
                }

            }
            return true;
        }

    }
}
