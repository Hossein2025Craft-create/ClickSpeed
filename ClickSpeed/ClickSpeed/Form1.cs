using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickSpeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMain_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Blue)
            {
                btn.Visible = false;
                LblGoal.Text = (int.Parse(LblGoal.Text) - 1).ToString();
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("شما بازنده شدید");
                Close();
            }
            if (LblGoal.Text == "0")
            {
                MessageBox.Show("شما برنده شدید");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numOfblue = 0;
            foreach (Button btn in panel1.Controls)
            {
                if (rnd.Next(0, 2) == 0)
                {
                    btn.BackColor = Color.Blue;
                    numOfblue++;
                }
            }
            LblGoal.Text = numOfblue.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (int.Parse(lblTime.Text) + 1).ToString();
        }
    }
}