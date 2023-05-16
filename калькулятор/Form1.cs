﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Добро пожаловать в программу");
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Хотите закрыть программу?", "Подтверждение закрытия", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        float a, b;
        int count;

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label2.Text = a.ToString() + "+";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label2.Text = a.ToString() + "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label2.Text = a.ToString() + "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label2.Text = a.ToString() + "/";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculate();
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }


    }
}




