namespace Aug13_EventDriven_MizaBau
{
    partial class FrmCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxInput1 = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.txtBoxInput2 = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number:";
            // 
            // txtBoxInput1
            // 
            this.txtBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput1.Location = new System.Drawing.Point(221, 78);
            this.txtBoxInput1.Name = "txtBoxInput1";
            this.txtBoxInput1.Size = new System.Drawing.Size(133, 26);
            this.txtBoxInput1.TabIndex = 2;
            // 
            // cbOperator
            // 
            this.cbOperator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(259, 106);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(54, 27);
            this.cbOperator.TabIndex = 3;
            // 
            // txtBoxInput2
            // 
            this.txtBoxInput2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput2.Location = new System.Drawing.Point(221, 134);
            this.txtBoxInput2.Name = "txtBoxInput2";
            this.txtBoxInput2.Size = new System.Drawing.Size(133, 26);
            this.txtBoxInput2.TabIndex = 4;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.BackColor = System.Drawing.Color.Transparent;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(150, 178);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(62, 20);
            this.Answer.TabIndex = 5;
            this.Answer.Text = "Answer";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.Location = new System.Drawing.Point(283, 183);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(11, 13);
            this.lblDisplayTotal.TabIndex = 6;
            this.lblDisplayTotal.Text = "-";
            this.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(221, 221);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(133, 34);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "Calculate";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calculator";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Rage Italic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_close.Location = new System.Drawing.Point(335, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 29);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Rage Italic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_minimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.Location = new System.Drawing.Point(306, 1);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 29);
            this.btn_minimize.TabIndex = 10;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aug13_EventDriven_MizaBau.Properties.Resources.paper_line_vector_background_detailed_lined_paper_texture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 302);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.txtBoxInput2);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.txtBoxInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalculator";
            this.Text = "Calculator";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxInput1;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.TextBox txtBoxInput2;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
    }
}

