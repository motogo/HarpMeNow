﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace HarpMeNow
{
    public partial class FBXInfo : Form
    {

        private static FBXInfo instance = null;
        Form Prnt = null;
        public static FBXInfo Instance(Form parent)
        {

            if (instance == null)
            {
                // lock (_lock_this)
                {
                    instance = new FBXInfo(parent);
                    instance.Prnt = parent;
                }
            }
            instance.Prnt = parent;


            return (instance);
        }

        protected FBXInfo(Form parent)
        {
            Prnt = parent;
            InitializeComponent();
            this.Text = "Copyright";
            MoveRandom();
            
        }

        private void CopyrightForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        int hdirection = 0;
        int vdirection = 0;
        int duration = 1;
        int aktduro = 0;

        private void MoveRandom()
        {
            Random rd = new Random();
            hdirection = rd.Next(3);
            vdirection = rd.Next(3);
            duration = rd.Next((Prnt.Width+ Prnt.Height)/4);
            aktduro = 0;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aktduro++;
            if ((this.Left > 280 ) && ((this.Left + this.Width) < Prnt.Width))
            {
                this.Left += hdirection - 1;
            }
            else
            {
               // MoveRandom();

            }
            if ((this.Top > 0) && ((this.Top + this.Height) < Prnt.Height))
            {
                this.Top += vdirection - 1;
            }
            else
            {
              //  MoveRandom();
            }

            if (aktduro > duration)
            {
                MoveRandom();
            }
        }

        private void Occ(ref Bitmap pic, int occ)
        {
            //  timer1.Start();
          

           
            for (int w = 0; w < pic.Width; w++)
            {
                for (int h = 0; h < pic.Height; h++)
                {
                    Color c = pic.GetPixel(w, h);
                    if (c != Color.Transparent)
                    {
                        Color newC = Color.FromArgb(c.A * (occ / 100), c.R * (occ / 100), c.G * (occ / 100), c.B * (occ / 100));
                        pic.SetPixel(w, h, newC);
                    }
                }
            }
            //pictureBox1.Image = pic;
        }

        private void CopyrightForm_Load(object sender, EventArgs e)
        {
            //  timer1.Start();
            // int occ = 100;

            Bitmap pic = new Bitmap(global::HarpMeNow.Properties.Resources.harpImg);
            pictureBox1.Image = pic;
            this.Left += 100;
            this.Top -= 100;
            
        }

        private void CopyrightForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            e.Cancel = false;
            instance = null;

        }

        private void pictureBox1_Validated(object sender, EventArgs e)
        {
           
        }

        private void FBXInfo_Paint(object sender, PaintEventArgs e)
        {
            this.SendToBack();
        }

        private void FBXInfo_MdiChildActivate(object sender, EventArgs e)
        {
             this.SendToBack();
        }
    }
}
