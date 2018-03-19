using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odometer
{

    public partial class Form1 : Form
    {
        static int tick = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            int temp, l1, l2, l3;
            temp = tick;
            l3 = temp % 10;
            temp = temp / 10;

            l2 = temp % 10;
            temp = temp / 10;

            l1 = temp % 10;
            temp = temp / 10;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            Timer Clock = new Timer();
            Clock.Interval = 800;
            Clock.Start();
            Clock.Tick += new EventHandler(MyTimer_Tick);
            Console.OpenStandardOutput('i');

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MyTimer_Tick(button1, e);
        }


        private void MyTimer_Tick(object sender, EventArgs e)
        {
            {
                //throw new NotImplementedException();
                Console.OpenStandardOutput('i');
                tick++;
                int temp, l1, l2, l3;
                temp = tick;
                l3 = temp % 10;
                temp = temp / 10;
                label3.Text = l3.ToString();

                l2 = temp % 10;
                temp = temp / 10;
                label2.Text = l2.ToString();

                l1 = temp % 10;
                temp = temp / 10;
                label1.Text = l1.ToString();

            }
        }

        private void MyTimer_Tick10X(object sender, EventArgs e)
        {
            {
                //throw new NotImplementedException();
                Console.OpenStandardOutput('i');
                tick=tick+10;
                int temp, l1, l2, l3;
                temp = tick;
                l3 = temp % 10;
                temp = temp / 10;
                label3.Text = l3.ToString();

                l2 = temp % 10;
                temp = temp / 10;
                label2.Text = l2.ToString();

                l1 = temp % 10;
                temp = temp / 10;
                label1.Text = l1.ToString();

            }
        }
        private void MyTimer_Tick100X(object sender, EventArgs e)
        {
            {
                //throw new NotImplementedException();
                Console.OpenStandardOutput('i');
                tick++;
                int temp, l1, l2, l3;
                temp = tick;
                l3 = temp % 10;
                temp = temp / 10;
                label3.Text = l3.ToString();

                l2 = temp % 10;
                temp = temp / 10;
                label2.Text = l2.ToString();

                l1 = temp % 10;
                temp = temp / 10;
                label1.Text = l1.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTimer_Tick10X(button1, e);

        }
    }
}
