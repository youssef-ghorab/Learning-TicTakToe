using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tak_Toe
{
    public partial class GameForm : Form
    {
        class Player
        {
            public string name;
            public char symbole;
            public int wins;
            public int id;

            public Player(string name, char symbole, int wins, int id)
            {
                this.name = name;
                this.symbole = symbole;
                this.wins = wins;
                this.id = id;
            }
        }

        class Round
        {
            public enum State { CorrectMove, UncorrectMove, Win, Draw };

            int _roundNumber;
            Player player1;
            Player player2;
            Player _winner;
            Player _currentPlayer;
            int cellsRemaind = 9;
            bool _isCompleted=false;
            State roundState;
            Point[] _winLine;

            int[,] playTable = new int[3, 3]{
                {0,0,0},
                {0,0,0},
                {0,0,0},
             };

            public Player winner
            {
                get { return _winner; }
                private set { _winner = value; }
            }

            public Round(Player player_1, Player player_2,int round_number,int first)
            {
                player1 = player_1;
                player2 = player_2;
                _currentPlayer = first == 0 ? player1 : player2;
                _roundNumber = round_number;
            }

            public Point[] winLine
            {
                get { return _winLine; }
            }

            void nextTurn()
            {
                _currentPlayer = (_currentPlayer == player1 ? player2 : player1);
            }

            void setIdAtPos(Point p,int id)
            {
                playTable[p.Y, p.X] = _currentPlayer.id;
            }

            public State finishTurn(Point play_pos)
            {
                if (!isVaible(play_pos))
                    return State.UncorrectMove;

                setIdAtPos(play_pos, _currentPlayer.id);
                cellsRemaind--;

                if (checkIsWinner(_currentPlayer.id,out _winLine))
                {
                    _isCompleted = true;
                    _winner = _currentPlayer;
                    return State.Win;
                }
                else if (cellsRemaind == 0)
                {
                    _isCompleted = true; 
                    return State.Draw;
                }

                nextTurn();
                return State.CorrectMove;
            }

            bool checkIsWinner(int id,out Point[] line)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (playTable[0, i] == id && playTable[1, i] == id && playTable[2, i] == id)
                    {
                        line = new Point[3] { new Point(i, 0), new Point(i, 1), new Point(i, 2) };
                        return true;
                    }
                    else if (playTable[i, 0] == id && playTable[i, 1] == id && playTable[i, 2] == id)
                    {
                        line = new Point[3] { new Point(0, i), new Point(1, i), new Point(2, i) };
                        return true;
                    }
                }
                if (playTable[1, 1] == id)
                {
                    if (playTable[0, 0] == id && playTable[2, 2] == id)
                    {
                        line = new Point[3] { new Point(0, 0), new Point(1, 1), new Point(2, 2) };
                        return true;
                    }
                    else if (playTable[0, 2] == id && playTable[2, 0] == id)
                    {
                        line = new Point[3] { new Point(2, 0), new Point(1, 1), new Point(0, 2) };
                        return true;
                    }
                }
                line = new Point[3] { new Point(-1, -1), new Point(-1, -1), new Point(-1, -1) };
                return false;
            }
        
            public bool isCompleted
            {
                set { _isCompleted = value; }
                get { return _isCompleted; }
            }
        
            public Player currentPlayer
            {
                get { return _currentPlayer; }
            }
        
            public int roundNumber
            {
                get { return _roundNumber; }
            }
        
            public bool isVaible(Point p)
            {
                return playTable[p.Y, p.X] == 0;
            }
        }

        class Game
        {
            List<Round> _rounds;
            int _roundsRemaind;
            Player _p1;
            Player _p2;
            int currentRoundIndex;
            int _totalRound;
            bool _isCompleted;
            Player _winner;

            public Game(int rounds_number, char p1_symbole, char p2_symbole, string p1_name, string p2_name)
            {
                _p1 = new Player(p1_name, p1_symbole, 0, 1);
                _p2 = new Player(p2_name, p2_symbole, 0, 2);
                _rounds = new List<Round>(rounds_number);
                for (int i = 1; i <= rounds_number; i++)
                {
                    _rounds.Add(new Round(_p1, _p2,i,i%2));
                }
                currentRoundIndex = 0;
                if (rounds_number <= 0)
                    _isCompleted = true;
                else
                {
                    _roundsRemaind = rounds_number - 1;
                    _totalRound = rounds_number;
                }
            }

            public Round currentRound
            {
                get { return getCurrentRound(); }
            }

            Round getCurrentRound()
            {
                return _rounds[currentRoundIndex];
            }

            Player getWinner()
            {
                Player pWinner = null;
                if (_p1.wins > _p2.wins)
                    pWinner = _p1;
                else if (_p2.wins > _p1.wins)
                    pWinner = _p2;
                return pWinner;
            }

            public bool isCompleted
            {
                set { _isCompleted = value; }
                get { return _isCompleted; }
            }

            public Player winner
            {
                set { _winner = value; }
                get { return _winner; }
            }

            public Round prevRound()
            {
                return _rounds[currentRoundIndex - 1];
            }

            public Round.State addTurn(Point pnt)
            {
                Round.State state = getCurrentRound().finishTurn(pnt);

                if (getCurrentRound().isCompleted)
                {
                    if (state == Round.State.Win)
                        getCurrentRound().winner.wins++;
                    if (getCurrentRound() == _rounds.Last())
                        _winner = getWinner();
                    else
                        currentRoundIndex++;
                    if (_roundsRemaind > 0)
                        _roundsRemaind--;
                    else
                        _isCompleted = true;
                }
                return state;
            }

            public int totalRound
            {
                get { return _totalRound; }
            }

            public int roundsRemaind
            {
                get { return _roundsRemaind; }
            }

            public Player player1
            {
                get { return _p1; }
            }

            public Player player2
            {
                get { return _p2; }
            }
        
            public List<Round> rounds
            {
                get { return _rounds; }
            }
        }

        Game game;
        Label[,] cells;

        public GameForm(NewGameForm.GameSettings gameSettings)
        {
            InitializeComponent();
            game = new Game(gameSettings.roudnsNumber, gameSettings.p1Symbole, gameSettings.p2Symbole, gameSettings.p1Name, gameSettings.p2Name);
        }

        int strToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        string iToS(int i)
        {
            return Convert.ToString(i);
        }

        string roundToStr(Round r)
        {
            return "Round :" + r.roundNumber + ",winner : " + (r.winner == null ? "no winner" : r.winner.name) + "\n";
        }

        Point getLblPos(Label lbl)
        {
            string[] parts = ((string)lbl.Tag).Split(',');
            Point p = new Point(strToInt(parts[1]), strToInt(parts[0]));
            return p;
        }

        private void onLoad(object sender, EventArgs e)
        {
            cells = new Label[3, 3]
            {
                {cell1Lbl, cell2Lbl, cell3Lbl },
                {cell4Lbl, cell5Lbl, cell6Lbl },
                {cell7Lbl, cell8Lbl, cell9Lbl }
            };
            updateAllInfoUI();
        }

        void updateRoundInfoUI()
        {
            roundNumberLbl.Text = iToS(game.currentRound.roundNumber);
            turnOfLbl.Text = game.currentRound.currentPlayer.name;
            roundWinnerLbl.Text = game.currentRound.isCompleted ? game.currentRound.winner.name : "In progress";
            updateTurnOfFucose();
        }

        void updatePlayersInfoUI()
        {
            p1NameLbl.Text = game.player1.name;
            p2NameLbl.Text = game.player2.name;
            p1WinsLbl.Text = iToS(game.player1.wins);
            p2WinsLbl.Text = iToS(game.player2.wins);
            p1SymboleLbl.Text = game.player1.symbole+"";
            p2SymboleLbl.Text = game.player2.symbole+"";

        }

        void updateGeneraleInfoUI(bool update_rounds_completed_info)
        {
            totalRoundsLbl.Text = iToS(game.totalRound);
            roundsRemaindLbl.Text = iToS(game.roundsRemaind);
            gameWinnerLbl.Text = game.isCompleted ? game.winner.name : "In progress";
            if (update_rounds_completed_info) 
            {
                roundsListCmbBx.Items.Clear();
                foreach (Round r in game.rounds)
                    if (r != null)
                        roundsListCmbBx.Items.Add(roundToStr(r));
            }
        }

        void updateAllInfoUI()
        {
            updateGeneraleInfoUI(true);
            updatePlayersInfoUI();
            updateRoundInfoUI();
        }

        void resetCells()
        {
            foreach (Label c in cells)
            {
                c.Text = "?";
                c.BackColor = Color.White;
            }
        }

        Label getCellByPoint(Point p)
        {
            return cells[p.Y, p.X];
        }

        void setSymboleToCell(Point p,char symbole)
        {
            getCellByPoint(p).Text = symbole + "";
        }

        void updateTurnOfFucose()
        {
            if (game.currentRound.currentPlayer == game.player1)
            {
                p1BgPnl.BackColor = Color.WhiteSmoke;
                p2BgPnl.BackColor = Color.Transparent;
            }
            else if (game.currentRound.currentPlayer == game.player2)
            {
                p2BgPnl.BackColor = Color.WhiteSmoke;
                p1BgPnl.BackColor = Color.Transparent;
            }
        }

        void drawWinLine(Point p1, Point p2, Point p3)
        {
            getCellByPoint(p1).BackColor = Color.SlateGray;
            getCellByPoint(p2).BackColor = Color.SlateGray;
            getCellByPoint(p3).BackColor = Color.SlateGray;
        }

        private void onCellClick(object sender, EventArgs e)
        {
            if (nextRoundBtn.Enabled)
                return;

            Point pnt = getLblPos((Label)sender);
            Player plyr = game.currentRound.currentPlayer;
            Round crrntRnd = game.currentRound;

            if (!crrntRnd.isVaible(pnt))
                return;

            setSymboleToCell(pnt, plyr.symbole);

            Round.State stt = game.addTurn(pnt);

            if (game.isCompleted) 
                showGameOver();
            if (crrntRnd.isCompleted)
            {
                if (stt == Round.State.Win)
                {
                    Point[] line = crrntRnd.winLine;
                    drawWinLine(line[0], line[1], line[2]);
                }
                roundCompleted(crrntRnd);
            }
            else
                updateRoundInfoUI();
        }
        
        List<string> getRndsAsStrList()
        {
            List<string> rndsStrList = new List<string>();
            foreach (Round r in game.rounds)
                if (r != null)
                    rndsStrList.Add(roundToStr(r));
            return rndsStrList;
        }

        void showGameOver()
        {
            GameOverForm.GameOverInfo gameOverInfo;

            string p1Name = game.player1.name;
            string p2Name = game.player2.name;
            string winner = game.winner == null ? "Draw" : game.winner.name;
            int p1Wins = game.player1.wins;
            int p2Wins = game.player2.wins;
            List<string> rnds = getRndsAsStrList();

            gameOverInfo = new GameOverForm.GameOverInfo(p1Name,p2Name,p1Wins,p2Wins,rnds,winner);
            GameOverForm gameOverForm = new GameOverForm(gameOverInfo);

            DialogResult = gameOverForm.ShowDialog();
            Close();
        }

        void roundCompleted(Round r)
        {
            nextRoundBtn.Enabled = true;
            roundWinnerLbl.Text = (r.winner == null ? "Draw" : r.winner.name);
        }

        private void nextRoundBtn_Click(object sender, EventArgs e)
        {
            updateRoundInfoUI();
            updateGeneraleInfoUI(true);
            updatePlayersInfoUI();
            resetCells();
            nextRoundBtn.Enabled = false;
            if (game.isCompleted)
                showGameOver();
        }
    }
}
