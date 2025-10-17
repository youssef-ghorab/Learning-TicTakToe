using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tak_Toe
{
    public partial class NewGameForm : Form
    {
        public class GameSettings
        {
            public int roudnsNumber;
            public char p1Symbole;
            public char p2Symbole;
            public string p1Name;
            public string p2Name;

            public GameSettings(int rounds_number , char p1_symbole, char p2_symbole,string p1_name, string p2_name)
            {
                roudnsNumber = rounds_number;
                p1Symbole = p1_symbole;
                p2Symbole = p2_symbole;
                p1Name = p1_name;
                p2Name = p2_name;
            }
        }

        GameSettings _gameSettings;

        public NewGameForm()
        {
            InitializeComponent();
        }

        public GameSettings gameSettings
        {
            private set { _gameSettings = value; }
            get { return _gameSettings; }
        }

        bool isNumber(string str)
        {
            if (!str.Any())
                return false;
            foreach (char ch in str)
                if (!char.IsDigit(ch))
                    return false;
            return true;
        }

        List<TextBox> getUnreadyCntrls()
        {
            List<TextBox> inputCntrls = new List<TextBox>();
            if (!p1SymboleTxtBx.Text.Any())
                inputCntrls.Add(p1SymboleTxtBx);
            if (!p2SymboleTxtBx.Text.Any())
                inputCntrls.Add(p2SymboleTxtBx);
            if (!p1NameTxtBx.Text.Any())
                inputCntrls.Add(p1NameTxtBx);
            if (!p2NameTxtBx.Text.Any())
                inputCntrls.Add(p2NameTxtBx);
            if (!isNumber(roundsNumberTxtBx.Text))
                inputCntrls.Add(roundsNumberTxtBx);
            return inputCntrls;
        }

        void showErrors(List<TextBox> unreadyCntrls)
        {
            ErrsLBL.Text = "";
            string invalideInputs = "";
            foreach (TextBox txtBx in unreadyCntrls)
            {
                if (invalideInputs.Any())
                    invalideInputs += ",";
                invalideInputs += (string)txtBx.Tag;
            }
            if (invalideInputs.Any())
                ErrsLBL.Text += "invalide (" + invalideInputs + ")";
        }

        private void onBtnClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Cancel")
                Close();
            else
            {
                List<TextBox> unreadyCntrls = getUnreadyCntrls();
                showErrors(unreadyCntrls);
                if (unreadyCntrls.Any())
                    return;
                GameForm gameForm;
                DialogResult dlgRslt;
                _gameSettings = new GameSettings(Convert.ToInt32(roundsNumberTxtBx.Text), p1SymboleTxtBx.Text[0], p2SymboleTxtBx.Text[0], p1NameTxtBx.Text, p2NameTxtBx.Text);
                gameForm = new GameForm(_gameSettings);
                dlgRslt = gameForm.ShowDialog();
                
                if (dlgRslt == DialogResult.Cancel)
                    Close();
            }
        }
    }
}
