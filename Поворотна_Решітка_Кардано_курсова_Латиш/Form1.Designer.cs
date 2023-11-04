
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
            this.components = new System.ComponentModel.Container();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textCrypto = new System.Windows.Forms.TextBox();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.matrix.Location = new System.Drawing.Point(62, 138);
            this.matrix.Name = "matrix";
            this.matrix.ReadOnly = true;
            this.matrix.RowHeadersVisible = false;
            this.matrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrix.Size = new System.Drawing.Size(561, 261);
            this.matrix.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(685, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 190);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1550, 550);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textCrypto;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.DataGridView matrix;
    }
}

