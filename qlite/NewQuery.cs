using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlite
{
    public partial class NewQuery : Form
    {
        public NewQuery()
        {
            InitializeComponent();
        }


        public void me_close()
        {
            this.Hide();
            SQLQuery_text.Text = "";
        } 
   
        private void NewQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            me_close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            me_close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLQuery_text.Text = SQLQuery_text.Text.Trim();

            if(SQLQuery_text.Text.Length > 4)
                qlite.MainForm.Query = SQLQuery_text.Text;
            me_close();
        }
    }
}
