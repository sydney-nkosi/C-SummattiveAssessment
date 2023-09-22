namespace C_SummattiveAssessment
{
    partial class Words
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWords1 = new System.Windows.Forms.ComboBox();
            this.cbWords2 = new System.Windows.Forms.ComboBox();
            this.rbRemove1 = new System.Windows.Forms.RadioButton();
            this.rbRemove2 = new System.Windows.Forms.RadioButton();
            this.btnConcatenate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new word:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(175, 77);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(207, 20);
            this.txtWord.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(233, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add word";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a word:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select another word:";
            // 
            // cbWords1
            // 
            this.cbWords1.FormattingEnabled = true;
            this.cbWords1.Location = new System.Drawing.Point(97, 218);
            this.cbWords1.Name = "cbWords1";
            this.cbWords1.Size = new System.Drawing.Size(121, 21);
            this.cbWords1.TabIndex = 5;
            // 
            // cbWords2
            // 
            this.cbWords2.FormattingEnabled = true;
            this.cbWords2.Location = new System.Drawing.Point(370, 218);
            this.cbWords2.Name = "cbWords2";
            this.cbWords2.Size = new System.Drawing.Size(121, 21);
            this.cbWords2.TabIndex = 6;
            // 
            // rbRemove1
            // 
            this.rbRemove1.AutoSize = true;
            this.rbRemove1.Location = new System.Drawing.Point(97, 260);
            this.rbRemove1.Name = "rbRemove1";
            this.rbRemove1.Size = new System.Drawing.Size(65, 17);
            this.rbRemove1.TabIndex = 7;
            this.rbRemove1.TabStop = true;
            this.rbRemove1.Text = "Remove";
            this.rbRemove1.UseVisualStyleBackColor = true;
            this.rbRemove1.CheckedChanged += new System.EventHandler(this.rbRemove1_CheckedChanged);
            // 
            // rbRemove2
            // 
            this.rbRemove2.AutoSize = true;
            this.rbRemove2.Location = new System.Drawing.Point(370, 260);
            this.rbRemove2.Name = "rbRemove2";
            this.rbRemove2.Size = new System.Drawing.Size(65, 17);
            this.rbRemove2.TabIndex = 8;
            this.rbRemove2.TabStop = true;
            this.rbRemove2.Text = "Remove";
            this.rbRemove2.UseVisualStyleBackColor = true;
            this.rbRemove2.CheckedChanged += new System.EventHandler(this.rbRemove2_CheckedChanged);
            // 
            // btnConcatenate
            // 
            this.btnConcatenate.Location = new System.Drawing.Point(233, 313);
            this.btnConcatenate.Name = "btnConcatenate";
            this.btnConcatenate.Size = new System.Drawing.Size(81, 23);
            this.btnConcatenate.TabIndex = 9;
            this.btnConcatenate.Text = "Concatenate";
            this.btnConcatenate.UseVisualStyleBackColor = true;
            this.btnConcatenate.Click += new System.EventHandler(this.btnConcatenate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "OR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // lbDisplay
            // 
            this.lbDisplay.BackColor = System.Drawing.Color.White;
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.Location = new System.Drawing.Point(-3, 367);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(609, 50);
            this.lbDisplay.TabIndex = 11;
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 413);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConcatenate);
            this.Controls.Add(this.rbRemove2);
            this.Controls.Add(this.rbRemove1);
            this.Controls.Add(this.cbWords2);
            this.Controls.Add(this.cbWords1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Words";
            this.Text = "Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbWords1;
        private System.Windows.Forms.ComboBox cbWords2;
        private System.Windows.Forms.RadioButton rbRemove1;
        private System.Windows.Forms.RadioButton rbRemove2;
        private System.Windows.Forms.Button btnConcatenate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDisplay;
    }
}

