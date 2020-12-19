using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Simulation tankSimulator2020 = new Simulation();
            tankSimulator2020.Show(this);
            this.Hide();
        }
    }
}
