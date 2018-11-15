namespace HQ_Answers
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
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.lblCount3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.BackColor = System.Drawing.Color.White;
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtAnswer1.Location = new System.Drawing.Point(61, 375);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.ReadOnly = true;
            this.txtAnswer1.Size = new System.Drawing.Size(381, 45);
            this.txtAnswer1.TabIndex = 0;
            this.txtAnswer1.Text = "Answer 1";
            this.txtAnswer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.BackColor = System.Drawing.Color.White;
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtAnswer2.Location = new System.Drawing.Point(62, 426);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.ReadOnly = true;
            this.txtAnswer2.Size = new System.Drawing.Size(381, 45);
            this.txtAnswer2.TabIndex = 1;
            this.txtAnswer2.Text = "Answer 2";
            this.txtAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.BackColor = System.Drawing.Color.White;
            this.txtAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtAnswer3.Location = new System.Drawing.Point(61, 477);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.ReadOnly = true;
            this.txtAnswer3.Size = new System.Drawing.Size(381, 45);
            this.txtAnswer3.TabIndex = 2;
            this.txtAnswer3.Text = "Answer 3";
            this.txtAnswer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuestion
            // 
            this.txtQuestion.AcceptsReturn = true;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtQuestion.Location = new System.Drawing.Point(61, 107);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(380, 262);
            this.txtQuestion.TabIndex = 3;
            this.txtQuestion.Text = "Question";
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnFind.Location = new System.Drawing.Point(60, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(381, 89);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "FIND ANSWER!!!";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblCount1.Location = new System.Drawing.Point(446, 378);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(36, 39);
            this.lblCount1.TabIndex = 5;
            this.lblCount1.Text = "0";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblCount2.Location = new System.Drawing.Point(446, 429);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(36, 39);
            this.lblCount2.TabIndex = 6;
            this.lblCount2.Text = "0";
            // 
            // lblCount3
            // 
            this.lblCount3.AutoSize = true;
            this.lblCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblCount3.Location = new System.Drawing.Point(446, 480);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(36, 39);
            this.lblCount3.TabIndex = 7;
            this.lblCount3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(513, 534);
            this.Controls.Add(this.lblCount3);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.lblCount1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Label lblCount3;
    }
}

