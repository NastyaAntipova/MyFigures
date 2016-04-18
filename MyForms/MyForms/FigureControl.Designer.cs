namespace MyForms
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
            this.NameFigure = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.LabelZ = new System.Windows.Forms.Label();
            this.LabelVolume = new System.Windows.Forms.Label();
            this.NumericX = new System.Windows.Forms.NumericUpDown();
            this.NumericY = new System.Windows.Forms.NumericUpDown();
            this.NumericZ = new System.Windows.Forms.NumericUpDown();
            this.NameVolume = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericZ)).BeginInit();
            this.SuspendLayout();
            // 
            // NameFigure
            // 
            this.NameFigure.Location = new System.Drawing.Point(0, 27);
            this.NameFigure.Name = "NameFigure";
            this.NameFigure.Size = new System.Drawing.Size(167, 20);
            this.NameFigure.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(3, 11);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(6, 63);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(14, 13);
            this.LabelX.TabIndex = 2;
            this.LabelX.Text = "X";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(6, 117);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(14, 13);
            this.LabelY.TabIndex = 3;
            this.LabelY.Text = "Y";
            // 
            // LabelZ
            // 
            this.LabelZ.AutoSize = true;
            this.LabelZ.Location = new System.Drawing.Point(6, 185);
            this.LabelZ.Name = "LabelZ";
            this.LabelZ.Size = new System.Drawing.Size(14, 13);
            this.LabelZ.TabIndex = 6;
            this.LabelZ.Text = "Z";
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.Location = new System.Drawing.Point(6, 244);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(42, 13);
            this.LabelVolume.TabIndex = 7;
            this.LabelVolume.Text = "Volume";
            // 
            // NumericX
            // 
            this.NumericX.Location = new System.Drawing.Point(6, 79);
            this.NumericX.Name = "NumericX";
            this.NumericX.Size = new System.Drawing.Size(72, 20);
            this.NumericX.TabIndex = 9;
            // 
            // NumericY
            // 
            this.NumericY.Location = new System.Drawing.Point(6, 133);
            this.NumericY.Name = "NumericY";
            this.NumericY.Size = new System.Drawing.Size(72, 20);
            this.NumericY.TabIndex = 10;
            // 
            // NumericZ
            // 
            this.NumericZ.Location = new System.Drawing.Point(6, 201);
            this.NumericZ.Name = "NumericZ";
            this.NumericZ.Size = new System.Drawing.Size(72, 20);
            this.NumericZ.TabIndex = 11;
            // 
            // NameVolume
            // 
            this.NameVolume.Location = new System.Drawing.Point(3, 260);
            this.NameVolume.Name = "NameVolume";
            this.NameVolume.Size = new System.Drawing.Size(100, 20);
            this.NameVolume.TabIndex = 12;
            // 
            // FigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NameVolume);
            this.Controls.Add(this.NumericZ);
            this.Controls.Add(this.NumericY);
            this.Controls.Add(this.NumericX);
            this.Controls.Add(this.LabelVolume);
            this.Controls.Add(this.LabelZ);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.NameFigure);
            this.Name = "FigureControl";
            this.Size = new System.Drawing.Size(182, 317);
            this.Load += new System.EventHandler(this.FifureControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameFigure;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.Label LabelZ;
        private System.Windows.Forms.Label LabelVolume;
        private System.Windows.Forms.NumericUpDown NumericX;
        private System.Windows.Forms.NumericUpDown NumericY;
        private System.Windows.Forms.NumericUpDown NumericZ;
        private System.Windows.Forms.TextBox NameVolume;
    }
}
