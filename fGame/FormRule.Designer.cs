namespace fGame
{
    partial class FormRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRule));
            this.labelRule = new System.Windows.Forms.Label();
            this.labelRul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRuleOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRule
            // 
            this.labelRule.AutoSize = true;
            this.labelRule.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRule.Location = new System.Drawing.Point(30, 23);
            this.labelRule.Name = "labelRule";
            this.labelRule.Size = new System.Drawing.Size(124, 27);
            this.labelRule.TabIndex = 0;
            this.labelRule.Text = "Поле чудес";
            // 
            // labelRul
            // 
            this.labelRul.AutoSize = true;
            this.labelRul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRul.Location = new System.Drawing.Point(32, 59);
            this.labelRul.Name = "labelRul";
            this.labelRul.Size = new System.Drawing.Size(67, 16);
            this.labelRul.TabIndex = 1;
            this.labelRul.Text = "Про игру";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnRuleOK
            // 
            this.btnRuleOK.Location = new System.Drawing.Point(235, 205);
            this.btnRuleOK.Name = "btnRuleOK";
            this.btnRuleOK.Size = new System.Drawing.Size(75, 23);
            this.btnRuleOK.TabIndex = 3;
            this.btnRuleOK.Text = "OK";
            this.btnRuleOK.UseVisualStyleBackColor = true;
            this.btnRuleOK.Click += new System.EventHandler(this.btnRuleOK_Click);
            // 
            // FormRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 262);
            this.Controls.Add(this.btnRuleOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRul);
            this.Controls.Add(this.labelRule);
            this.Name = "FormRule";
            this.Text = "Правила игры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRule;
        private System.Windows.Forms.Label labelRul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRuleOK;
    }
}