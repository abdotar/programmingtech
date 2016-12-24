using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public void creation(ArrayList myAL,int[] myAl2)
        {
            chart1.Series.Add("Массив");
            chart1.Series["Массив"].Points.DataBindXY(myAl2, myAL);

        }
    }
}
