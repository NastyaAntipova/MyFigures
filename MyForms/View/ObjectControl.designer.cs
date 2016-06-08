namespace Model_View
{
    partial class ObjectControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Parallelepiped_RadioButton = new System.Windows.Forms.RadioButton();
            this.Piramid_RadioButton = new System.Windows.Forms.RadioButton();
            this.Spere_RadioButton = new System.Windows.Forms.RadioButton();
            this.piramideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZBox = new System.Windows.Forms.TextBox();
            this.YBox = new System.Windows.Forms.TextBox();
            this.XBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.piramidControll1 = new Model_View.PiramidControll();
            this.parallelepipedContrloll1 = new Model_View.ParallelepipedContrloll();
            this.ballControll1 = new Model_View.BallControll();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piramideBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.piramidControll1);
            this.groupBox2.Controls.Add(this.ZBox);
            this.groupBox2.Controls.Add(this.YBox);
            this.groupBox2.Controls.Add(this.XBox);
            this.groupBox2.Controls.Add(this.parallelepipedContrloll1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.ballControll1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 292);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбирите фигуру";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Parallelepiped_RadioButton);
            this.groupBox1.Controls.Add(this.Piramid_RadioButton);
            this.groupBox1.Controls.Add(this.Spere_RadioButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 92);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // Parallelepiped_RadioButton
            // 
            this.Parallelepiped_RadioButton.AutoSize = true;
            this.Parallelepiped_RadioButton.Location = new System.Drawing.Point(6, 42);
            this.Parallelepiped_RadioButton.Name = "Parallelepiped_RadioButton";
            this.Parallelepiped_RadioButton.Size = new System.Drawing.Size(111, 17);
            this.Parallelepiped_RadioButton.TabIndex = 9;
            this.Parallelepiped_RadioButton.Text = "Параллепепипед";
            this.Parallelepiped_RadioButton.UseVisualStyleBackColor = true;
            this.Parallelepiped_RadioButton.CheckedChanged += new System.EventHandler(this.Parallelepiped_RadioButton_CheckedChanged_1);
            // 
            // Piramid_RadioButton
            // 
            this.Piramid_RadioButton.AutoSize = true;
            this.Piramid_RadioButton.Location = new System.Drawing.Point(6, 65);
            this.Piramid_RadioButton.Name = "Piramid_RadioButton";
            this.Piramid_RadioButton.Size = new System.Drawing.Size(77, 17);
            this.Piramid_RadioButton.TabIndex = 10;
            this.Piramid_RadioButton.Text = "Пирамида";
            this.Piramid_RadioButton.UseVisualStyleBackColor = true;
            this.Piramid_RadioButton.CheckedChanged += new System.EventHandler(this.Piramid_RadioButton_CheckedChanged_1);
            // 
            // Spere_RadioButton
            // 
            this.Spere_RadioButton.AutoSize = true;
            this.Spere_RadioButton.Location = new System.Drawing.Point(6, 19);
            this.Spere_RadioButton.Name = "Spere_RadioButton";
            this.Spere_RadioButton.Size = new System.Drawing.Size(46, 17);
            this.Spere_RadioButton.TabIndex = 8;
            this.Spere_RadioButton.Text = "Шар";
            this.Spere_RadioButton.CheckedChanged += new System.EventHandler(this.Spere_RadioButton_CheckedChanged_1);
            // 
            // ZBox
            // 
            this.ZBox.Location = new System.Drawing.Point(217, 263);
            this.ZBox.Name = "ZBox";
            this.ZBox.Size = new System.Drawing.Size(62, 20);
            this.ZBox.TabIndex = 29;
            // 
            // YBox
            // 
            this.YBox.Location = new System.Drawing.Point(126, 266);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(62, 20);
            this.YBox.TabIndex = 28;
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(31, 266);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(62, 20);
            this.XBox.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Z:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "X:";
            // 
            // piramidControll1
            // 
            this.piramidControll1.Location = new System.Drawing.Point(12, 162);
            this.piramidControll1.Name = "piramidControll1";
            this.piramidControll1.Size = new System.Drawing.Size(133, 98);
            this.piramidControll1.TabIndex = 30;
            this.piramidControll1.Visible = false;
            // 
            // parallelepipedContrloll1
            // 
            this.parallelepipedContrloll1.ForeColor = System.Drawing.Color.Black;
            this.parallelepipedContrloll1.Location = new System.Drawing.Point(163, 124);
            this.parallelepipedContrloll1.Name = "parallelepipedContrloll1";
            this.parallelepipedContrloll1.Size = new System.Drawing.Size(133, 133);
            this.parallelepipedContrloll1.TabIndex = 13;
            this.parallelepipedContrloll1.Visible = false;
            this.parallelepipedContrloll1.Load += new System.EventHandler(this.parallelepipedContrloll1_Load);
            // 
            // ballControll1
            // 
            this.ballControll1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ballControll1.Location = new System.Drawing.Point(12, 124);
            this.ballControll1.Name = "ballControll1";
            this.ballControll1.Size = new System.Drawing.Size(131, 40);
            this.ballControll1.TabIndex = 12;
            this.ballControll1.Visible = false;
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(312, 300);
            this.Load += new System.EventHandler(this.ObjectControl_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piramideBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource piramideBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Parallelepiped_RadioButton;
        private System.Windows.Forms.RadioButton Piramid_RadioButton;
        private System.Windows.Forms.RadioButton Spere_RadioButton;
        private ParallelepipedContrloll parallelepipedContrloll1;
        private BallControll ballControll1;
        private System.Windows.Forms.TextBox ZBox;
        private System.Windows.Forms.TextBox YBox;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private PiramidControll piramidControll1;

    }
}
