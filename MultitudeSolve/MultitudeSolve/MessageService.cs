using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultitudeSolve
{
    public interface IMessageService
    {
        void ShowExclamation(string exclamation);
        void ShowErrorRelation(string errorRelation);
        void ShowErrorAddition(string errorAddition);
    }
    class MessageService: IMessageService
    {
        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowErrorRelation (string errorRelation)
        {
            MessageBox.Show(errorRelation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void ShowErrorAddition (string errorAddition)
        {
            MessageBox.Show(errorAddition, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
