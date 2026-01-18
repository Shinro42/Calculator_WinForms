namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn_frac = new Button();
            btn_unary_minus = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn_sqr = new Button();
            btn_mul = new Button();
            btn_plus = new Button();
            btn_sq = new Button();
            btn_backspace = new Button();
            btn_Clear = new Button();
            btn_clear_history = new Button();
            btn_perc = new Button();
            btn_equal = new Button();
            btn_div = new Button();
            btn_minus = new Button();
            History = new ListBox();
            textCalc = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(169, 241, 108);
            btn1.ForeColor = SystemColors.ControlText;
            btn1.Location = new Point(5, 135);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 70);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(169, 241, 108);
            btn2.ForeColor = SystemColors.ControlText;
            btn2.Location = new Point(75, 135);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 70);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(169, 241, 108);
            btn3.ForeColor = SystemColors.ControlText;
            btn3.Location = new Point(145, 135);
            btn3.Margin = new Padding(0);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 70);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(169, 241, 108);
            btn6.ForeColor = SystemColors.ControlText;
            btn6.Location = new Point(145, 205);
            btn6.Margin = new Padding(0);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 70);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(169, 241, 108);
            btn5.ForeColor = SystemColors.ControlText;
            btn5.Location = new Point(75, 205);
            btn5.Margin = new Padding(0);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 70);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(169, 241, 108);
            btn4.ForeColor = SystemColors.ControlText;
            btn4.Location = new Point(5, 205);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 70);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn_frac
            // 
            btn_frac.BackColor = Color.FromArgb(169, 241, 108);
            btn_frac.ForeColor = SystemColors.ControlText;
            btn_frac.Location = new Point(75, 345);
            btn_frac.Margin = new Padding(0);
            btn_frac.Name = "btn_frac";
            btn_frac.Size = new Size(70, 70);
            btn_frac.TabIndex = 11;
            btn_frac.Text = ",";
            btn_frac.UseVisualStyleBackColor = false;
            btn_frac.Click += btn_frac_Click;
            // 
            // btn_unary_minus
            // 
            btn_unary_minus.BackColor = Color.FromArgb(169, 241, 108);
            btn_unary_minus.ForeColor = SystemColors.ControlText;
            btn_unary_minus.Location = new Point(145, 65);
            btn_unary_minus.Margin = new Padding(0);
            btn_unary_minus.Name = "btn_unary_minus";
            btn_unary_minus.Size = new Size(70, 70);
            btn_unary_minus.TabIndex = 10;
            btn_unary_minus.Text = "±";
            btn_unary_minus.UseVisualStyleBackColor = false;
            btn_unary_minus.Click += btn_unary_minus_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(169, 241, 108);
            btn0.ForeColor = SystemColors.ControlText;
            btn0.Location = new Point(5, 345);
            btn0.Margin = new Padding(0);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 70);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(169, 241, 108);
            btn9.ForeColor = SystemColors.ControlText;
            btn9.Location = new Point(145, 275);
            btn9.Margin = new Padding(0);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 70);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(169, 241, 108);
            btn8.ForeColor = SystemColors.ControlText;
            btn8.Location = new Point(75, 275);
            btn8.Margin = new Padding(0);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 70);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(169, 241, 108);
            btn7.ForeColor = SystemColors.ControlText;
            btn7.Location = new Point(5, 275);
            btn7.Margin = new Padding(0);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 70);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn_sqr
            // 
            btn_sqr.BackColor = Color.FromArgb(169, 241, 108);
            btn_sqr.ForeColor = SystemColors.ControlText;
            btn_sqr.Location = new Point(285, 135);
            btn_sqr.Margin = new Padding(0);
            btn_sqr.Name = "btn_sqr";
            btn_sqr.Size = new Size(70, 70);
            btn_sqr.TabIndex = 17;
            btn_sqr.Text = "√";
            btn_sqr.UseVisualStyleBackColor = false;
            btn_sqr.Click += btn_sqr_Click;
            // 
            // btn_mul
            // 
            btn_mul.BackColor = Color.FromArgb(169, 241, 108);
            btn_mul.ForeColor = SystemColors.ControlText;
            btn_mul.Location = new Point(215, 205);
            btn_mul.Margin = new Padding(0);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(70, 70);
            btn_mul.TabIndex = 16;
            btn_mul.Text = "*";
            btn_mul.UseVisualStyleBackColor = false;
            btn_mul.Click += btn_mul_Click;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = Color.FromArgb(169, 241, 108);
            btn_plus.ForeColor = SystemColors.ControlText;
            btn_plus.Location = new Point(215, 65);
            btn_plus.Margin = new Padding(0);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(70, 70);
            btn_plus.TabIndex = 15;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_sq
            // 
            btn_sq.BackColor = Color.FromArgb(169, 241, 108);
            btn_sq.ForeColor = SystemColors.ControlText;
            btn_sq.Location = new Point(285, 65);
            btn_sq.Margin = new Padding(0);
            btn_sq.Name = "btn_sq";
            btn_sq.Size = new Size(70, 70);
            btn_sq.TabIndex = 14;
            btn_sq.Text = "x²";
            btn_sq.UseVisualStyleBackColor = false;
            btn_sq.Click += btn_sq_Click;
            // 
            // btn_backspace
            // 
            btn_backspace.BackColor = Color.FromArgb(169, 241, 108);
            btn_backspace.ForeColor = SystemColors.ControlText;
            btn_backspace.Location = new Point(75, 65);
            btn_backspace.Margin = new Padding(0);
            btn_backspace.Name = "btn_backspace";
            btn_backspace.Size = new Size(70, 70);
            btn_backspace.TabIndex = 13;
            btn_backspace.Text = "⌫";
            btn_backspace.UseVisualStyleBackColor = false;
            btn_backspace.Click += btn_backspace_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(169, 241, 108);
            btn_Clear.ForeColor = SystemColors.ControlText;
            btn_Clear.Location = new Point(5, 65);
            btn_Clear.Margin = new Padding(0);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(70, 70);
            btn_Clear.TabIndex = 12;
            btn_Clear.Text = "AC";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_clear_history
            // 
            btn_clear_history.BackColor = Color.FromArgb(169, 241, 108);
            btn_clear_history.ForeColor = SystemColors.ControlText;
            btn_clear_history.Location = new Point(285, 275);
            btn_clear_history.Margin = new Padding(0);
            btn_clear_history.Name = "btn_clear_history";
            btn_clear_history.Size = new Size(70, 140);
            btn_clear_history.TabIndex = 23;
            btn_clear_history.Text = "Clear";
            btn_clear_history.UseVisualStyleBackColor = false;
            btn_clear_history.Click += btn_clear_history_Click;
            // 
            // btn_perc
            // 
            btn_perc.BackColor = Color.FromArgb(169, 241, 108);
            btn_perc.ForeColor = SystemColors.ControlText;
            btn_perc.Location = new Point(285, 205);
            btn_perc.Margin = new Padding(0);
            btn_perc.Name = "btn_perc";
            btn_perc.Size = new Size(70, 70);
            btn_perc.TabIndex = 22;
            btn_perc.Text = "%";
            btn_perc.UseVisualStyleBackColor = false;
            btn_perc.Click += btn_perc_Click;
            // 
            // btn_equal
            // 
            btn_equal.BackColor = Color.FromArgb(169, 241, 108);
            btn_equal.ForeColor = SystemColors.ControlText;
            btn_equal.Location = new Point(145, 345);
            btn_equal.Margin = new Padding(0);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(140, 70);
            btn_equal.TabIndex = 21;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_div
            // 
            btn_div.BackColor = Color.FromArgb(169, 241, 108);
            btn_div.ForeColor = SystemColors.ControlText;
            btn_div.Location = new Point(215, 275);
            btn_div.Margin = new Padding(0);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(70, 70);
            btn_div.TabIndex = 19;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = false;
            btn_div.Click += btn_div_Click;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.FromArgb(169, 241, 108);
            btn_minus.ForeColor = SystemColors.ControlText;
            btn_minus.Location = new Point(215, 135);
            btn_minus.Margin = new Padding(0);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(70, 70);
            btn_minus.TabIndex = 18;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_minus_Click;
            // 
            // History
            // 
            History.BackColor = Color.FromArgb(103, 227, 0);
            History.BorderStyle = BorderStyle.None;
            History.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            History.FormattingEnabled = true;
            History.ItemHeight = 25;
            History.Location = new Point(5, 37);
            History.Name = "History";
            History.Size = new Size(350, 25);
            History.TabIndex = 24;
            // 
            // textCalc
            // 
            textCalc.BackColor = Color.FromArgb(103, 227, 0);
            textCalc.BorderStyle = BorderStyle.None;
            textCalc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textCalc.Location = new Point(5, 0);
            textCalc.Name = "textCalc";
            textCalc.Size = new Size(350, 26);
            textCalc.TabIndex = 25;
            textCalc.Text = "0";
            textCalc.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 227, 0);
            ClientSize = new Size(359, 416);
            Controls.Add(textCalc);
            Controls.Add(History);
            Controls.Add(btn_clear_history);
            Controls.Add(btn_perc);
            Controls.Add(btn_equal);
            Controls.Add(btn_div);
            Controls.Add(btn_minus);
            Controls.Add(btn_sqr);
            Controls.Add(btn_mul);
            Controls.Add(btn_plus);
            Controls.Add(btn_sq);
            Controls.Add(btn_backspace);
            Controls.Add(btn_Clear);
            Controls.Add(btn_frac);
            Controls.Add(btn_unary_minus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Калькулятор";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn_frac;
        private Button btn_unary_minus;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn_sqr;
        private Button btn_mul;
        private Button btn_plus;
        private Button btn_sq;
        private Button btn_backspace;
        private Button btn_Clear;
        private Button btn_clear_history;
        private Button btn_perc;
        private Button btn_equal;
        private Button btn_div;
        private Button btn_minus;
        private ListBox History;
        private TextBox textCalc;
    }
}
