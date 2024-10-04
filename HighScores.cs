using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_5
{
    internal class HighScores
    {
        int _score;
        string _name;

        public HighScores (int score, string name)
        {
            _score = score;
            _name = name;
        }

        public void printHighScore()
        {
            Console.WriteLine(_name + " High score: " + _score);
        }
    }
}
