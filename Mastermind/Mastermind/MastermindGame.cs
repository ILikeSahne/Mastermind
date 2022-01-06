using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermind
{
    public class MastermindGame
    {
        public static Brush GrayBrush = new SolidBrush(Color.FromArgb(50, 50, 50));
        public static Color DefaultColor = Color.FromArgb(120, 120, 120);
        public static Brush LighGrayBrush = new SolidBrush(DefaultColor);

        public static Brush RedBrush = new SolidBrush(Color.Red);
        public static Brush BlackBrush = new SolidBrush(Color.Black);
        public static Brush WhiteBrush = new SolidBrush(Color.White);

        public static Color[] AvaliableColors =
        {
            Color.White,
            Color.Blue,
            Color.OrangeRed,
            Color.Violet,
            Color.Green,
            Color.Yellow,
            Color.Cyan
        };

        public bool Won { get; set; } = false;
        public bool Lost { get; set; } = false;

        public PinCombination GuessPinCombination;

        public int AmountRows;
        public List<PinCombination> GuessedPinCombinations;
        public List<(int, int)> CorrectPins;

        public MastermindGame(int amountRows, int amountOfPins)
        {
            AmountRows = amountRows;
            GuessedPinCombinations = new List<PinCombination>();
            CreateRandomPinCombi(amountOfPins);
            GuessedPinCombinations.Add(new PinCombination(amountOfPins));
            CorrectPins = new List<(int, int)>();
        }

        private void CreateRandomPinCombi(int amountOfPins)
        {
            GuessPinCombination = new PinCombination();
            Random r = new Random();
            for (int i = 0; i < amountOfPins; i++)
            {
                Color randColor = AvaliableColors[r.Next(AvaliableColors.Length)];
                GuessPinCombination.Pins.Add(randColor);
            }
        }
        public void Draw(Graphics g, Panel p)
        {
            DrawBackground(g, p);
            DrawGuessPins(g, p);
            DrawGuessedPins(g, p);
            DrawCorrectPins(g, p);
            if (!Won && !Lost)
            {
                DrawLastMarking(g, p);
                DrawPinHider(g, p);
            }
            else if (Won)
            {
                DrawStringInMiddle(g, p, "Du hast Gewonnen!", new Font("Impact", p.Width / 12), RedBrush);
            }
            else
            {
                DrawStringInMiddle(g, p, "Du hast Verloren!", new Font("Impact", p.Width / 12), RedBrush);
            }
        }

        private void DrawBackground(Graphics g, Panel p)
        {
            float width = p.Width;
            float height = p.Height;
            float radius = p.Width / 5f;
            g.FillRectangle(GrayBrush, 0f, radius, width, height - radius * 2f);
            g.FillRectangle(GrayBrush, radius, 0f, width - radius * 2f, height);
            g.FillEllipse(GrayBrush, 0f, 0f, radius * 2f, radius * 2f);
            g.FillEllipse(GrayBrush, width - radius * 2f, 0f, radius * 2f, radius * 2f);
            g.FillEllipse(GrayBrush, 0f, height - radius * 2f, radius * 2f, radius * 2f);
            g.FillEllipse(GrayBrush, width - radius * 2f, height - radius * 2f, radius * 2f, radius * 2f);
        }

        private void DrawGuessPins(Graphics g, Panel p)
        {
            DrawPinCombi(g, p, p.Height * 7f / 8f, GuessPinCombination, false);
        }

        private void DrawPinCombi(Graphics g, Panel p, float yPos, PinCombination combi, bool onlyBackground)
        {
            float width = p.Width;
            int amountOfPins = GuessPinCombination.Pins.Count;
            float pinDist = (width / 2f) / (amountOfPins - 1);
            float xPos = width / 4f;
            for (int i = 0; i < amountOfPins; i++)
            {
                float x = xPos - pinDist / 4f;
                float y = yPos - pinDist / 4f;
                float radius = pinDist / 2f;
                g.FillEllipse(LighGrayBrush, x - radius / 4, y - radius / 4, radius * 1.5f, radius * 1.5f);
                if (!onlyBackground)
                {
                    Color c = combi.Pins[i];
                    g.FillEllipse(new SolidBrush(c), x, y, radius, radius);
                }
                xPos += pinDist;
            }
        }

        private void DrawGuessedPins(Graphics g, Panel p)
        {
            float yPos = p.Height / 8f;
            float yPlus = p.Height * 0.7f / AmountRows;
            for (int i = 0; i < AmountRows; i++)
            {
                if (i < GuessedPinCombinations.Count)
                    DrawPinCombi(g, p, yPos, GuessedPinCombinations[i], false);
                else
                    DrawPinCombi(g, p, yPos, null, true);
                yPos += yPlus;
            }
        }

        private void DrawCorrectPins(Graphics g, Panel p)
        {
            float yPos = p.Height / 9.2f;
            float yPlus = p.Height * 0.7f / AmountRows;
            float xPos1 = p.Width * 0.09f;
            float xPos2 = p.Width * 0.87f;
            foreach ((int correctPins, int wrongPlacePins) in CorrectPins)
            {
                int size = p.Height / 40;
                if (size < 1)
                    size = 1;
                g.DrawString(correctPins.ToString(), new Font("Arial", size), RedBrush, xPos1, yPos);
                g.DrawString(wrongPlacePins.ToString(), new Font("Arial", size), WhiteBrush, xPos2, yPos);
                yPos += yPlus;
            }
        }

        private void DrawLastMarking(Graphics g, Panel p)
        {
            int i = GuessedPinCombinations.Count - 1;
            float yPlus = p.Height * 0.7f / AmountRows;
            float yPos = p.Height / 8f + yPlus * i;
            float pinDist = (p.Width / 2f) / (GuessPinCombination.Pins.Count - 1);
            float radius = pinDist / 2f;
            g.DrawRectangle(new Pen(Color.Black, 2), p.Width / 4f - radius, yPos - radius, pinDist * (GuessPinCombination.Pins.Count), radius * 2);
        }

        private void DrawPinHider(Graphics g, Panel p)
        {
            float yStart = p.Height * 7f / 8f;
            float xStart = p.Width / 4f;
            int amountOfPins = GuessPinCombination.Pins.Count;
            float pinDist = (p.Width / 2f) / (amountOfPins - 1);
            g.FillRectangle(WhiteBrush, xStart - pinDist / 2, yStart - pinDist / 2, p.Width / 2f + pinDist, pinDist);
        }

        private void DrawStringInMiddle(Graphics g, Panel p, string text, Font f, Brush b)
        {
            var size = g.MeasureString(text, f);
            float x = p.Width / 2 - size.Width / 2 + 5;
            float y = p.Height / 2 - size.Height / 2;
            g.DrawString(text, f, b, x, y);
        }

        public void MouseClick(int x, int y, Panel p, Color selectedColor)
        {
            if (Won || Lost)
                return;
            int amountOfPins = GuessedPinCombinations.Count;
            int index = amountOfPins - 1;
            PinCombination pc = GuessedPinCombinations[index];
            int len = pc.Pins.Count;
            float yPlus = p.Height * 0.7f / AmountRows;
            float yPos = p.Height / 8f + yPlus * index;
            float pinDist = (p.Width / 2f) / (GuessPinCombination.Pins.Count - 1);
            float xPos = p.Width / 4f;
            float radius = pinDist / 2f;
            for (int i = 0; i < len; i++)
            {
                float xDiff = x - xPos;
                float yDiff = y - yPos;
                if(Math.Sqrt(xDiff * xDiff + yDiff * yDiff) <= radius)
                {
                    pc.Pins[i] = selectedColor;
                }
                xPos += pinDist;
            }
            bool allPlaced = true;
            foreach (Color c in pc.Pins)
            {
                if(c == DefaultColor)
                {
                    allPlaced = false;
                    break;
                }
            }
            if(allPlaced)
            {
                var pins = pc.Check(GuessPinCombination);
                CorrectPins.Add(pins);
                GuessedPinCombinations.Add(new PinCombination(len));
                if (pins.correctPins == GuessPinCombination.Pins.Count)
                    Won = true;
                else if (GuessedPinCombinations.Count == AmountRows + 1)
                    Lost = true;
                Console.WriteLine(Won + " " + Lost);
            }
        }
    }

    public class PinCombination
    {
        public List<Color> Pins { get; set; }

        public PinCombination()
        {
            Pins = new List<Color>();
        }

        public PinCombination(int amount)
        {
            Pins = new List<Color>();
            for (int i = 0; i < amount; i++)
            {
                Pins.Add(MastermindGame.DefaultColor);
            }
        }

        public (int correctPins, int wrongPlacePins) Check(PinCombination pc)
        {
            int len = pc.Pins.Count;
            int correctPins = 0;
            int wrongPlacePins = 0;
            List<int> alreadyUsed1 = new List<int>();
            List<int> alreadyUsed2 = new List<int>();
            for (int i = 0; i < len; i++)
            {
                Color c1 = pc.Pins[i];
                Color c2 = Pins[i];
                if(c1 == c2)
                {
                    correctPins++;
                    alreadyUsed1.Add(i);
                    alreadyUsed2.Add(i);
                }
            }
            for(int i = 0; i < len; i++)
            {
                if (AlreadyUsed(alreadyUsed1, i))
                    continue;
                for (int j = 0; j < len; j++)
                {
                    if (AlreadyUsed(alreadyUsed2, j))
                        continue;
                    Color c1 = pc.Pins[i];
                    Color c2 = Pins[j];
                    if (c1 == c2)
                    {
                        wrongPlacePins++;
                        alreadyUsed1.Add(i);
                        alreadyUsed2.Add(j);
                        break;
                    }
                }
            }
            return (correctPins, wrongPlacePins);
        }

        private bool AlreadyUsed(List<int> alreadyUsed, int i)
        {
            foreach(int x in alreadyUsed)
            {
                if (x == i)
                    return true;
            }
            return false;
        }
    }
}
