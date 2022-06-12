using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseProblemExtended
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int containerType;

            if (radioButton1.Checked)
            {
                containerType = 1;
            }

            else if (radioButton2.Checked)
            {
                containerType = 2;
            }

            else if (radioButton3.Checked)
            {
                containerType = 3;
                
            }

            else
            {
                textBox2.Text = "Please choose the container type.";
                return;
            }

            int containerAmount = Int32.Parse(textBox1.Text);

            Boxes box = new Boxes(containerType);
            double calculatedValue = box.addBoxes(containerAmount);

            if (calculatedValue < 0)
            {
                textBox2.Text = "You are trying to store too many containers";
            }
            else
            {
                textBox2.Text = calculatedValue.ToString();                         // + " m" + (char)179;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int freeSpace, containerType;

            if (radioButton1.Checked)
            {
                containerType = 1;
            }

            else if (radioButton2.Checked)
            {
                containerType = 2;
            }

            else
            {
                containerType = 3;
            }

            int contAmount = Int32.Parse(textBox1.Text);
            Boxes box = new Boxes(containerType);
            freeSpace = Int32.Parse(textBox2.Text);
            double calculatedValue = box.removeBoxes(freeSpace, contAmount);
            //textBox2.Text = box.removeBoxes(freeSpace, contAmount).ToString();

            if (calculatedValue > box.warehouseVolume())
            {
                textBox2.Text = "Add more containers first";
            }

            else
            {
                textBox2.Text = box.removeBoxes(freeSpace, contAmount).ToString();
            }
        }
    }
}
