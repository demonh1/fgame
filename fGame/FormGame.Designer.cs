namespace fGame
{
    partial class FormGame
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
            this.btnStart = new System.Windows.Forms.Button();
            this.labelinput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.labelword = new System.Windows.Forms.Label();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.btnWV = new System.Windows.Forms.Button();
            this.btnFullW = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.labelShowLog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(488, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 298);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Location = new System.Drawing.Point(35, 195);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(32, 13);
            this.labelinput.TabIndex = 11;
            this.labelinput.Text = "Ввод";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(88, 195);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(22, 20);
            this.textBoxInput.TabIndex = 11;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputOnKeyPress);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(147, 298);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Ход";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // labelword
            // 
            this.labelword.AutoSize = true;
            this.labelword.Location = new System.Drawing.Point(18, 32);
            this.labelword.Name = "labelword";
            this.labelword.Size = new System.Drawing.Size(116, 13);
            this.labelword.TabIndex = 13;
            this.labelword.Text = "Отгадываемое слово";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(12, 27);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.ShortcutsEnabled = false;
            this.textBoxTask.Size = new System.Drawing.Size(323, 46);
            this.textBoxTask.TabIndex = 0;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(35, 11);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(50, 13);
            this.labelTask.TabIndex = 1;
            this.labelTask.Text = "Задание";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTask);
            this.panel1.Controls.Add(this.textBoxTask);
            this.panel1.Location = new System.Drawing.Point(21, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 86);
            this.panel1.TabIndex = 2;
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(33, 48);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(26, 20);
            this.textBoxW.TabIndex = 14;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(265, 298);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Новая игра";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(206, 195);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(134, 20);
            this.textBoxWord.TabIndex = 17;
            this.textBoxWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWordOnKeyPress);
            // 
            // btnWV
            // 
            this.btnWV.Location = new System.Drawing.Point(125, 195);
            this.btnWV.Name = "btnWV";
            this.btnWV.Size = new System.Drawing.Size(75, 23);
            this.btnWV.TabIndex = 18;
            this.btnWV.Text = "Слово";
            this.btnWV.UseVisualStyleBackColor = true;
            this.btnWV.Click += new System.EventHandler(this.btnWV_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
           
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruleToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "&Справка";
            // 
            // ruleToolStripMenuItem
            // 
            this.ruleToolStripMenuItem.Name = "ruleToolStripMenuItem";
            this.ruleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ruleToolStripMenuItem.Text = "&Правила игры";
            this.ruleToolStripMenuItem.Click += new System.EventHandler(this.RuleToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.AboutToolStripMenuItem.Text = "&О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Location = new System.Drawing.Point(377, 298);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(94, 23);
            this.btnShowLog.TabIndex = 21;
            this.btnShowLog.Text = "Показать лог";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(439, 70);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(171, 173);
            this.richTextBoxLog.TabIndex = 22;
            this.richTextBoxLog.Text = "";
            // 
            // labelShowLog
            // 
            this.labelShowLog.AutoSize = true;
            this.labelShowLog.Location = new System.Drawing.Point(445, 54);
            this.labelShowLog.Name = "labelShowLog";
            this.labelShowLog.Size = new System.Drawing.Size(26, 13);
            this.labelShowLog.TabIndex = 23;
            this.labelShowLog.Text = "Лог";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 355);
            this.Controls.Add(this.labelShowLog);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.btnFullW);
            this.Controls.Add(this.btnWV);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.labelword);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelinput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGame";
            this.Text = "Игра Поле Чудес";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelinput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label labelword;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button btnWV;
        private System.Windows.Forms.Button btnFullW;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Label labelShowLog;
    }
}

