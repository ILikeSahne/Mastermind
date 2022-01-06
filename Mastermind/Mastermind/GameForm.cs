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
    public partial class GameForm : Form
    {
        public MastermindGame Game;

        private Pen blackPen;

        public Color SelectedColor;
        private Brush selectedColorBrush;

        public GameForm(int tries, int rows)
        {
            InitializeComponent();
            Width = 400 + (rows - 5) * 50;
            Height = 520 + (tries - 6) * 150;
            Game = new MastermindGame(tries, rows);
            Timer t = new Timer();
            t.Tick += UpdateGame;
            t.Interval = 10;
            t.Start();
            blackPen = new Pen(Color.Black, 1);
            DoubleBuffer(game);
            SetSelectedColor(MastermindGame.AvaliableColors[0]);
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            game.Invalidate();
        }

        private void game_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(selectedColorBrush, 0, 0, game.Width, game.Height);
            Game.Draw(g, game);
        }

        private void DoubleBuffer(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }

        private void colorSlector_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(blackPen, 0, 0, colorSlector.Width - 1, colorSlector.Height - 1);
            int amount = MastermindGame.AvaliableColors.Length;
            float width = colorSlector.Width;
            float xPlus = width / amount;
            float x = 0;
            for(int i = 0; i < amount; i++)
            {
                Color c = MastermindGame.AvaliableColors[i];
                g.FillRectangle(new SolidBrush(c), x + 2, 2, xPlus - 4, colorSlector.Height - 4);
                if(SelectedColor == c)
                {
                    g.DrawRectangle(new Pen(Color.Red, 4f), x + 2, 2, xPlus - 4, colorSlector.Height - 4);
                }
                x += xPlus;
            }
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            colorSlector.Invalidate();
        }

        private void colorSlector_MouseUp(object sender, MouseEventArgs e)
        {
            int amount = MastermindGame.AvaliableColors.Length;
            float width = colorSlector.Width;
            float xPlus = width / amount;
            float x = 0;
            for (int i = 0; i < amount; i++)
            {
                if(e.X >= x && e.X <= x + xPlus)
                {
                    SetSelectedColor(MastermindGame.AvaliableColors[i]);
                    return;
                }
                x += xPlus;
            }
        }

        private void SetSelectedColor(Color c)
        {
            SelectedColor = c;
            selectedColorBrush = new SolidBrush(c);
            colorSlector.Invalidate();
        }

        private void game_MouseClick(object sender, MouseEventArgs e)
        {
            Game.MouseClick(e.X, e.Y, game, SelectedColor);
        }
    }
}
