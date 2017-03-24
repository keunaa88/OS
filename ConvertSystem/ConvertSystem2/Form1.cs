using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertSystem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            double [] input = new double[5];
            double [] output = new double[5];

            //convert input values to integer
            double.TryParse(textBox1.Text, out input[0]);
            double.TryParse(textBox2.Text, out input[1]);
            double.TryParse(textBox3.Text, out input[2]);
            double.TryParse(textBox4.Text, out input[3]);
            double.TryParse(textBox5.Text, out input[4]);

            
            int convertType = comboBox1.SelectedIndex;
            double multipleNum = 0;
            switch (convertType)
            {
                case 0:
                    //Convert Centimetres to Inches
                    multipleNum = 0.393701;
                    break;
                case 1:
                    //Convert Metres to Feet
                    multipleNum = 3.28084;
                    break;
                case 2:
                    //Convert Celsius to Fahrenheit
                    multipleNum = 32;
                    break;
                case 3:
                    //Convert Centimetres to Feet
                    multipleNum = 0.0328084;
                    break;
                case 4:
                    //Convert Kilometres to Miles
                    multipleNum = 0.621371;
                    break;
                default:
                    break;
            }

            for(int i=0; i<5; i++)
            {
                output[i] = input[i] * multipleNum;
            }
            
         
            textBox6.Text = output[0].ToString();
            textBox7.Text = output[1].ToString();
            textBox8.Text = output[2].ToString();
            textBox9.Text = output[3].ToString();
            textBox10.Text = output[4].ToString();

        }

    }
}
