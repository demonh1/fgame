using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*
    * Game Wheel of Fortune. 
    * @autor Arkhipov A. 
                                  */

namespace fGame
{
    public partial class FormGame : Form
    {

        public int nAttemps = 0;
        public int num = 0;
        bool flagCheck = false;
        bool check = false;


        Random rdn = new Random();
        int rnd = 0;

        string word;

        string[] q = System.IO.File.ReadAllText("fileQ.txt").Split('?');
        string[] w = System.IO.File.ReadAllText("fileA.txt").Split('.');
        FileInfo f = new FileInfo("log.txt");
        FileInfo f0 = new FileInfo("tmp.txt");

        public TextBox[] tb;

        // constructor
        public FormGame()
        {
            InitializeComponent();
        }

        #region  FormGame load
        private void FormGame_Load(object sender, EventArgs e)
        {
            tb = new TextBox[10];  
            //  задание параметров для ввода буквы в цикле
            for (int i = 0; i < 10; i++)
            {
                tb[i] = new TextBox(); 
                tb[i].Size = textBoxW.Size;
                tb[i].Top = textBoxW.Top;
                tb[i].Left = textBoxW.Left + i * 30;
                tb[i].Parent = this;
                tb[i].Visible = false;
            }
            //делаем скрытыми по умолчанию поля формы
            textBoxW.Visible = false;
            textBoxInput.Visible = false;
            textBoxWord.Visible = false;
            richTextBoxLog.Visible = false;
            //делаем активными либо не активными кнопки формы
            btnStart.Enabled = true;
            btnRun.Enabled = false;
            btnNext.Enabled = false;
            btnWV.Enabled = false;
            btnFullW.Enabled = false;
            btnShowLog.Enabled = false;


        }
        #endregion

        #region helper
        private void startClick() //инициализация начала игры
        {
            int max = q.Length-1;
            rnd = rdn.Next(0, max);
            int tmp = rnd;
            textBoxTask.Text = q[rnd];
            word = w[rnd];
           
            textBoxInput.Visible = true;

            for (int ii = 0; ii < word.Length; ii++)
            {
                tb[ii].Visible = true;
                tb[ii].ReadOnly = true;
                tb[ii].Text = " ";
            }
            textBoxInput.Focus();
            btnStart.Enabled = false;
            btnRun.Enabled = true;
            
        }
        private void folEntryLog() {
            StreamWriter sw = f.AppendText();

            sw.WriteLine("/////////////////");
            sw.WriteLine("Задание. {0}", q[rnd]);
            sw.Close();
        }

        protected void checkFullWord() //проверка угадано ли слово по буквам
        {

            StreamWriter sw = f.AppendText();
            StreamWriter sw0 = f0.AppendText();

            if (flagCheck)
            {
                sw.WriteLine("Слово угадано по буквам");
                sw.WriteLine("Число ходов: {0}", nAttemps);
                sw0.WriteLine("Слово угадано по буквам");
                sw0.Close();
                sw.Close();
            }

        }

        private void writeAttemptLog() //запись угаданных букв в лог
        {

            StreamWriter sw = f.AppendText();
            StreamWriter sw0 = f0.AppendText();

            if (check)
            {
                sw.WriteLine("Буква угадана");
                sw0.WriteLine("Буква угадана");
                sw0.Close();
                sw.Close();
            }

            //sw.WriteLine("Буква не угадана");
            //sw0.WriteLine("Буква не угадана");
            //sw0.Close();
            //sw.Close();

        }

        #endregion
        
        #region clicks
        //обработка нажатий кнопок
        private void btnstart_Click(object sender, EventArgs e)
        {
            startClick();
            folEntryLog();
            btnWV.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            f0.Delete();

            Application.Exit();
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            btnShowLog.Enabled = true;
            btnNext.Enabled = true;

            StreamWriter sw = f.AppendText();
            StreamWriter sw0 = f0.AppendText();
            try
            {
                if (textBoxInput.Text == null) { throw new Exception(); }

                char ch = Convert.ToChar(textBoxInput.Text);
               
                nAttemps++;

                sw.WriteLine("Введена буква: {0}", ch);
                sw.Close();

                sw0.WriteLine("Введена буква: {0}", ch);
                sw0.Close();

                //  writeAttemptLog();

                for (int i = 0; i < word.Length; i++)
                {
                    if (ch == word[i])
                    {
                        tb[i].Text = ch.ToString();
                        num++;
                        check = true;
                        writeAttemptLog();
                        check = false;
                    }

                }

                textBoxInput.Text = "";
                //  if (!check)
                //  writeAttemptLog();

            }

            catch (Exception )
            {
                sw.WriteLine("Ошибка: буква не введена или было введено сразу несколько букв");
                sw.Close();
                sw0.WriteLine("Ошибка: буква не введена или было введено сразу несколько букв");
                sw0.Close();
                MessageBox.Show("Сначала нужно ввести одну букву", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnWV.Enabled = true;
            if (num == word.Length)
            {
                flagCheck = true;
                checkFullWord();

                MessageBox.Show("Победитель");
                btnWV.Enabled = false;
            }


        }


        private void btnnext_Click(object sender, EventArgs e)
        {

            num = 0;
            nAttemps = 0;

            startClick();
            folEntryLog();
            
            btnNext.Enabled = false;
            btnFullW.Enabled = false;
            btnWV.Enabled = true;
            btnShowLog.Enabled = false;
            textBoxInput.ReadOnly = false;
            textBoxWord.Visible = false;
            f0.Delete();

        }

        private void btnWV_Click(object sender, EventArgs e)
        {
            textBoxWord.Visible = true;
            btnFullW.Enabled = true;
            btnRun.Enabled = false;
          
            btnShowLog.Enabled = true;
            textBoxInput.ReadOnly = true;
            textBoxWord.ReadOnly = false;
            textBoxWord.Text = "";
        }

        private void btnFullW_Click(object sender, EventArgs e)
        {

            StreamWriter sw = f.AppendText();
            StreamWriter sw0 = f0.AppendText();


            if (textBoxWord.Text == "")
            {
                sw.WriteLine("Ошибка: поле ввода пусто");
                sw0.WriteLine("Ошибка: поле ввода пусто");
                sw0.Close();
                sw.Close();

                MessageBox.Show("Сначала нужно ввести слово", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            if (textBoxWord.Text == word)
            {
                MessageBox.Show("Победитель");
                for (int i = 0; i < word.Length; i++)
                {
                    tb[i].Text = word[i].ToString();
                }

                sw.WriteLine("Слово названо целиком");
                sw.WriteLine("Число ходов: {0}", nAttemps);
                sw0.WriteLine("Слово названо целиком");
                sw0.Close();
                sw.Close();

            }

            else
            {
                sw.WriteLine("Проигрыш");
                sw.WriteLine("Число ходов: {0}",nAttemps);
                sw0.WriteLine("Проигрыш");
                sw0.Close();
                sw.Close();
                MessageBox.Show("Неудачник! Обидно, да?");
            }

            textBoxWord.ReadOnly = true;
            btnWV.Enabled = false;
            btnNext.Enabled = true;
            btnFullW.Enabled = false;
        }


        private void btnShowLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Visible = true;
            richTextBoxLog.Text = System.IO.File.ReadAllText("tmp.txt");
        }
        #endregion

        #region menu

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();  //обработка нажатия пункта меню О программе
            about.Show();
        }

        private void RuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRule rule = new FormRule(); //обработка нажатия пункта меню Правила игры
            rule.Show();
        }

        #endregion

        private void textBoxInputOnKeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 8 && e.KeyChar != ' ' && !Char.IsLetter(e.KeyChar) )
                e.Handled = true;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxInput.Text = System.Text.RegularExpressions.Regex.Replace(textBoxInput.Text, @"[^а-я]", " ");
            
           
        }

        private void textBoxWordOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != ' ' && !Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
        
    }

}

