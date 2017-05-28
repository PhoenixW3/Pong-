using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Pong
{
    public partial class Form1 : Form
    {
        const int movementSpeed = 3;
        bool isUpPressed, isDownPressed;

        public Form1()
        {
            InitializeComponent();
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            if (isUpPressed)
                aPaddle1.Location = new Point(aPaddle1.Location.X, aPaddle1.Location.Y - 3);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                isUpPressed = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
                isUpPressed = false;
        }
    }
}
