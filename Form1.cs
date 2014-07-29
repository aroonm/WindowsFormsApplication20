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
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(button1_Click);
            this.radioButton1.CheckedChanged += new System.EventHandler(radioButton1_CheckedChanged);
            this.radioButton2.CheckedChanged += new System.EventHandler(radioButton2_CheckedChanged);
            this.radioButton3.CheckedChanged += new System.EventHandler(radioButton3_CheckedChanged);
            this.radioButton4.CheckedChanged += new System.EventHandler(radioButton4_CheckedChanged);
            this.radioButton5.CheckedChanged += new System.EventHandler(radioButton5_CheckedChanged);
        }
        int n;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();/*
            this.Close();
            Form2 obj=new Form2(n);
            obj.Close();
            Form3 obj1 = new Form3(n);
            obj1.Close();*/
        }
        public EventHandler RadioButtonCheckedChanged { get; set; }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            n = 1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            n = 2;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            n = 3; 
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            n = 4;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            n = 5;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            form2 = new Form2(n);
            form2.Show();
            //this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
    
}
