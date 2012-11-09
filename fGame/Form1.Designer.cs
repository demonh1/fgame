namespace fGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnst = new System.Windows.Forms.Button();
            this.labelword = new System.Windows.Forms.Label();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.labelfullWord = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.btnWV = new System.Windows.Forms.Button();
            this.btnFullW = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(483, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(88, 298);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "начать";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ввод";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 11;
            // 
            // btnst
            // 
            this.btnst.Location = new System.Drawing.Point(218, 298);
            this.btnst.Name = "btnst";
            this.btnst.Size = new System.Drawing.Size(75, 23);
            this.btnst.TabIndex = 12;
            this.btnst.Text = "Ход";
            this.btnst.UseVisualStyleBackColor = true;
            this.btnst.Click += new System.EventHandler(this.btnst_Click);
            // 
            // labelword
            // 
            this.labelword.AutoSize = true;
            this.labelword.Location = new System.Drawing.Point(18, 14);
            this.labelword.Name = "labelword";
            this.labelword.Size = new System.Drawing.Size(116, 13);
            this.labelword.TabIndex = 13;
            this.labelword.Text = "Отгадываемое слово";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(17, 37);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.ShortcutsEnabled = false;
            this.textBoxTask.Size = new System.Drawing.Size(323, 23);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.TextChanged += new System.EventHandler(this.textBoxTask_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задание";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTask);
            this.panel1.Location = new System.Drawing.Point(21, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 86);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 14;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(333, 298);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 15;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // labelfullWord
            // 
            this.labelfullWord.AutoSize = true;
            this.labelfullWord.Location = new System.Drawing.Point(346, 198);
            this.labelfullWord.Name = "labelfullWord";
            this.labelfullWord.Size = new System.Drawing.Size(32, 13);
            this.labelfullWord.TabIndex = 16;
            this.labelfullWord.Text = "Ввод";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(206, 195);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(134, 20);
            this.textBoxWord.TabIndex = 17;
            // 
            // btnWV
            // 
            this.btnWV.Location = new System.Drawing.Point(125, 195);
            this.btnWV.Name = "btnWV";
            this.btnWV.Size = new System.Drawing.Size(75, 23);
            this.btnWV.TabIndex = 18;
            this.btnWV.Text = "Слово";
            this.btnWV.UseVisualStyleBackColor = true;
            this.btnWV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFullW
            // 
            this.btnFullW.Location = new System.Drawing.Point(218, 221);
            this.btnFullW.Name = "btnFullW";
            this.btnFullW.Size = new System.Drawing.Size(75, 23);
            this.btnFullW.TabIndex = 19;
            this.btnFullW.Text = "OK";
            this.btnFullW.UseVisualStyleBackColor = true;
            this.btnFullW.Click += new System.EventHandler(this.btnFullW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 355);
            this.Controls.Add(this.btnFullW);
            this.Controls.Add(this.btnWV);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelfullWord);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelword);
            this.Controls.Add(this.btnst);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnst;
        private System.Windows.Forms.Label labelword;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label labelfullWord;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button btnWV;
        private System.Windows.Forms.Button btnFullW;
    }
}

