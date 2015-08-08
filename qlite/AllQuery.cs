using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlite
{
    public partial class AllQuery : Form
    {
        public AllQuery()
        {
            InitializeComponent();
        }

        private void AllQuery_VisibleChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = qlite.MainForm.ALLQUERY;
        }
    }
}
