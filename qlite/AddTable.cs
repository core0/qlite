using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using System.Collections;
namespace qlite
{
    public partial class AddTable : Form
    {
        public AddTable()
        {
            InitializeComponent();
        }

        public int selected_row = -1;
        

        private void FieldsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected_row = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FieldsGrid.Rows.RemoveAt(FieldsGrid.Rows.Count-1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void me_close()
        {
            this.Hide();
            FieldsGrid.Rows.Clear();
            textBox1.Text = "Имя таблицы";
            selected_row = -1;

        }


        private void AddTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            me_close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FieldsGrid.Rows.Add(1);
            selected_row = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Имя таблицы" || FieldsGrid.Rows.Count == 0)
            {
                return;
            }
            else
            {
                qlite.MainForm.Query = "CREATE TABLE " + textBox1.Text + " (";

                for (int i = 0; i < FieldsGrid.Rows.Count; i++)
                {
                    var tmp = FieldsGrid.Rows[i].Cells[0].Value.ToString()[0];
                                        
                    qlite.MainForm.Query += FieldsGrid.Rows[i].Cells[0].Value.ToString();
                    qlite.MainForm.Query += " " + FieldsGrid.Rows[i].Cells[1].Value.ToString();
                    if (i + 1 < FieldsGrid.Rows.Count)
                        qlite.MainForm.Query += ", ";
                }
                qlite.MainForm.Query += ");";
                //qlite.MainForm.create_new_table(Query);
                me_close();
            }
        }


    }
}
