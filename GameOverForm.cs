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
    public partial class GameOverForm : Form
    {
        public class GameOverInfo
        {
            public string p1Name;
            public string p2Name;
            public int p1Wins;
            public int p2Wins;
            public List<string> rndsList;
            public string winnerName;

            public GameOverInfo(string p1_name,string p2_name,int p1_wins,int p2_wins,List<string> rnds_list,string winner_name)
            {
                p1Name = p1_name;
                p2Name = p2_name;
                p1Wins = p1_wins;
                p2Wins = p2_wins;
                rndsList = rnds_list;
                winnerName = winner_name;
            }
        }

        GameOverInfo gameOverInfo;

        public GameOverForm(GameOverInfo game_over_info)
        {
            InitializeComponent();
            gameOverInfo = game_over_info;
        }

        private void onCloseClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        string intToStr(int x)
        {
            return Convert.ToString(x);
        }

        private void onNewGame(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void onLoad(object sender, EventArgs e)
        {
            p1NameLbl.Text = gameOverInfo.p1Name;
            p2NameLbl.Text = gameOverInfo.p2Name;
            p1WinsLbl.Text = intToStr(gameOverInfo.p1Wins);
            p2WinsLbl.Text = intToStr(gameOverInfo.p2Wins);
            winnerNameLbl.Text = gameOverInfo.winnerName;
            foreach (string rndInfo in gameOverInfo.rndsList)
                roundsListCmbBx.Items.Add(rndInfo);
        }
    }
}
