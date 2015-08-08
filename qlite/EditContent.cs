using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlite
{
    public partial class EditContent : Form
    {
        public EditContent()
        {
            InitializeComponent();
        }


        public static String ValCollumn = String.Empty;
        public static bool Changed_vall = false;



        private void button2_Click(object sender, EventArgs e)
        {
            Changed_vall = true;

            ValCollumn = richTextBox1.Text;
            me_close();
        }

        public void me_close()
        {
            this.Hide();
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Changed_vall = false;
            me_close();
        }

        private void EditContent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Changed_vall = false;
            me_close();
        }

        private void EditContent_VisibleChanged(object sender, EventArgs e)
        {            
            if(this.Visible == true)
                Changed_vall = false;
            richTextBox1.Text = ValCollumn;
        }


            
    }
}
