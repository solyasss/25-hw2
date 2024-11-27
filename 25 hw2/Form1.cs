using System;
using System.Windows.Forms;

namespace hw_2
{
    public partial class Form1 : Form
    {
        private int left = 0;
        private int right = 0;
        private int middle = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Click counterr";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                left++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                right++;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                middle++;
            }

            this.Text = $"left: {left}, right: {right}, middle: {middle}";
        }
    }
}
