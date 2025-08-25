using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monobloc_RanKing
{
    public partial class Form1 : Form
    {
        //-----------------------Objects-----------------------//
        private Climbers_Manager climbersManager;

        //-----------------------Events-----------------------//


        //-----------------------Class variables-----------------------//


        //-----------------------Constructor-----------------------//
        public Form1()
        {
            InitializeComponent();
            
            climbersManager = new Climbers_Manager();
            
            RankingGroupBox.Visible = true;
            ChartGroupBox.Visible = false;
            ClimbersManagerGroupBox.Visible = false;

        }

        //-----------------------Menu Strip-----------------------//
        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingGroupBox.Visible = true;
            ChartGroupBox.Visible = false;
            ClimbersManagerGroupBox.Visible = false;
        }
        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingGroupBox.Visible = false;
            ChartGroupBox.Visible = true;
            ClimbersManagerGroupBox.Visible = false;
        }
        private void climbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingGroupBox.Visible = false;
            ChartGroupBox.Visible = false;
            ClimbersManagerGroupBox.Visible = true;
        }





    }
}
