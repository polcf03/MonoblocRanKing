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
            RankingGroupBox.Dock = DockStyle.Fill;
            ChartGroupBox.Visible = false;
            ChartGroupBox.Dock = DockStyle.Fill;
            ClimbersManagerGroupBox.Visible = false;
            ClimbersManagerGroupBox.Dock = DockStyle.Fill;

        }

        //-----------------------Menu Strip-----------------------//
        private void RankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingGroupBox.Visible = true;
            ChartGroupBox.Visible = false;
            ClimbersManagerGroupBox.Visible = false;
        }
        private void ChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingGroupBox.Visible = false;
            ChartGroupBox.Visible = true;
            ClimbersManagerGroupBox.Visible = false;
        }
        private void ClimbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingGroupBox.Visible = false;
            ChartGroupBox.Visible = false;
            ClimbersManagerGroupBox.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
