using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aug13_EventDriven_MizaBau.Resources;

namespace Aug13_EventDriven_MizaBau

public partial class FrmCalculator : Form
{
    public FrmCalculator()
    {
        InitializeComponent();
    }

    public static event test CalculatorEvent;




















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
