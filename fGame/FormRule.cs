using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fGame
{
    public partial class FormRule : Form
    {
        public FormRule()
        {
            InitializeComponent();
        }

        private void btnRuleOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
