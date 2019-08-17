﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form6 : Form
    {
        int scored;
        public Form6(int score)
        {
            InitializeComponent();
            scored = score;
            label1.Text = label1.Text + "Who is the uncrowned emperor of rome ?";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(label2.Text) == 1 && int.Parse(label3.Text) == 0)
            {
                if (radioButton4.Checked == true)
                {
                    timer1.Stop();
                    Form7 f7 = new Form7(scored + 1);
                    this.Close();
                    f7.Show();
                }
                else
                {
                    timer1.Stop();
                    Form7 f7 = new Form7(scored + 0);
                    this.Close();
                    f7.Show();
                }
            }
            else
            {
                if (int.Parse(label3.Text) < 59)
                {
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                }
                else
                {
                    label3.Text = 0.ToString();
                    label2.Text = (int.Parse(label2.Text) + 1).ToString();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show(this, "Please at least choose one option", "Warning!!!", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show(this, "Are you Sure?", "Submit Gurantee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (radioButton4.Checked == true)
                    {
                        timer1.Stop();
                        Form7 f7 = new Form7(scored + 1);
                        this.Close();
                        f7.Show();
                    }
                    else
                    {
                        timer1.Stop();
                        Form7 f7 = new Form7(scored + 0);
                        this.Close();
                        f7.Show();
                    }

                }
                else
                {
                    //Do Nothing
                }

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
