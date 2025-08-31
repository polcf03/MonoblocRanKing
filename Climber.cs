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
        private int Position;
        private int Score;
        private string Name; 
        private string Level;

        private int Blanc_Route;
        private int Blau_Route;
        private int Lila_Route;
        private int Verd_Route;
        private int Groc_Route;
        private int Taronja_Route;
        private int Vermell_Route;
        private int Negre_Route;


        //-----------------------Constructor-----------------------//
        public Climber()
        {
            Name = "new climber";
            Level = "Blanc";

            Blanc_Route = 0;
            Blau_Route = 0;
            Lila_Route = 0;
            Verd_Route = 0;
            Groc_Route = 0;
            Taronja_Route = 0;
            Vermell_Route = 0;
            Negre_Route = 0;

            Calculate_Score();
        }
        public Climber(string name, string level, int [] Firts_Routes)
        {
            Name = name;
            Level = level;

            Blanc_Route = Firts_Routes[0];
            Blau_Route = Firts_Routes[1];
            Lila_Route = Firts_Routes[2];
            Verd_Route = Firts_Routes[3];
            Groc_Route = Firts_Routes[4];
            Taronja_Route = Firts_Routes[5];
            Vermell_Route = Firts_Routes[6];
            Negre_Route = Firts_Routes[7];

            Calculate_Score();
        }


        //-----------------------Properties-----------------------//+
        public int Climber_Position
        {
            get { return Position; } 
            set { Position = value; }
        }
        public int Climber_Score
        {
            get { return Score; }
            set { Score = value; }
        }
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

        public int Climber_Blanc
        {
            get { return Blanc_Route; } 
            set { Blanc_Route = value; }
        }
        public int Climber_Blau
        {
            get { return Blau_Route; }
            set { Blau_Route = value; }
        }
        public int Climber_Lila
        {
            get { return Lila_Route; }
            set { Lila_Route = value; }
        }
        public int Climber_Verd
        {
            get { return Verd_Route; }
            set { Verd_Route = value; }
        }
        public int Climber_Groc
        {
            get { return Groc_Route; }
            set { Groc_Route = value; }
        }
        public int Climber_Taronja
        {
            get { return Taronja_Route; }
            set { Taronja_Route = value; }
        }
        public int Climber_Vermell
        {
            get { return Vermell_Route; }
            set { Vermell_Route = value; }
        }
        public int Climber_Negre
        {
            get { return Negre_Route; }
            set { Negre_Route = value; }
        }


        //-----------------------Methods-----------------------//
        public void Add_Route(string color, int add_route)
        {
            switch (color)
            {
                case "Blanc":
                    Blanc_Route = Blanc_Route + add_route;
                    break;
                case "Blau":
                    Blau_Route = Blau_Route + add_route;
                    break;
                case "Lila":
                    Lila_Route = Lila_Route + add_route;
                    break;
                case "Verd":
                    Verd_Route = Verd_Route + add_route;
                    break;
                case "Groc":
                    Groc_Route = Groc_Route + add_route;
                    break;
                case "Taronja":
                    Taronja_Route = Taronja_Route + add_route;
                    break;
                case "Vermell":
                    Vermell_Route = Vermell_Route + add_route;
                    break;
                case "Negre":
                    Negre_Route = Negre_Route + add_route;
                    break;
            }
        }
        public void Sub_Route(string color, int sub_route)
        {
            switch (color)
            {
                case "Blanc":
                    Blanc_Route = Blanc_Route - sub_route;
                    break;
                case "Blau":
                    Blau_Route = Blau_Route - sub_route;
                    break;
                case "Lila":
                    Lila_Route = Lila_Route - sub_route;
                    break;
                case "Verd":
                    Verd_Route = Verd_Route - sub_route;
                    break;
                case "Groc":
                    Groc_Route = Groc_Route - sub_route;
                    break;
                case "Taronja":
                    Taronja_Route = Taronja_Route - sub_route;
                    break;
                case "Vermell":
                    Vermell_Route = Vermell_Route - sub_route;
                    break;
                case "Negre":
                    Negre_Route = Negre_Route - sub_route;
                    break;
            }
        }

        public void Calculate_Score()
        {
            Score = 0;
            Score = Blanc_Route * 1 
                + Blau_Route * 2 
                + Lila_Route * 3 
                + Verd_Route * 4 
                + Groc_Route * 5 
                + Taronja_Route * 6 
                + Vermell_Route * 7 
                + Negre_Route * 8;
        }

    }
}
