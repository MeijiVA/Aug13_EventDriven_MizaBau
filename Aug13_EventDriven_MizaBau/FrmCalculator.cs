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
using static Aug13_EventDriven_MizaBau.FrmCalculator;

namespace Aug13_EventDriven_MizaBau
{
    //STEP 4. DELEGATE
    public delegate T Formula<T>(T arg1, T arg2);
    public class CalculatorClass
    {

        //STEP 5. GENERIC DELEGATE VARIABLE
        public Formula<double> info;

        //STEP 6. METHOD
        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        //STEP 12. CHALLENGE EXERCISE GetProduct GetQuotient
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }



        //Step 7. EVENT
        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                Console.WriteLine("Removed a Delegate");
            }

        }

    }
    //STEP 4. CALCULATOR CLASS & DELEGATE
    public partial class FrmCalculator : Form
    {

        public FrmCalculator()
        {
            InitializeComponent();
        }

        //STEP 9. VARIABLES
        double num1, num2;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            //STEP 8. INSTANTIATE 
            CalculatorClass cal;
            cal = new CalculatorClass();
            //STEP 10. Get Value
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            //STEP 13. CHALLENGE EXERCISE VALIDATION
            switch (cbOperator.Text)
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                    break;
                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                    break;
                case "*":
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                    break;
                case "/":
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                    break;
                default:
                    MessageBox.Show("Unknown Operator");
                    break;

            }

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