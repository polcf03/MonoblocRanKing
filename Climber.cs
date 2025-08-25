using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Monobloc_RanKing
{
    internal class Climber
    {
        //-----------------------Objects-----------------------//


        //-----------------------Events-----------------------//


        //-----------------------Class variables-----------------------//
        private string Name; 
        private string Level;
        private int Score;
        private Dictionary<string, int> Routes;


        //-----------------------Constructor-----------------------//
        public Climber()
        {
            Name = "new climber";
            Level = "Blanco";
            Score = 0;
            Routes = new Dictionary<string, int>()
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
        public Climber(string name, string level, List<int> Firts_Routes)
        {
            Name = name;
            Level = level;
            Routes = new Dictionary<string, int>()
            { 
                { "Blanc",Firts_Routes[0]},
                { "Blau" ,Firts_Routes[1]},
                { "Lila",Firts_Routes[2]},
                { "Verd",Firts_Routes[3]},
                { "Groc",Firts_Routes[4]},
                { "Taronja",Firts_Routes[5]},
                { "Vermell",Firts_Routes[6]},
                { "Negre",Firts_Routes[7]}
            };
        }


        //-----------------------Properties-----------------------//
        public string Climber_Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Climber_Level
        {
            get { return Level; }
            set { Level = value; }
        }
        public int Climber_Score
        {
            get { return Score; }
            set { Score = value; }
        }

        public int Get_Climber_Routes(string color)
        {
            return Routes[color]; 
        }
        public void Set_Climber_Routes(string color, int Route)
        {
            Routes[color] = Route;
        }


        //-----------------------Methods-----------------------//
        public void Add_Route(string color, int add_route)
        {
            Routes[color] = Routes[color] + add_route;
        }
        public void Sub_Route(string color, int sub_route)
        {
            Routes[color] = Routes[color] - sub_route;
        }

        public void Calculate_Score()
        {
            Score = 0;
            Score = (Routes["Blanc"]*0) + 
                (Routes["Blau"] * 1) + 
                (Routes["Lila"] * 2) + 
                (Routes["Verd"] * 3) + 
                (Routes["Groc"] * 4) + 
                (Routes["Taronja"] * 5) + 
                (Routes["Vermell"] * 6) + 
                (Routes["Negre"] * 7);
        }

    }
}
