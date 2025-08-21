using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monobloc_RanKing
{
    internal class Climber
    {
        //Objects

        //Events

        //Class variables
        public string Name;
        Dictionary<string, int> Points;
        public string level;

        //Constructor
        public Climber()
        {
            new Dictionary<string, int>()
            {
                { "Blanc",0},
                { "Blau" ,0},
                { "Lila",0},
                { "Verd",0},
                { "Groc",0},
                { "Taronja",0},
                { "Vermell",0},
                { "Negre",0}
            };
        }
    }
}
