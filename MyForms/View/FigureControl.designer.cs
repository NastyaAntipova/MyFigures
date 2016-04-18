namespace View
{
    partial class FigureControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ParalButton = new System.Windows.Forms.RadioButton();
            this.PyrButton = new System.Windows.Forms.RadioButton();
            this.BallButton = new System.Windows.Forms.RadioButton();
            this.BallBox = new System.Windows.Forms.TextBox();
            this.PyrBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PyrBox2 = new System.Windows.Forms.TextBox();
            this.ABox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.CBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.XBox = new System.Windows.Forms.TextBox();
            this.YBox = new System.Windows.Forms.TextBox();
            this.ZBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(16, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(46, 13);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Фигура";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ParalButton);
            this.panel1.Controls.Add(this.PyrButton);
            this.panel1.Controls.Add(this.BallButton);
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 99);
            this.panel1.TabIndex = 2;
            // 
            // ParalButton
            // 
            this.ParalButton.AutoSize = true;
            this.ParalButton.Location = new System.Drawing.Point(19, 73);
            this.ParalButton.Name = "ParalButton";
            this.ParalButton.Size = new System.Drawing.Size(123, 17);
            this.ParalButton.TabIndex = 4;
            this.ParalButton.TabStop = true;
            this.ParalButton.Text = "Параллелелепипед";
            this.ParalButton.UseVisualStyleBackColor = true;
            this.ParalButton.CheckedChanged += new System.EventHandler(this.ParalButton_CheckedChanged);
            // 
            // PyrButton
            // 
            this.PyrButton.AutoSize = true;
            this.PyrButton.Location = new System.Drawing.Point(19, 50);
            this.PyrButton.Name = "PyrButton";
            this.PyrButton.Size = new System.Drawing.Size(77, 17);
            this.PyrButton.TabIndex = 3;
            this.PyrButton.TabStop = true;
            this.PyrButton.Text = "Пирамида";
            this.PyrButton.UseVisualStyleBackColor = true;
            this.PyrButton.CheckedChanged += new System.EventHandler(this.PyrButton_CheckedChanged);
            // 
            // BallButton
            // 
            this.BallButton.AutoSize = true;
            this.BallButton.Location = new System.Drawing.Point(19, 27);
            this.BallButton.Name = "BallButton";
            this.BallButton.Size = new System.Drawing.Size(46, 17);
            this.BallButton.TabIndex = 2;
            this.BallButton.TabStop = true;
            this.BallButton.Text = "Шар";
            this.BallButton.UseVisualStyleBackColor = true;
            this.BallButton.CheckedChanged += new System.EventHandler(this.BallButton_CheckedChanged);
            // 
            // BallBox
            // 
            this.BallBox.Location = new System.Drawing.Point(129, 122);
            this.BallBox.Name = "BallBox";
            this.BallBox.Size = new System.Drawing.Size(100, 20);
            this.BallBox.TabIndex = 3;
            // 
            // PyrBox
            // 
            this.PyrBox.Location = new System.Drawing.Point(129, 182);
            this.PyrBox.Name = "PyrBox";
            this.PyrBox.Size = new System.Drawing.Size(100, 20);
            this.PyrBox.TabIndex = 4;
            this.PyrBox.TextChanged += new System.EventHandler(this.PyrBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Шар:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Радиус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пирамида:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Высота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "S основания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Параллелепипед:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "А";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "В";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "С";
            // 
            // PyrBox2
            // 
            this.PyrBox2.Location = new System.Drawing.Point(129, 214);
            this.PyrBox2.Name = "PyrBox2";
            this.PyrBox2.Size = new System.Drawing.Size(100, 20);
            this.PyrBox2.TabIndex = 14;
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(129, 274);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(100, 20);
            this.ABox.TabIndex = 15;
            // 
            // BBox
            // 
            this.BBox.Location = new System.Drawing.Point(129, 306);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(100, 20);
            this.BBox.TabIndex = 16;
            // 
            // CBox
            // 
            this.CBox.Location = new System.Drawing.Point(129, 335);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(100, 20);
            this.CBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "X:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Z:";
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(24, 391);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(62, 20);
            this.XBox.TabIndex = 21;
            this.XBox.TextChanged += new System.EventHandler(this.XBox_TextChanged);
            // 
            // YBox
            // 
            this.YBox.Location = new System.Drawing.Point(119, 391);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(62, 20);
            this.YBox.TabIndex = 22;
            // 
            // ZBox
            // 
            this.ZBox.Location = new System.Drawing.Point(210, 391);
            this.ZBox.Name = "ZBox";
            this.ZBox.Size = new System.Drawing.Size(62, 20);
            this.ZBox.TabIndex = 23;
            // 
            // FigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ZBox);
            this.Controls.Add(this.YBox);
            this.Controls.Add(this.XBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.BBox);
            this.Controls.Add(this.ABox);
            this.Controls.Add(this.PyrBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PyrBox);
            this.Controls.Add(this.BallBox);
            this.Controls.Add(this.panel1);
            this.Name = "FigureControl";
            this.Size = new System.Drawing.Size(291, 484);
            this.Load += new System.EventHandler(this.FifureControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ParalButton;
        private System.Windows.Forms.RadioButton PyrButton;
        private System.Windows.Forms.RadioButton BallButton;
        private System.Windows.Forms.TextBox BallBox;
        private System.Windows.Forms.TextBox PyrBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PyrBox2;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox CBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.TextBox YBox;
        private System.Windows.Forms.TextBox ZBox;
    }
}
