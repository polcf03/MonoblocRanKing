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
        //Objects
        private Climbers_Manager climbersManager;

        //Events

        //Class variables

        //Constructor
        public Form1()
        {
            InitializeComponent();
            climbersManager = new Climbers_Manager();
        }

    }
}
