namespace qlite
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.open_db = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.create_db = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_date_change = new System.Windows.Forms.Label();
            this.lbl_title_date_change = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_title_size = new System.Windows.Forms.Label();
            this.lbl_title_path = new System.Windows.Forms.Label();
            this.lbl_path = new System.Windows.Forms.Label();
            this.StructGrid = new System.Windows.Forms.DataGridView();
            this.FieldsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.timer_for_create_table = new System.Windows.Forms.Timer(this.components);
            this.timer_for_create_query = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Pos_cursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.insert_item = new System.Windows.Forms.Button();
            this.delete_item = new System.Windows.Forms.Button();
            this.timer_for_edit_cell = new System.Windows.Forms.Timer(this.components);
            this.vacuum = new System.Windows.Forms.Button();
            this.Info_sql = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.context_File = new System.Windows.Forms.ToolStripMenuItem();
            this.context_CreateDB = new System.Windows.Forms.ToolStripMenuItem();
            this.context_OpenDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.context_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.context_CreateTab = new System.Windows.Forms.ToolStripMenuItem();
            this.context_ExecQ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.context_InsertItem = new System.Windows.Forms.ToolStripMenuItem();
            this.context_DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Vacum = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.context_SeeSQL = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StructGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_db
            // 
            this.open_db.Location = new System.Drawing.Point(77, 26);
            this.open_db.Name = "open_db";
            this.open_db.Size = new System.Drawing.Size(65, 23);
            this.open_db.TabIndex = 0;
            this.open_db.Text = "Открыть";
            this.open_db.UseVisualStyleBackColor = true;
            this.open_db.Click += new System.EventHandler(this.open_db_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(950, 528);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // create_db
            // 
            this.create_db.Location = new System.Drawing.Point(6, 26);
            this.create_db.Name = "create_db";
            this.create_db.Size = new System.Drawing.Size(65, 23);
            this.create_db.TabIndex = 2;
            this.create_db.Text = "Создать";
            this.create_db.UseVisualStyleBackColor = true;
            this.create_db.Click += new System.EventHandler(this.create_db_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Создать таблицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выполнить запрос";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 554);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.StructGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Структура";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_date_change);
            this.groupBox1.Controls.Add(this.lbl_title_date_change);
            this.groupBox1.Controls.Add(this.lbl_size);
            this.groupBox1.Controls.Add(this.lbl_title_size);
            this.groupBox1.Controls.Add(this.lbl_title_path);
            this.groupBox1.Controls.Add(this.lbl_path);
            this.groupBox1.Location = new System.Drawing.Point(412, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // lbl_date_change
            // 
            this.lbl_date_change.Location = new System.Drawing.Point(185, 122);
            this.lbl_date_change.Name = "lbl_date_change";
            this.lbl_date_change.Size = new System.Drawing.Size(178, 13);
            this.lbl_date_change.TabIndex = 5;
            // 
            // lbl_title_date_change
            // 
            this.lbl_title_date_change.AutoSize = true;
            this.lbl_title_date_change.Location = new System.Drawing.Point(7, 122);
            this.lbl_title_date_change.Name = "lbl_title_date_change";
            this.lbl_title_date_change.Size = new System.Drawing.Size(172, 13);
            this.lbl_title_date_change.TabIndex = 4;
            this.lbl_title_date_change.Text = "Дата последнего изменения";
            // 
            // lbl_size
            // 
            this.lbl_size.Location = new System.Drawing.Point(66, 93);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(113, 13);
            this.lbl_size.TabIndex = 3;
            this.lbl_size.Text = " ";
            // 
            // lbl_title_size
            // 
            this.lbl_title_size.AutoSize = true;
            this.lbl_title_size.Location = new System.Drawing.Point(7, 93);
            this.lbl_title_size.Name = "lbl_title_size";
            this.lbl_title_size.Size = new System.Drawing.Size(53, 13);
            this.lbl_title_size.TabIndex = 2;
            this.lbl_title_size.Text = "Размер:";
            // 
            // lbl_title_path
            // 
            this.lbl_title_path.AutoSize = true;
            this.lbl_title_path.Location = new System.Drawing.Point(7, 16);
            this.lbl_title_path.Name = "lbl_title_path";
            this.lbl_title_path.Size = new System.Drawing.Size(70, 13);
            this.lbl_title_path.TabIndex = 1;
            this.lbl_title_path.Text = "Путь к БД:";
            // 
            // lbl_path
            // 
            this.lbl_path.Location = new System.Drawing.Point(7, 35);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(356, 58);
            this.lbl_path.TabIndex = 0;
            // 
            // StructGrid
            // 
            this.StructGrid.AllowUserToAddRows = false;
            this.StructGrid.AllowUserToDeleteRows = false;
            this.StructGrid.AllowUserToResizeColumns = false;
            this.StructGrid.AllowUserToResizeRows = false;
            this.StructGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.StructGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.StructGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StructGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.StructGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StructGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldsName,
            this.FieldsType,
            this.AutoInc});
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StructGrid.DefaultCellStyle = dataGridViewCellStyle40;
            this.StructGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.StructGrid.Location = new System.Drawing.Point(8, 6);
            this.StructGrid.Name = "StructGrid";
            this.StructGrid.ReadOnly = true;
            this.StructGrid.RowHeadersVisible = false;
            this.StructGrid.RowHeadersWidth = 20;
            this.StructGrid.Size = new System.Drawing.Size(395, 475);
            this.StructGrid.TabIndex = 4;
            // 
            // FieldsName
            // 
            this.FieldsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldsName.HeaderText = "Имя";
            this.FieldsName.Name = "FieldsName";
            this.FieldsName.ReadOnly = true;
            this.FieldsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FieldsType
            // 
            this.FieldsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldsType.HeaderText = "Тип";
            this.FieldsType.Name = "FieldsType";
            this.FieldsType.ReadOnly = true;
            this.FieldsType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AutoInc
            // 
            this.AutoInc.HeaderText = "Autoincrement";
            this.AutoInc.Name = "AutoInc";
            this.AutoInc.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(408, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer_for_create_table
            // 
            this.timer_for_create_table.Tick += new System.EventHandler(this.timer_for_create_table_Tick);
            // 
            // timer_for_create_query
            // 
            this.timer_for_create_query.Tick += new System.EventHandler(this.timer_for_create_query_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pos_cursor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(957, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Pos_cursor
            // 
            this.Pos_cursor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pos_cursor.Name = "Pos_cursor";
            this.Pos_cursor.Size = new System.Drawing.Size(0, 17);
            // 
            // insert_item
            // 
            this.insert_item.Location = new System.Drawing.Point(597, 26);
            this.insert_item.Name = "insert_item";
            this.insert_item.Size = new System.Drawing.Size(111, 23);
            this.insert_item.TabIndex = 10;
            this.insert_item.Text = "Вставить запись";
            this.insert_item.UseVisualStyleBackColor = true;
            this.insert_item.Click += new System.EventHandler(this.insert_item_Click);
            // 
            // delete_item
            // 
            this.delete_item.Location = new System.Drawing.Point(714, 26);
            this.delete_item.Name = "delete_item";
            this.delete_item.Size = new System.Drawing.Size(110, 23);
            this.delete_item.TabIndex = 11;
            this.delete_item.Text = "Удалить запись";
            this.delete_item.UseVisualStyleBackColor = true;
            this.delete_item.Click += new System.EventHandler(this.delete_item_Click);
            // 
            // timer_for_edit_cell
            // 
            this.timer_for_edit_cell.Tick += new System.EventHandler(this.timer_for_edit_cell_Tick);
            // 
            // vacuum
            // 
            this.vacuum.Location = new System.Drawing.Point(830, 26);
            this.vacuum.Name = "vacuum";
            this.vacuum.Size = new System.Drawing.Size(75, 23);
            this.vacuum.TabIndex = 12;
            this.vacuum.Text = "VACUUM";
            this.vacuum.UseVisualStyleBackColor = true;
            this.vacuum.Click += new System.EventHandler(this.vacuum_Click);
            // 
            // Info_sql
            // 
            this.Info_sql.Location = new System.Drawing.Point(911, 26);
            this.Info_sql.Name = "Info_sql";
            this.Info_sql.Size = new System.Drawing.Size(38, 23);
            this.Info_sql.TabIndex = 13;
            this.Info_sql.Text = "SQL";
            this.Info_sql.UseVisualStyleBackColor = true;
            this.Info_sql.Click += new System.EventHandler(this.Info_sql_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_File,
            this.таблицаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // context_File
            // 
            this.context_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_CreateDB,
            this.context_OpenDB,
            this.toolStripSeparator1,
            this.context_Exit});
            this.context_File.Name = "context_File";
            this.context_File.Size = new System.Drawing.Size(48, 20);
            this.context_File.Text = "Файл";
            // 
            // context_CreateDB
            // 
            this.context_CreateDB.Name = "context_CreateDB";
            this.context_CreateDB.Size = new System.Drawing.Size(152, 22);
            this.context_CreateDB.Text = "Создать БД";
            this.context_CreateDB.Click += new System.EventHandler(this.context_CreateDB_Click);
            // 
            // context_OpenDB
            // 
            this.context_OpenDB.Name = "context_OpenDB";
            this.context_OpenDB.Size = new System.Drawing.Size(152, 22);
            this.context_OpenDB.Text = "Открыть БД";
            this.context_OpenDB.Click += new System.EventHandler(this.context_OpenDB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // context_Exit
            // 
            this.context_Exit.Name = "context_Exit";
            this.context_Exit.Size = new System.Drawing.Size(152, 22);
            this.context_Exit.Text = "Выход";
            this.context_Exit.Click += new System.EventHandler(this.context_Exit_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_CreateTab,
            this.context_ExecQ,
            this.toolStripSeparator2,
            this.context_InsertItem,
            this.context_DeleteItem,
            this.context_Vacum,
            this.toolStripSeparator3,
            this.context_SeeSQL});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // context_CreateTab
            // 
            this.context_CreateTab.Name = "context_CreateTab";
            this.context_CreateTab.Size = new System.Drawing.Size(296, 22);
            this.context_CreateTab.Text = "Создать таблицу";
            this.context_CreateTab.Click += new System.EventHandler(this.context_CreateTab_Click);
            // 
            // context_ExecQ
            // 
            this.context_ExecQ.Name = "context_ExecQ";
            this.context_ExecQ.Size = new System.Drawing.Size(296, 22);
            this.context_ExecQ.Text = "Выполнить запрос";
            this.context_ExecQ.Click += new System.EventHandler(this.context_ExecQ_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // context_InsertItem
            // 
            this.context_InsertItem.Name = "context_InsertItem";
            this.context_InsertItem.Size = new System.Drawing.Size(296, 22);
            this.context_InsertItem.Text = "Вставить запись";
            this.context_InsertItem.Click += new System.EventHandler(this.context_InsertItem_Click);
            // 
            // context_DeleteItem
            // 
            this.context_DeleteItem.Name = "context_DeleteItem";
            this.context_DeleteItem.Size = new System.Drawing.Size(296, 22);
            this.context_DeleteItem.Text = "Удалить запись";
            this.context_DeleteItem.Click += new System.EventHandler(this.context_DeleteItem_Click);
            // 
            // context_Vacum
            // 
            this.context_Vacum.Name = "context_Vacum";
            this.context_Vacum.Size = new System.Drawing.Size(296, 22);
            this.context_Vacum.Text = "Вакум";
            this.context_Vacum.Click += new System.EventHandler(this.context_Vacum_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // context_SeeSQL
            // 
            this.context_SeeSQL.Name = "context_SeeSQL";
            this.context_SeeSQL.Size = new System.Drawing.Size(296, 22);
            this.context_SeeSQL.Text = "Отобразить выполненые операции с БД";
            this.context_SeeSQL.Click += new System.EventHandler(this.context_SeeSQL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 645);
            this.Controls.Add(this.Info_sql);
            this.Controls.Add(this.vacuum);
            this.Controls.Add(this.delete_item);
            this.Controls.Add(this.insert_item);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.create_db);
            this.Controls.Add(this.open_db);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "qlite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StructGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_db;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button create_db;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer_for_create_table;
        private System.Windows.Forms.DataGridView StructGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_title_size;
        private System.Windows.Forms.Label lbl_title_path;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label lbl_date_change;
        private System.Windows.Forms.Label lbl_title_date_change;
        private System.Windows.Forms.Timer timer_for_create_query;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Pos_cursor;
        private System.Windows.Forms.Button insert_item;
        private System.Windows.Forms.Button delete_item;
        private System.Windows.Forms.Timer timer_for_edit_cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoInc;
        private System.Windows.Forms.Button vacuum;
        private System.Windows.Forms.Button Info_sql;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem context_File;
        private System.Windows.Forms.ToolStripMenuItem context_CreateDB;
        private System.Windows.Forms.ToolStripMenuItem context_OpenDB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem context_Exit;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem context_CreateTab;
        private System.Windows.Forms.ToolStripMenuItem context_ExecQ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem context_InsertItem;
        private System.Windows.Forms.ToolStripMenuItem context_DeleteItem;
        private System.Windows.Forms.ToolStripMenuItem context_Vacum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem context_SeeSQL;
    }
}

