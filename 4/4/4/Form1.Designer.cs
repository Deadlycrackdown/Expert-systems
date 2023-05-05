
namespace _4
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
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.memo1 = new System.Windows.Forms.RichTextBox();
            this.memo2 = new System.Windows.Forms.RichTextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.stringGrid1 = new System.Windows.Forms.DataGridView();
            this.stringGrid2 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.memo1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stringGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(612, 156);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(75, 25);
            this.LoadFileButton.TabIndex = 0;
            this.LoadFileButton.Text = "Открыть";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // memo1
            // 
            this.memo1.Location = new System.Drawing.Point(693, 311);
            this.memo1.Name = "memo1";
            this.memo1.Size = new System.Drawing.Size(547, 240);
            this.memo1.TabIndex = 1;
            this.memo1.Text = "";
            // 
            // memo2
            // 
            this.memo2.Location = new System.Drawing.Point(693, 28);
            this.memo2.Name = "memo2";
            this.memo2.Size = new System.Drawing.Size(547, 100);
            this.memo2.TabIndex = 2;
            this.memo2.Text = "";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(612, 185);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 25);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // stringGrid1
            // 
            this.stringGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stringGrid1.Location = new System.Drawing.Point(12, 28);
            this.stringGrid1.Name = "stringGrid1";
            this.stringGrid1.Size = new System.Drawing.Size(286, 539);
            this.stringGrid1.TabIndex = 4;
            // 
            // stringGrid2
            // 
            this.stringGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stringGrid2.Location = new System.Drawing.Point(320, 28);
            this.stringGrid2.Name = "stringGrid2";
            this.stringGrid2.Size = new System.Drawing.Size(286, 539);
            this.stringGrid2.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // memo1TextBox
            // 
            this.memo1TextBox.Location = new System.Drawing.Point(693, 166);
            this.memo1TextBox.Multiline = true;
            this.memo1TextBox.Name = "memo1TextBox";
            this.memo1TextBox.Size = new System.Drawing.Size(547, 103);
            this.memo1TextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Частота каждого символа в тексте выраженная в процентах";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Исходный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Расшифрованный";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Загруженный текст";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memo1TextBox);
            this.Controls.Add(this.stringGrid2);
            this.Controls.Add(this.stringGrid1);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.memo2);
            this.Controls.Add(this.memo1);
            this.Controls.Add(this.LoadFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stringGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.RichTextBox memo1;
        private System.Windows.Forms.RichTextBox memo2;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.DataGridView stringGrid1;
        private System.Windows.Forms.DataGridView stringGrid2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox memo1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

