﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms3;
using JoshhLibrary;
using PublicLibrary;

namespace MyWindowsForms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            int factorial = Mathematics.Factorial(input);
            textBox2.Text = factorial.ToString();
        }
    }
}