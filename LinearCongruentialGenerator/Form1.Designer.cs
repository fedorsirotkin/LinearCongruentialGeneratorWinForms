namespace LinearCongruentialGenerator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NMAX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // Histogram
            // 
            chartArea3.Name = "ChartArea1";
            this.Histogram.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Histogram.Legends.Add(legend3);
            this.Histogram.Location = new System.Drawing.Point(286, 66);
            this.Histogram.Margin = new System.Windows.Forms.Padding(4);
            this.Histogram.Name = "Histogram";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendToolTip = "Сгенерированные случайные числа";
            series3.Name = "RND";
            this.Histogram.Series.Add(series3);
            this.Histogram.Size = new System.Drawing.Size(461, 272);
            this.Histogram.TabIndex = 0;
            this.Histogram.Text = "Гистограмма";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(12, 349);
            this.Calc.Margin = new System.Windows.Forms.Padding(4);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(735, 37);
            this.Calc.TabIndex = 1;
            this.Calc.Text = "Вычислить и построить гистограмму";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать в программу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(210, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "\"Линейный конгруэнтный генератор\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество генерируемых чисел:";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(12, 90);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(247, 24);
            this.N.TabIndex = 5;
            this.N.Text = "50";
            this.N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Диапазон от 0 до N, где N:";
            // 
            // NMAX
            // 
            this.NMAX.Location = new System.Drawing.Point(12, 148);
            this.NMAX.Name = "NMAX";
            this.NMAX.Size = new System.Drawing.Size(247, 24);
            this.NMAX.TabIndex = 5;
            this.NMAX.Text = "10";
            this.NMAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NMAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NMAX_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Множитель, где 0 <= a < m:";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(12, 205);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(247, 24);
            this.A.TabIndex = 5;
            this.A.Text = "1664525";
            this.A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Приращение, где 0 <= с < m:";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(12, 260);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(247, 24);
            this.C.TabIndex = 5;
            this.C.Text = "1013904223";
            this.C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.C_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Модуль, где 0 < m (напр.: 2^32):";
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(12, 314);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(247, 24);
            this.M.TabIndex = 5;
            this.M.Text = "4294967296";
            this.M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.M_KeyPress);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(550, 22);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(197, 37);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить гистограмму";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 395);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.M);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NMAX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Histogram);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Линейный конгруэнтный генератор";
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Histogram;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NMAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.Button Clear;
    }
}

