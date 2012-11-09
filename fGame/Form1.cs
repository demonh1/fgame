using System;
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
    public partial class Form1 : Form
    {

        public int i = 0;
        public int j = 0;


        public string word;

        public string[] q = System.IO.File.ReadAllText("fileQ.txt").Split('?');
        public string[] w = System.IO.File.ReadAllText("fileA.txt").Split('.');

        public TextBox[] tb;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb = new TextBox[10];
            for (int i = 0; i < 10; i++)
            {
                tb[i] = new TextBox();
                tb[i].Size = textBox1.Size;
                tb[i].Top = textBox1.Top;
                tb[i].Left = textBox1.Left + i * 30;
                tb[i].Parent = this;
                tb[i].Visible = false;
            }
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBoxWord.Visible = false;
            //////////////////////////
            btnstart.Enabled = true;
            btnst.Enabled = false;
            btnnext.Enabled = false;
            btnWV.Enabled = false;
            btnFullW.Enabled = false;
        }
        private void startClick()
        {
            textBoxTask.Text = q[i];
            word = w[j];
            textBox2.Visible = true;

            for (int ii = 0; ii < word.Length; ii++)
            {
                tb[ii].Visible = true;
                tb[ii].ReadOnly = true;
            }
            textBox2.Focus();
            btnstart.Enabled = false;
            btnst.Enabled = true;
            btnnext.Enabled = true;
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            //richTextBox1.Lines = q;
            // textBoxTask.Text = richTextBox1.Lines[i];
            startClick();
        }


        private void btnst_Click(object sender, EventArgs e)
        {
            //
            try
            {
                if (textBox2.Text == null) { throw new Exception(); }
                btnnext.Enabled = false;
                char ch = Convert.ToChar(textBox2.Text);

                for (int i = 0; i < word.Length; i++)
                {
                    if (ch == word[i])
                    {
                        tb[i].Text = ch.ToString();
                    }

                }
                textBox2.Text = "";

            }
            // Most specific
            catch (Exception ex)
            {
                MessageBox.Show("Сначала нужно ввести букву", "Ошибка",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            btnWV.Enabled = true;

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            i++; j++;
           
            startClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxWord.Visible = true;
            btnFullW.Enabled = true;
            btnst.Enabled = false;
            btnnext.Enabled = false;
        }

        private void btnFullW_Click(object sender, EventArgs e)
        {
            if (textBoxWord.Text == word) {
                MessageBox.Show("Winner");
                for (int i = 0; i < word.Length; i++)
                {
                    tb[i].Text = word[i].ToString();
                }

            }
            else MessageBox.Show("Luser");
        }
    }


}

