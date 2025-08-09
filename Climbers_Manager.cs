using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monobloc_RanKing
{
    class Climbers_Manager
    {
        //Objects

        //Events

        //Class variables
        Dictionary<string, int> Given_Points = new Dictionary<string, int>()
        {
            { "Blanc",0},
            { "Blau" ,1},
            { "Lila",2},
            { "Verd",3},
            { "Groc",4},
            { "Taronja",5},
            { "Vermell",6},
            { "Negre",7}
        };
        public Climbers_Manager()
        {
        if (Given_Points["Verd"]==0) 
            {
            }
        }
    }
}
