﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoshnaLibrary;

namespace MyWindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int result = Algebra.Factorial(n);
            textBox2.Text = result.ToString();
            Console.ReadLine();
        }
    }s
}
