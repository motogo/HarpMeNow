using System;
using System.Drawing;
using System.Windows.Forms;

namespace HarpMeNow
{
    public partial class CounterForm : Form
    {
        public CounterForm()
        {
            InitializeComponent();
        }
        int n = 0;
        int max = 10;
        private void Form2_Load(object sender, EventArgs e)
        {
            hsCounter.TextAlign = ContentAlignment.MiddleCenter;
            hsCounter.FlatAppearance.BorderSize = 2;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            n++;
            hsCounter.Text = (max-n).ToString();
            if(n > max)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void hsCounter_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void hsCounter_MouseEnter(object sender, EventArgs e)
        {
             hsCounter.FlatAppearance.BorderSize = 2;
        }

        private void hsCounter_MouseLeave(object sender, EventArgs e)
        {
             hsCounter.FlatAppearance.BorderSize = 2;
        }
    }
}
