using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_IT3B
{
    public partial class Form1 : Form
    {
        Auto nakladak;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nakladak = new Auto("2BB 10-25", 7500);
        }

        private void ZobrazAuto
    }
}
