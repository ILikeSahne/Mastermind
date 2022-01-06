using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mastermind
{
    class Highscore
    {
        private string filename;

        private int xor = 483294;

        public int Highest { get; set; } = 0;
        public int WinStreak { get; set; } = 0;

        public Highscore(string _filename)
        {
            filename = _filename;
            generateFile();
            ReadScore();
        }

        private void generateFile()
        {
            if (File.Exists(filename))
                return;
            File.Create(filename).Close();
            SaveScore();
        }

        public void ReadScore()
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                int h = int.Parse(sr.ReadLine());
                int w = int.Parse(sr.ReadLine());
                Highest = h ^ xor;
                WinStreak = w ^ xor;
            }
        }

        public void SaveScore()
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(Highest ^ xor);
                sw.WriteLine(WinStreak ^ xor);
            }
        }

        public void Update()
        {
            if (WinStreak > Highest)
                Highest = WinStreak;
        }

    }
}
