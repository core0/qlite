using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using System.Data.SQLite;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;

namespace qlite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static SQLiteConnection q_conn;
        public static SQLiteCommand q_comm;
        public static SQLiteDataAdapter q_adapt;
        public static DataTable q_dt;

        
        public static bool flag_one = true;

        //информация о таблицах 
        public static ArrayList informations_of_tbl = new ArrayList();
        //путь к БД
        public static String path_to_db;

        //формы
        public static Form MF;
        public static Form NewQuery;
        public static Form addtable;
        public static Form EditContent;
        public static Form AllQuery_f;

        //Выбарный id
        public static String pk_c_in_table;

        //информация о редактируемой ячейки
        public static String table_fields_type_old_vall;

        //запрос из другой формы
        public static String Query = "none";
        //история запросов
        public static String ALLQUERY = "";


        //информацию о поле(имя, тип, примари)
        public class fields
        {
            public int cid;
            public String name_f;
            public String type_f;                
            public int primary_key;
        }

        //информация о таблицах
        public class info_tbl
        {
            public String name_tbl;
            public ArrayList fields_arr = new ArrayList();
        }

        //очистка от таблиц
        public void clear(int f)
        {
            flag_one = true;
            StructGrid.Rows.Clear();
            if (f == 1)
                informations_of_tbl.Clear();
        }

        //открытие БД
        public void func_open_db()
        {
            path_to_db = get_path_to_db();
            if (path_to_db != String.Empty)
            {
                clear(1);
                open_db_and_show_info();
            }
        }
        
        private void open_db_Click(object sender, EventArgs e)
        {
            func_open_db();
        }


        //путь к БД
        public string get_path_to_db()
        {
            String path = String.Empty;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQLite (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                if (!File.ReadAllText(path).StartsWith("SQLite"))
                    return path = "none";

            }

            return path;
        }

        //сохранение БД
        public string get_path_to_save_db()
        {
            String path = String.Empty;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQLite (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
            }
            return path;
        }

        //создание новой таблицы
        public static void create_new_table(string query)
        {
            if (path_to_db != null)
            {
                q_conn.Open();

                q_comm = q_conn.CreateCommand();
                q_comm.CommandText = query;
                q_comm.ExecuteNonQuery();

                q_conn.Close();
            }
        }

        void db_conn_open()
        {
            try
            {
                if (q_conn.State == ConnectionState.Closed)
                    q_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //открытие или закрытие таблицы
        bool DBisOpen()
        {
            try
            {
                if (q_conn.State == ConnectionState.Closed)
                {
                    q_conn.Open();
                    return true;
                }
                else
                {
                    q_conn.Close();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        void SQLHistory(String Query)
        {
            ALLQUERY += Query + Environment.NewLine;
        }



        //открытия бд и создание информации о каждой таблицы
        public bool open_db_and_show_info()
        {
            q_conn = new SQLiteConnection();
            q_conn.ConnectionString = "Data source =" + path_to_db + ";";

            db_conn_open();           
            q_comm = new SQLiteCommand(q_conn);
 

            //извлечение информации о таблицах
            q_comm.CommandText = "SELECT name FROM sqlite_master WHERE type =\"table\" order by name;";


            SQLiteDataReader q_rd = q_comm.ExecuteReader();
            comboBox1.Items.Clear();
            clear(1);

            if (q_rd.FieldCount > 0)
                //заполнение коллекции таблиц
                while (q_rd.Read())
                {
                    if (q_rd["name"].ToString() != "sqlite_sequence")
                    {
                        info_tbl inf = new info_tbl();

                        //имя базы данных
                        inf.name_tbl = q_rd["name"].ToString();

                        //
                        informations_of_tbl.Add(inf);
                    }
                }


            //заполение comboBox именами таблиц
            foreach (info_tbl tb in informations_of_tbl)
            {
                comboBox1.Items.Add(tb.name_tbl);
            }                

            if (comboBox1.Items.Count > 0)           
                comboBox1.SelectedItem = comboBox1.Items[0];


            for (int i = 0; i < informations_of_tbl.Count; i++)
            {
                info_tbl tbl = (info_tbl)informations_of_tbl[i];

                q_comm = new SQLiteCommand(q_conn);
                q_comm.CommandText = "PRAGMA TABLE_INFO(" + tbl.name_tbl + ");";
                SQLHistory(q_comm.CommandText);

                q_rd = q_comm.ExecuteReader();

                if (q_rd.FieldCount > 0)
                    while (q_rd.Read())
                    {
                        //структура для хранения имен и типов полей таблицы
                        fields fld = new fields();

                        fld.cid = Convert.ToInt32(q_rd[0]);
                        fld.name_f = q_rd["name"].ToString();
                        fld.type_f = q_rd["type"].ToString();
                        fld.primary_key = Convert.ToInt32(q_rd["pk"]);

                        tbl.fields_arr.Add(fld);

                    }

                informations_of_tbl.RemoveAt(i);
                informations_of_tbl.Insert(i, tbl);

            }
            return true;
        }

        //выполнение запроса
        public bool exec_query()
        {

            if (qlite.MainForm.Query == "none" && q_conn != null)
            {   
                return false;
            }

            try
            {
                //открытие соединения к базе данных
                db_conn_open();

                q_comm = q_conn.CreateCommand();
                q_comm.CommandText = qlite.MainForm.Query;
                qlite.MainForm.Query = "none";

                //select
                q_comm.CommandText = q_comm.CommandText.ToLower();

                if (q_comm.CommandText.StartsWith("select"))
                {
                    q_dt = new DataTable();
                    q_adapt = new SQLiteDataAdapter(q_comm.CommandText, q_conn);
                    q_adapt.Fill(q_dt);

                    dataGridView1.DataSource = q_dt;
                    SQLHistory(q_comm.CommandText);
                    return true;
                }

                //Vacuum
                if (q_comm.CommandText.StartsWith("v"))
                {
                    q_comm.ExecuteNonQuery();
                    SQLHistory(q_comm.CommandText);

                }

                q_comm.ExecuteNonQuery();

                //if(q_comm.CommandText.IndexOf("drop")!=-1)
                open_db_and_show_info();
                show_content_tb();

                SQLHistory(q_comm.CommandText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return true;
        }

        //генерация структуры таблицы
        public void gen_struct(info_tbl info_d)
        {
            StructGrid.Rows.Add(1);
            
            info_tbl tbl = new info_tbl();
            tbl = (info_tbl)informations_of_tbl[comboBox1.SelectedIndex];           

            //заполнение грида o структурe таблицы
            for (int i = 0; i < tbl.fields_arr.Count; i++)
            {
                fields fld = (fields)tbl.fields_arr[i];
                StructGrid.Rows[i].Cells[0].Value = fld.name_f;
                StructGrid.Rows[i].Cells[1].Value = fld.type_f;
                StructGrid.Rows[i].Cells[2].Value = fld.primary_key;

                if (i + 1 < tbl.fields_arr.Count)
                    StructGrid.Rows.Add(1);
            }

            //физическая информация БД
            get_info_to_db();
        }


        public void get_info_to_db()
        {
            FileInfo finfo = new FileInfo(path_to_db);
            lbl_path.Text = finfo.FullName;
            lbl_size.Text = Convert.ToString(finfo.Length / 1024)+" kb";
            lbl_date_change.Text = finfo.LastWriteTime.ToString();
        }


        //отображение выбраной таблицы
        public bool show_content_tb()
        {
            //очистка грида контента
            clear(0);

            if(comboBox1.Items.Count == 0)
                return false;

            try
            {           
                DBisOpen();

                q_dt = new DataTable();

                //поиск в таблице primary key
                info_tbl tbl = (info_tbl)informations_of_tbl[comboBox1.SelectedIndex];

                Boolean detect_pk= false;

                foreach (fields fld in tbl.fields_arr)
                {
                    if (fld.primary_key == 1)
                    {
                        detect_pk = true;
                        break;
                    }
                }

                //извлечение информации и заполнение грида
                if (detect_pk)
                    q_adapt = new SQLiteDataAdapter("Select * from " + comboBox1.SelectedItem.ToString() + ";", q_conn);
                else
                    q_adapt = new SQLiteDataAdapter("Select rowid, * from " + comboBox1.SelectedItem.ToString() + ";", q_conn);

                SQLHistory(q_adapt.SelectCommand.CommandText);
                q_adapt.Fill(q_dt);


                info_tbl inf = (info_tbl)informations_of_tbl[comboBox1.SelectedIndex];
                gen_struct(inf);

                dataGridView1.DataSource = q_dt;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.GhostWhite;
                dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.DimGray;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                q_conn.Close();
            }

            return true;
        }



        //отображение выбраной таблицы
        private void button5_Click(object sender, EventArgs e)
        {
            clear(0);            
            show_content_tb();            
        }

        //выделеный ряд и ячейка
        public Int32 sel_row=-1;
        public Int32 sel_column=-1;

        //
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_row = e.RowIndex;
            sel_column = e.ColumnIndex;
            Pos_cursor.Text = "Ряд: " + sel_row.ToString() + " Ячейка: " + sel_column.ToString();
        }
                
        //create db
        public void func_create_db()
        {
            path_to_db = get_path_to_save_db();

            if (path_to_db != String.Empty)
            {
                q_conn = new SQLiteConnection();
                q_conn.ConnectionString = "Data source =" + path_to_db + ";New = true;";
                DBisOpen();
                addtable = new AddTable();
                addtable.Show();
                timer_for_create_table.Enabled = true;
            }
        }

        private void create_db_Click(object sender, EventArgs e)
        {
            func_create_db();
        }

        /////////////////////////////////////////////////////////////////////////////
        //Создание таблицы
        public void add_tab()
        {
            if (q_conn != null)
            {
                //открывем соед к бд
                db_conn_open();
                addtable = new AddTable();
                addtable.Show();
                timer_for_create_table.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_tab();
        }


        //
        private void timer_for_create_table_Tick(object sender, EventArgs e)
        {
            if (addtable.Visible == false)
            {
                timer_for_create_table.Enabled = false;
                exec_query();
            }
        }

        /////////////////////////////////////////////////////////////////////////////
        //исполнение вручную написаного запроса

        public void new_query()
        {
            NewQuery = new NewQuery();
            NewQuery.Show();

            timer_for_create_query.Enabled = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            new_query();
        }

        //
        private void timer_for_create_query_Tick(object sender, EventArgs e)
        {
            if (NewQuery.Visible == false && Query !="none")
            {
                timer_for_create_query.Enabled = false;
                exec_query();

            }
        }



        //////////////////////////////////////////////////////////////////////////////////
        //вставка записи

        public void func_insert_item()
        {
            Query = "INSERT INTO " + comboBox1.SelectedItem.ToString() + " ( ";

            info_tbl tbl = (info_tbl)informations_of_tbl[comboBox1.SelectedIndex];                

            foreach (fields fld in tbl.fields_arr)
            {
                if (fld.primary_key != 1)
                {
                    Query += fld.name_f + " )";
                    break;
                }
            }

            Query += " VALUES (NULL);";
            exec_query();
        }



        private void insert_item_Click(object sender, EventArgs e)
        {
            func_insert_item();
        }
        /////////////////////////////////////////////////////////////////
        //удаления записи

        public void del_item()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Query = "DELETE FROM " + comboBox1.SelectedItem.ToString() + get_valid_where_for_sql();
                exec_query();
            }
        }

        private void delete_item_Click(object sender, EventArgs e)
        {
            del_item();
        }

        public String get_type_from_name(String name_field)
        {
            String type = "";

            //поиск типа столбца по его имени
            info_tbl tbl = (info_tbl)informations_of_tbl[comboBox1.SelectedIndex];


            foreach (fields fld in tbl.fields_arr)
            {
                if (fld.name_f == name_field)
                {
                    return fld.type_f;
                }
            }

            return type;
        }


        public String get_name_pk()
        {
            info_tbl tbl = (info_tbl)informations_of_tbl[comboBox1.SelectedIndex];
            foreach (fields fld in tbl.fields_arr)
            {
                if (fld.primary_key == 1)
                {
                    return fld.name_f;
                }
            }

            return "rowid";
        }


        //составление валидного WHERE 
        public String get_valid_where_for_sql()
        {
            String q = " WHERE ";
            String pk_name = get_name_pk();
            q += pk_name + " = " + dataGridView1.Rows[sel_row].Cells[pk_name].Value.ToString();

            //при удалении выделяется нулевой ряд
            sel_row = 0;

            return q;
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String name_headers_pk = get_name_pk();
            //передача на форму редактирования, значения в редактируемой ячейке
            qlite.EditContent.ValCollumn = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            EditContent = new EditContent();
            EditContent.Show();
 
            timer_for_edit_cell.Enabled = true;
        }

        //закрытие формы редактирования значений
        private void timer_for_edit_cell_Tick(object sender, EventArgs e)
        {
            //execute if form closed AND set changes
            if (EditContent.Visible == false && qlite.EditContent.Changed_vall)
            {
                timer_for_edit_cell.Enabled = false;
                //открываем кон. к бд
                db_conn_open();

                //составление запроса для редактирования выбраной ячейки
                q_comm = q_conn.CreateCommand();

                q_comm.CommandText = "UPDATE "+ comboBox1.SelectedItem.ToString() + " SET " +
                dataGridView1.Columns[sel_column].Name + " = ? ";
                q_comm.CommandText += get_valid_where_for_sql();

                q_comm.Parameters.Add("val",DbType.String).Value=qlite.EditContent.ValCollumn;               

                q_comm.ExecuteNonQuery();
                SQLHistory(q_comm.CommandText);                

                //обновление таблицы
                show_content_tb();

            }
        }

        public void vacum_exec()
        {
            Query = "VACUUM;";
            exec_query();
        }

        private void vacuum_Click(object sender, EventArgs e)
        {
            vacum_exec();
        }


        ///////////////////////////////////////////////////////////////////
        //Показывает все комманды сделаные к БД

        public void info_sql()
        {
            AllQuery_f = new AllQuery();
            if (AllQuery_f.Visible == false)
            {
                AllQuery_f.Show();
            }
        }
        private void Info_sql_Click(object sender, EventArgs e)
        {
            info_sql();
        }


        void exit()
        {
            if (q_conn != null)
                if (q_conn.State == ConnectionState.Open)
                    q_conn.Close();

            this.Close();

        }

        private void context_Exit_Click(object sender, EventArgs e)
        {
            exit();
        }


        //дублирование кода, создание БД
        private void context_CreateDB_Click(object sender, EventArgs e)
        {
            func_create_db();
        }

        //дублирование кода, открытие бд
        private void context_OpenDB_Click(object sender, EventArgs e)
        {
            func_open_db();
        }
        //дублирование кода, добавление таблицы
        private void context_CreateTab_Click(object sender, EventArgs e)
        {
            add_tab();
        }
        //дублирование кода, выполнение ручного запроса
        private void context_ExecQ_Click(object sender, EventArgs e)
        {
            new_query();
        }
        //дублирование кода, добавление записи
        private void context_InsertItem_Click(object sender, EventArgs e)
        {
            func_insert_item();
        }
        //дублирование кода, удаления записи
        private void context_DeleteItem_Click(object sender, EventArgs e)
        {
            del_item();
        }
        //дублирование кода, исполнения выкум
        private void context_Vacum_Click(object sender, EventArgs e)
        {
            vacum_exec();
        }
        //дублирование кода, отображения выполненых sql запросов
        private void context_SeeSQL_Click(object sender, EventArgs e)
        {
            info_sql();
        }
 
    }
}
