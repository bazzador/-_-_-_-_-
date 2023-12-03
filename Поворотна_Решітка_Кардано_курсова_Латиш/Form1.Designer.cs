
namespace Поворотна_Решітка_Кардано_курсова_Латиш
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textCrypto = new System.Windows.Forms.TextBox();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.matrix2 = new System.Windows.Forms.DataGridView();
            this.matrix3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix3)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(241, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(171, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "без сміття (надійний варіант)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(241, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(169, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "зі сміттям (швидкий варіант)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "легка (4x4)",
            "середня (6x6)",
            "важка (8х8)",
            "дуже важка (10х10)"});
            this.comboBox1.Location = new System.Drawing.Point(291, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Створити шифр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCrypto
            // 
            this.textCrypto.Location = new System.Drawing.Point(12, 46);
            this.textCrypto.Name = "textCrypto";
            this.textCrypto.Size = new System.Drawing.Size(190, 20);
            this.textCrypto.TabIndex = 6;
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrix.ColumnHeadersHeight = 4;
            this.matrix.ColumnHeadersVisible = false;
            this.matrix.EnableHeadersVisualStyles = false;
            this.matrix.Location = new System.Drawing.Point(12, 128);
            this.matrix.Name = "matrix";
            this.matrix.ReadOnly = true;
            this.matrix.RowHeadersVisible = false;
            this.matrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrix.Size = new System.Drawing.Size(23, 12);
            this.matrix.TabIndex = 8;
            this.matrix.Visible = false;
            this.matrix.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrix_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 54);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // matrix2
            // 
            this.matrix2.AllowUserToAddRows = false;
            this.matrix2.AllowUserToDeleteRows = false;
            this.matrix2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matrix2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrix2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrix2.ColumnHeadersHeight = 4;
            this.matrix2.ColumnHeadersVisible = false;
            this.matrix2.EnableHeadersVisualStyles = false;
            this.matrix2.Location = new System.Drawing.Point(449, 128);
            this.matrix2.Name = "matrix2";
            this.matrix2.ReadOnly = true;
            this.matrix2.RowHeadersVisible = false;
            this.matrix2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrix2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrix2.Size = new System.Drawing.Size(74, 25);
            this.matrix2.TabIndex = 14;
            this.matrix2.Visible = false;
            // 
            // matrix3
            // 
            this.matrix3.AllowUserToAddRows = false;
            this.matrix3.AllowUserToDeleteRows = false;
            this.matrix3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matrix3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrix3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrix3.ColumnHeadersHeight = 4;
            this.matrix3.ColumnHeadersVisible = false;
            this.matrix3.EnableHeadersVisualStyles = false;
            this.matrix3.Location = new System.Drawing.Point(948, 128);
            this.matrix3.Name = "matrix3";
            this.matrix3.ReadOnly = true;
            this.matrix3.RowHeadersVisible = false;
            this.matrix3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrix3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrix3.Size = new System.Drawing.Size(60, 17);
            this.matrix3.TabIndex = 15;
            this.matrix3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1550, 550);
            this.Controls.Add(this.matrix3);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.textCrypto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textCrypto;
        protected System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.DataGridView matrix2;
        protected System.Windows.Forms.DataGridView matrix3;
    }
}

