using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aug13_EventDriven_MizaBau
{
    //STEP 4. CALCULATOR CLASS & DELEGATE
    public partial class FrmCalculator : Form
    {
        public delegate T Formula<T>(T arg1);
        internal class CalculatorClass
        {

            //STEP 5. GENERIC DELEGATE VARIABLE
            public Formula<double> info;

            //STEP 6. METHOD
            public static Double GetSum(double num1, double num2, double sum)
            {
                sum = num1 + num2;
                return sum;
            }
            public static Double GetDifference(double num1, double num2, double sum)
            {
                sum = num1 + num2;
                return sum;
            }

        }


        //Step 7. EVENT
        public static event Formula<double> CalculatorEvent;
        public FrmCalculator()
        {
            InitializeComponent();
        }

        double getNum1, getNum2;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            getNum1 = Convert.ToDouble(txtBoxInput1.Text);
            getNum2 = Convert.ToDouble(txtBoxInput2.Text);
        }


















        /// <summary>
        /// OTHER PROPERTIES (DRAGGABLE)
        /// </summary>
        public Point mouseLoc;
        public Point bottleMouse;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//checks if left mouse button is held or pressed : D
            {
                Point mousePose = Control.MousePosition;//point var of mouse cursor from topleft corner of sccreen
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);//translates point depending on the location of mouseLoc
                Location = mousePose;//forms location is moved depending on the location of the point variable 
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}