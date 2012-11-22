﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace fGame
{
    public partial class FormGame : Form
    {

        public int numTask = 0;
        public int numAnsw = 0;
        public int num = 0;
        bool flagCheck = false;
        bool check = false;

        // bool flagWord = false;


        /// <summary>
        /// 
        /// 
        /// </summary>
        Random rdn = new Random();
        int rnd = 0;

        string word;

        string[] q = System.IO.File.ReadAllText("fileQ.txt").Split('?');
        string[] w = System.IO.File.ReadAllText("fileA.txt").Split('.');
        FileInfo f = new FileInfo("log.txt");
        FileInfo f0 = new FileInfo("tmp.txt");

        public TextBox[] tb;

        public FormGame()
        {
            InitializeComponent();
        }

        #region  FormGame load
        private void FormGame_Load(object sender, EventArgs e)
        {
            tb = new TextBox[10];
            for (int i = 0; i < 10; i++)
            {
                tb[i] = new TextBox();
                tb[i].Size = textBoxW.Size;
                tb[i].Top = textBoxW.Top;
                tb[i].Left = textBoxW.Left + i * 30;
                tb[i].Parent = this;
                tb[i].Visible = false;
            }
            textBoxW.Visible = false;
            textBoxInput.Visible = false;
            textBoxWord.Visible = false;
            richTextBoxLog.Visible = false;
            //////////////////////////
            btnStart.Enabled = true;
            btnRun.Enabled = false;
            btnNext.Enabled = false;
            btnWV.Enabled = false;
            btnFullW.Enabled = false;
            btnShowLog.Enabled = false;


        }
        #endregion

        #region helper
        private void startClick()
        {
            //////////////////////////////
            //rnd = rdn.Next(0, 4);
            int max = q.Length-1;
            rnd = rdn.Next(0, max);
            int tmp = rnd;
            textBoxTask.Text = q[rnd];
            word = w[rnd];
            ///////////////////////////////////
            // textBoxTask.Text = q[numTask];
            // word = w[numAnsw];
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

        protected void checkFullWord()
        {

            StreamWriter sw = f.AppendText();
            StreamWriter sw0 = f0.AppendText();

            if (flagCheck == true)
            {
                sw.WriteLine("Слово угадано по буквам");
                sw0.WriteLine("Слово угадано по буквам");
                sw0.Close();
                sw.Close();
            }

        }

        private void writeAttemptLog()
        {

            StreamWriter sw = f.AppendText();
            StreamWriter sw0 = f0.AppendText();

            if (check == true)
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

        private void btnstart_Click(object sender, EventArgs e)
        {
            startClick();
            StreamWriter sw = f.AppendText();

            sw.WriteLine("/////////////////");
            sw.Close();

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
                ///
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
                //  if (check == false )
                //  writeAttemptLog();


            }

            catch (Exception ex)
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

                MessageBox.Show("Winner");
                btnWV.Enabled = false;
            }


        }


        private void btnnext_Click(object sender, EventArgs e)
        {
            /////////////
            //tb = new TextBox[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    tb[i] = new TextBox();
            //    tb[i].Size = textBoxW.Size;
            //    tb[i].Top = textBoxW.Top;
            //    tb[i].Left = textBoxW.Left + i * 30;
            //    tb[i].Parent = this;
            //    tb[i].Visible = false;
            //}
            ////////////

            //int max = q.Length;
            //rnd = rdn.Next(0, max);
            //int tmp = rnd;
            //textBoxTask.Text = q[rnd];
            //word = w[rnd];
            ///////////////////////////////////

            //textBoxInput.Visible = true;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    tb[i].Text = " ";
            //    tb[i].Visible = true;
            //    tb[i].ReadOnly = true;

            //}
            //textBoxInput.Focus();
            //btnStart.Enabled = false;
            num = 0;
            startClick();
            btnNext.Enabled = false;
            btnFullW.Enabled = false;
            btnShowLog.Enabled = false;
            textBoxInput.ReadOnly = false;
            textBoxWord.Visible = false;
            f0.Delete();

            ///////////////////////////////////////

        }

        private void btnWV_Click(object sender, EventArgs e)
        {
            textBoxWord.Visible = true;
            btnFullW.Enabled = true;
            btnRun.Enabled = false;
           // btnNext.Enabled = false;
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
                MessageBox.Show("Winner");
                for (int i = 0; i < word.Length; i++)
                {
                    tb[i].Text = word[i].ToString();
                }

                sw.WriteLine("Слово названо целиком");
                sw0.WriteLine("Слово названо целиком");
                sw0.Close();
                sw.Close();

            }

            else
            {
                sw.WriteLine("Проигрыш");
                sw0.WriteLine("Проигрыш");
                sw0.Close();
                sw.Close();
                MessageBox.Show("Luser");
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
            FormAbout about = new FormAbout();
            about.Show();
        }

        private void RuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRule rule = new FormRule();
            rule.Show();
        }

        #endregion

        private void textBoxInputOnKeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 8 && e.KeyChar != ' ' && !Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

       



    }


}

