namespace qlite
{
    partial class AddTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.FieldsGrid = new System.Windows.Forms.DataGridView();
            this.FieldsBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FieldsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldsType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsGrid)).BeginInit();
            this.FieldsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FieldsGrid
            // 
            this.FieldsGrid.AllowUserToAddRows = false;
            this.FieldsGrid.AllowUserToDeleteRows = false;
            this.FieldsGrid.AllowUserToResizeColumns = false;
            this.FieldsGrid.AllowUserToResizeRows = false;
            this.FieldsGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.FieldsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FieldsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FieldsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FieldsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldsName,
            this.FieldsType});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FieldsGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.FieldsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.FieldsGrid.Location = new System.Drawing.Point(7, 19);
            this.FieldsGrid.Name = "FieldsGrid";
            this.FieldsGrid.RowHeadersWidth = 20;
            this.FieldsGrid.Size = new System.Drawing.Size(339, 284);
            this.FieldsGrid.TabIndex = 3;
            this.FieldsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FieldsGrid_CellMouseClick);
            // 
            // FieldsBox
            // 
            this.FieldsBox.Controls.Add(this.button3);
            this.FieldsBox.Controls.Add(this.button2);
            this.FieldsBox.Controls.Add(this.FieldsGrid);
            this.FieldsBox.Location = new System.Drawing.Point(12, 49);
            this.FieldsBox.Name = "FieldsBox";
            this.FieldsBox.Size = new System.Drawing.Size(353, 340);
            this.FieldsBox.TabIndex = 2;
            this.FieldsBox.TabStop = false;
            this.FieldsBox.Text = "FieldsAdd";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MintCream;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя таблицы";
            // 
            // FieldsName
            // 
            this.FieldsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldsName.HeaderText = "Имя";
            this.FieldsName.Name = "FieldsName";
            this.FieldsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FieldsType
            // 
            this.FieldsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldsType.HeaderText = "Тип поля";
            this.FieldsType.Items.AddRange(new object[] {
            "TEXT",
            "NUMERIC",
            "BLOB",
            "INTEGER PRIMARY KEY"});
            this.FieldsType.Name = "FieldsType";
            this.FieldsType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FieldsType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FieldsBox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTable";
            this.Text = "AddTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTable_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FieldsGrid)).EndInit();
            this.FieldsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView FieldsGrid;
        private System.Windows.Forms.GroupBox FieldsBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldsName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FieldsType;
    }
}