using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class StartForm : Form
    {
        private GameForm game;
        private Timer t;
        private int gameMode = -1;

        private Dictionary<RadioButton, (int amountTries, int amountRows)> selectedMode;

        private Highscore[] highscores =
        {
            new Highscore("Hard.txt"),
            new Highscore("Middle.txt"),
            new Highscore("Easy.txt")
        };

        public StartForm()
        {
            InitializeComponent();
            selectedMode = new Dictionary<RadioButton, (int, int)>();
            selectedMode.Add(modeHardButton, (6, 5));
            selectedMode.Add(modeMiddleButton, (8, 4));
            selectedMode.Add(modeEasyButton, (10, 3));

            updateHighscores();
        }

        private void modeButton_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(modeCustomButton.Checked);
        }

        private void EnableButtons(bool enable)
        {
            amountTriesLabel.Enabled = enable;
            amountTries.Enabled = enable;
            amountRowsLabel.Enabled = enable;
            amountRows.Enabled = enable;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (game != null)
                return;
            int tries = decimal.ToInt32(amountTries.Value);
            int rows = decimal.ToInt32(amountRows.Value);
            if(!modeCustomButton.Checked)
            {
                int i = 0;
                foreach (RadioButton b in selectedMode.Keys)
                {
                    if (b.Checked)
                    {
                        var mode = selectedMode[b];
                        tries = mode.amountTries;
                        rows = mode.amountRows;
                        gameMode = i;
                    }
                    i++;
                }
            }
            game = new GameForm(tries, rows);
            game.Show();
            t = new Timer();
            t.Tick += new EventHandler(checkForFinish);
            t.Interval = 10;
            t.Start();
        }

        private void checkForFinish(object sender, EventArgs e)
        {
            if (!game.Game.Won && !game.Game.Lost)
                return;

            t.Stop();

            if (gameMode < 0 || gameMode >= highscores.Length)
                return;

            if (game.Game.Won)
            {
                Highscore hs = highscores[gameMode];
                hs.WinStreak++;
                hs.Update();
                hs.SaveScore();
            }
            
            if (game.Game.Lost)
            {
                Highscore hs = highscores[gameMode];
                hs.WinStreak = 0;
                hs.Update();
                hs.SaveScore();
            }

            

            updateHighscores();

            game = null;
        }

        private void updateHighscores()
        {
            modeHardHighscoreLabel.Text = "Highscore: " + highscores[0].Highest.ToString();
            modeHardWinStreakLabel.Text = "Win Streak: " + highscores[0].WinStreak.ToString();

            modeMiddleHighscoreLabel.Text = "Highscore: " + highscores[1].Highest.ToString();
            modeMiddleWinStreakLabel.Text = "Win Streak: " + highscores[1].WinStreak.ToString();

            modeEasyHighscoreLabel.Text = "Highscore: " + highscores[2].Highest.ToString();
            modeEasyWinStreakLabel.Text = "Win Streak: " + highscores[2].WinStreak.ToString();
        }
    }
}
