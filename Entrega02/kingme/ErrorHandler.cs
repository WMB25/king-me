using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kingme
{
    class ErrorHandler
    {
        public bool IsGameMethodReturnError(string content)
        {
            if (content.Contains("ERRO"))
            {
                string errorMessage = content.Substring(5);
                CreateMessageBox(errorMessage);
                return true;
            }
            return false;
        }

        public bool IsFieldBlank(string field, string content)
        {
            string validationMessage = "O campo " + field + " não pode ser vazio";
            if (string.IsNullOrEmpty(content))
            {
                CreateMessageBox(validationMessage);
                return true;
            }

            return false;
        }

        public bool IsFieldContainsSpecialCharacters(string field, string content)
        {
          string validationMessage = "O campo " + field + " só pode conter números";
          if (!int.TryParse(content, out int result))
          {
                CreateMessageBox(validationMessage);
                return true;
          }
                return false;
        }

        public void CreateMessageBox(string errorMessage)
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
    }
}
