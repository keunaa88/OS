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
            //declare inital arrays
            double [] input = new double[5];
            double [] output = new double[5];

            //convert from text to double using 'TryParse'
            //converted data is saved in the input array.
            double.TryParse(textBox1.Text, out input[0]);
            double.TryParse(textBox2.Text, out input[1]);
            double.TryParse(textBox3.Text, out input[2]);
            double.TryParse(textBox4.Text, out input[3]);
            double.TryParse(textBox5.Text, out input[4]);

            //save index value of comboBox which is selected by user
            int convertType = comboBox1.SelectedIndex;
            double multipleNum = 0;
      
            //All formulars are from Google
            switch (convertType)
            {
                case 0:
                    //if user choose the first option of combobox
                    //Convert Centimetres to Inches
                    multipleNum = 0.393701;
                    break;
                case 1:
                    //if user choose the second option of combobox
                    //Convert Metres to Feet
                    multipleNum = 3.28084;
                    break;
                case 2:
                    //if user choose the third option of combobox
                    //Convert Celsius to Fahrenheit
                    multipleNum = 32;
                    break;
                case 3:
                    //if user choose the fourth option of combobox
                    //Convert Centimetres to Feet
                    multipleNum = 0.0328084;
                    break;
                case 4:
                    //if user choose the fifth option of combobox
                    //Convert Kilometres to Miles
                    multipleNum = 0.621371;
                    break;
                default:
                    break;
            }

            //Convert input numbers by multiplying by a specific number.
            for(int i=0; i<5; i++)
            {
                output[i] = input[i] * multipleNum;
            }
            
            //converted data will be shown in the textboxes
            textBox6.Text = output[0].ToString();
            textBox7.Text = output[1].ToString();
            textBox8.Text = output[2].ToString();
            textBox9.Text = output[3].ToString();
            textBox10.Text = output[4].ToString();


        }

    }
}
