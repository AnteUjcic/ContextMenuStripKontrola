﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStripKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void desnoNaLjevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void ljevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }
    }
}
