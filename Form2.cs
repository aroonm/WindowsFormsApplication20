using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public partial class Form2 : Form
    {
        int x;
        int dof;
        String t_1, t_2,t_6,t_4,t_7,t_8,t_3,t_9,t10,t5;
        public Form2(int n)
        {
            x = n;
            InitializeComponent();
           // this.textBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox6_MouseClick);
            func();
        }
        
        public void func()
        {
            if(x==1)
            {
                //string t1 = textBox1.Text; string t2 = textBox2.Text;
                textBox6.Visible = false; textBox4.Visible = false;
                textBox7.Visible = false; textBox8.Visible = false;
                textBox3.Visible = false; textBox9.Visible = false;
                textBox10.Visible = false; textBox5.Visible = false;
            }
            else if (x == 2)
            {
                //string t1 = textBox1.Text; string t2 = textBox2.Text;
                //string t6 = textBox6.Text; string t4 = textBox4.Text;
                textBox7.Visible = false; textBox8.Visible = false;
                textBox3.Visible = false; textBox9.Visible = false;
                textBox10.Visible = false; textBox5.Visible = false;
            }
            else if (x == 3)
            {
                //string t1 = textBox1.Text; string t2 = textBox2.Text;
                //string t6 = textBox6.Text; string t4 = textBox4.Text;
                //string t7 = textBox7.Text; string t8 = textBox8.Text;
                textBox3.Visible = false; textBox9.Visible = false;
                textBox10.Visible = false; textBox5.Visible = false;
            }
            else if (x == 4)
            {
                
                textBox10.Visible = false; textBox5.Visible = false;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
        }

        int[] exp = new int[5];
        int[] obs = new int[5];
        int i = 0;


        private void textBox1_Validated(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            int e1 = Convert.ToInt32(t1);
            exp[0] = e1;
           // MessageBox.Show(e1+"");
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            String t2 = textBox2.Text;
            int o2 = Convert.ToInt32(t2);
            //MessageBox.Show(o2+"");
            obs[0] = o2;
        }

        private void textBox6_Validated(object sender, EventArgs e)
        {
            String t6 = textBox6.Text;
            int e6 = Convert.ToInt32(t6);
           //MessageBox.Show(e6+"");
            exp[1] = e6;
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            String t4 = textBox4.Text;
            int o4 = Convert.ToInt32(t4);
            //MessageBox.Show(o4 + "");
            obs[1] = o4;
        }

        private void textBox7_Validated(object sender, EventArgs e)
        {
            String t7 = textBox7.Text;
            int e7 = Convert.ToInt32(t7);
           // MessageBox.Show(e7 + "");
            exp[2] = e7;
        }

        private void textBox8_Validated(object sender, EventArgs e)
        {
            String t8 = textBox8.Text;
            int o8 = Convert.ToInt32(t8);
           // MessageBox.Show(o8 + "");
            obs[2] = o8;
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            String t3 = textBox3.Text;
            int e3 = Convert.ToInt32(t3);
           // MessageBox.Show(e3 + "");
            exp[3] = e3;
        }

        private void textBox9_Validated(object sender, EventArgs e)
        {
            String t9 = textBox9.Text;
            int o9 = Convert.ToInt32(t9);
           // MessageBox.Show(o9 + "");
            obs[3] = o9;
        }

        private void textBox10_Validated(object sender, EventArgs e)
        {
            String t10 = textBox10.Text;
            int e10 = Convert.ToInt32(t10);
           // MessageBox.Show(e10 + "");
            exp[4] = e10;
        }

        private void textBox5_Validated(object sender, EventArgs e)
        {
            String t5 = textBox5.Text;
            int o5 = Convert.ToInt32(t5);
            //MessageBox.Show(o5 + "");
            obs[4] = o5;
        }
        float chi = 1;
        float sq;
        float sum;
        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < x; i++)
            {
                //MessageBox.Show(exp[i] + "   " + obs[i]);

                sq=(obs[i] - exp[i]) * (obs[i] - exp[i]);
                chi = sq / exp[i];
                sum = sum + chi;
                
            }
            int dof = x - 1;

            float[] chiTab = new float[11];
            chiTab[0]=0.05f; chiTab[1]=3.841f; chiTab[2]=5.991f; chiTab[3]=7.815f; chiTab[4]=9.488f; chiTab[5]=11.070f; chiTab[6]=12.592f;
            chiTab[7]=14.067f; chiTab[8]=15.507f; chiTab[9]=16.919f; chiTab[10]=18.307f;

            if (sum > chiTab[dof])
            {
                MessageBox.Show("Chi Squared Value: " + sum + "\n\nWe do NOT accept 'Null Hypothesis'. ie: There IS a statistical difference between Observed and Expected Values.");
            }
            else
            {
                MessageBox.Show("Chi Squared Value: " + sum + "\n\nWe accept 'Null Hypothesis'. ie: There is NO statistical difference between Observed and Expected Values.");
            }

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        
    }
}



















