using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CallWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //สร้างออบเจ็กต์ให้เป็น web service
            MyService.Service1 wsObj = new MyService.Service1();
            double w = Convert.ToDouble(textBox1.Text);
            double l = Convert.ToDouble(textBox2.Text);
            label3.Text = "Rectangle Area = "+wsObj.RectAreaComputer(w, l);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //สร้างออบเจ็กต์ให้เป็น web service
            MyService.Service1 wsObj = new MyService.Service1();
            double b = Convert.ToDouble(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            label3.Text = "Triangle Area = " + wsObj.RectAreaComputer(b, h);
        }
    }
}
