﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2Dreader
{
    public partial class Form1 : Form
    {
        ViewDWG view;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            view = new ViewDWG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureview. = view.GetDwgImage("E:\\2Dreader\\example.dwg");
        }
    }
}
