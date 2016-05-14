namespace View
{
    partial class AddModifyFigureForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Rhombus = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фигуру";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TextBox8);
            this.groupBox2.Controls.Add(this.TextBox7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Cancel);
            this.groupBox2.Controls.Add(this.Calculate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TextBox6);
            this.groupBox2.Controls.Add(this.TextBox5);
            this.groupBox2.Controls.Add(this.TextBox4);
            this.groupBox2.Controls.Add(this.TextBox2);
            this.groupBox2.Controls.Add(this.TextBox1);
            this.groupBox2.Location = new System.Drawing.Point(8, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 224);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TextBox8
            // 
            this.TextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox8.Location = new System.Drawing.Point(303, 159);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(100, 20);
            this.TextBox8.TabIndex = 17;
            this.TextBox8.Visible = false;
            // 
            // TextBox7
            // 
            this.TextBox7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox7.Location = new System.Drawing.Point(6, 119);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(100, 20);
            this.TextBox7.TabIndex = 16;
            this.TextBox7.Visible = false;
            this.TextBox7.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Координата Y";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Координата X";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(302, 198);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Calculate
            // 
            this.Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Calculate.Location = new System.Drawing.Point(6, 198);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Радиус";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Длина";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Диагональ 2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Диагональ 1";
            // 
            // TextBox6
            // 
            this.TextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox6.Location = new System.Drawing.Point(303, 119);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(100, 20);
            this.TextBox6.TabIndex = 5;
            this.TextBox6.Visible = false;
            this.TextBox6.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // TextBox5
            // 
            this.TextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox5.Location = new System.Drawing.Point(303, 80);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(100, 20);
            this.TextBox5.TabIndex = 4;
            this.TextBox5.Visible = false;
            this.TextBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // TextBox4
            // 
            this.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBox4.Location = new System.Drawing.Point(303, 41);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(100, 20);
            this.TextBox4.TabIndex = 3;
            this.TextBox4.Visible = false;
            this.TextBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // TextBox2
            // 
            this.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox2.Location = new System.Drawing.Point(5, 80);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 1;
            this.TextBox2.Visible = false;
            this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox1.Location = new System.Drawing.Point(5, 41);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Visible = false;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Rectangle);
            this.groupBox3.Controls.Add(this.Rhombus);
            this.groupBox3.Controls.Add(this.Circle);
            this.groupBox3.Location = new System.Drawing.Point(8, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 87);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.Rectangle.Location = new System.Drawing.Point(6, 37);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(105, 17);
            this.Rectangle.TabIndex = 1;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.CheckedChanged += new System.EventHandler(this.RectangleRadioButton2_CheckedChanged);
            this.Rectangle.Click += new System.EventHandler(this.RectangleRadioButton2_CheckedChanged);
            // 
            // Rhombus
            // 
            this.Rhombus.AutoSize = true;
            this.Rhombus.Location = new System.Drawing.Point(6, 14);
            this.Rhombus.Name = "Rhombus";
            this.Rhombus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rhombus.Size = new System.Drawing.Size(52, 17);
            this.Rhombus.TabIndex = 0;
            this.Rhombus.Text = "Ромб";
            this.Rhombus.UseVisualStyleBackColor = true;
            this.Rhombus.CheckedChanged += new System.EventHandler(this.TriangleRadioButton1_CheckedChanged);
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(6, 60);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(48, 17);
            this.Circle.TabIndex = 2;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.CheckedChanged += new System.EventHandler(this.CircleRadioButton3_CheckedChanged);
            // 
            // AddModifyFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(464, 408);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddModifyFigureForm";
            this.Text = "AddModifyFigureForm";
            this.Load += new System.EventHandler(this.AddModifyFigureForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox6;
        private System.Windows.Forms.TextBox TextBox5;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton Rhombus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox TextBox8;
        private System.Windows.Forms.TextBox TextBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}