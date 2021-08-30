﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSBasic7_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 메모자정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("가짜 메모장~");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(toolStripProgressBar1.Value + 10 < toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value += 10;
            }
            else
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            }
        }

        private void 상태표시줄ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            상태표시줄ToolStripMenuItem1.Checked = !상태표시줄ToolStripMenuItem1.Checked;
            if(상태표시줄ToolStripMenuItem1.Checked)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }
    }
}
