namespace Secim
{
    partial class FrmSonuclar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSonuclar));
            this.chartIL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prbAil = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAOran = new System.Windows.Forms.Label();
            this.lblBOran = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prbBil = new System.Windows.Forms.ProgressBar();
            this.lblCOran = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prbCil = new System.Windows.Forms.ProgressBar();
            this.lblDOran = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prbDil = new System.Windows.Forms.ProgressBar();
            this.lblEOran = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.prbEil = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.chartILCE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.lblilceE = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.prbEilce = new System.Windows.Forms.ProgressBar();
            this.lblilceD = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.prbDilce = new System.Windows.Forms.ProgressBar();
            this.lblilceC = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.prbCilce = new System.Windows.Forms.ProgressBar();
            this.lblilceB = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.prbBilce = new System.Windows.Forms.ProgressBar();
            this.lblilceA = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.prbAilce = new System.Windows.Forms.ProgressBar();
            this.lblIL = new System.Windows.Forms.Label();
            this.lblILCE = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartILCE)).BeginInit();
            this.SuspendLayout();
            // 
            // chartIL
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIL.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIL.Legends.Add(legend1);
            this.chartIL.Location = new System.Drawing.Point(12, 68);
            this.chartIL.Name = "chartIL";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "İL Parti Oyları";
            this.chartIL.Series.Add(series1);
            this.chartIL.Size = new System.Drawing.Size(658, 309);
            this.chartIL.TabIndex = 0;
            this.chartIL.Text = "chart1";
            // 
            // prbAil
            // 
            this.prbAil.Location = new System.Drawing.Point(129, 461);
            this.prbAil.Name = "prbAil";
            this.prbAil.Size = new System.Drawing.Size(335, 37);
            this.prbAil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "A Parti";
            // 
            // lblAOran
            // 
            this.lblAOran.AutoSize = true;
            this.lblAOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAOran.Location = new System.Drawing.Point(498, 471);
            this.lblAOran.Name = "lblAOran";
            this.lblAOran.Size = new System.Drawing.Size(60, 20);
            this.lblAOran.TabIndex = 3;
            this.lblAOran.Text = "A Parti";
            // 
            // lblBOran
            // 
            this.lblBOran.AutoSize = true;
            this.lblBOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBOran.Location = new System.Drawing.Point(498, 530);
            this.lblBOran.Name = "lblBOran";
            this.lblBOran.Size = new System.Drawing.Size(60, 20);
            this.lblBOran.TabIndex = 6;
            this.lblBOran.Text = "A Parti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "C Parti";
            // 
            // prbBil
            // 
            this.prbBil.Location = new System.Drawing.Point(129, 513);
            this.prbBil.Name = "prbBil";
            this.prbBil.Size = new System.Drawing.Size(335, 37);
            this.prbBil.TabIndex = 4;
            // 
            // lblCOran
            // 
            this.lblCOran.AutoSize = true;
            this.lblCOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCOran.Location = new System.Drawing.Point(498, 590);
            this.lblCOran.Name = "lblCOran";
            this.lblCOran.Size = new System.Drawing.Size(60, 20);
            this.lblCOran.TabIndex = 9;
            this.lblCOran.Text = "A Parti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "B Parti";
            // 
            // prbCil
            // 
            this.prbCil.Location = new System.Drawing.Point(129, 573);
            this.prbCil.Name = "prbCil";
            this.prbCil.Size = new System.Drawing.Size(335, 37);
            this.prbCil.TabIndex = 7;
            // 
            // lblDOran
            // 
            this.lblDOran.AutoSize = true;
            this.lblDOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDOran.Location = new System.Drawing.Point(498, 647);
            this.lblDOran.Name = "lblDOran";
            this.lblDOran.Size = new System.Drawing.Size(60, 20);
            this.lblDOran.TabIndex = 12;
            this.lblDOran.Text = "A Parti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 647);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "D Parti";
            // 
            // prbDil
            // 
            this.prbDil.Location = new System.Drawing.Point(129, 630);
            this.prbDil.Name = "prbDil";
            this.prbDil.Size = new System.Drawing.Size(335, 37);
            this.prbDil.TabIndex = 10;
            // 
            // lblEOran
            // 
            this.lblEOran.AutoSize = true;
            this.lblEOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEOran.Location = new System.Drawing.Point(498, 704);
            this.lblEOran.Name = "lblEOran";
            this.lblEOran.Size = new System.Drawing.Size(60, 20);
            this.lblEOran.TabIndex = 15;
            this.lblEOran.Text = "A Parti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(30, 704);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "E Parti";
            // 
            // prbEil
            // 
            this.prbEil.Location = new System.Drawing.Point(129, 694);
            this.prbEil.Name = "prbEil";
            this.prbEil.Size = new System.Drawing.Size(335, 37);
            this.prbEil.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(233, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Oy Dağılımları";
            // 
            // chartILCE
            // 
            chartArea2.Name = "ChartArea1";
            this.chartILCE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartILCE.Legends.Add(legend2);
            this.chartILCE.Location = new System.Drawing.Point(695, 68);
            this.chartILCE.Name = "chartILCE";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "İlçe Parti Oyları";
            this.chartILCE.Series.Add(series2);
            this.chartILCE.Size = new System.Drawing.Size(692, 309);
            this.chartILCE.TabIndex = 17;
            this.chartILCE.Text = "chart2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(967, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Oy Dağılımları";
            // 
            // lblilceE
            // 
            this.lblilceE.AutoSize = true;
            this.lblilceE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilceE.Location = new System.Drawing.Point(1215, 704);
            this.lblilceE.Name = "lblilceE";
            this.lblilceE.Size = new System.Drawing.Size(60, 20);
            this.lblilceE.TabIndex = 32;
            this.lblilceE.Text = "A Parti";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(747, 704);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "E Parti";
            // 
            // prbEilce
            // 
            this.prbEilce.Location = new System.Drawing.Point(846, 694);
            this.prbEilce.Name = "prbEilce";
            this.prbEilce.Size = new System.Drawing.Size(335, 37);
            this.prbEilce.TabIndex = 30;
            // 
            // lblilceD
            // 
            this.lblilceD.AutoSize = true;
            this.lblilceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilceD.Location = new System.Drawing.Point(1215, 647);
            this.lblilceD.Name = "lblilceD";
            this.lblilceD.Size = new System.Drawing.Size(60, 20);
            this.lblilceD.TabIndex = 29;
            this.lblilceD.Text = "A Parti";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(747, 647);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "D Parti";
            // 
            // prbDilce
            // 
            this.prbDilce.Location = new System.Drawing.Point(846, 630);
            this.prbDilce.Name = "prbDilce";
            this.prbDilce.Size = new System.Drawing.Size(335, 37);
            this.prbDilce.TabIndex = 27;
            // 
            // lblilceC
            // 
            this.lblilceC.AutoSize = true;
            this.lblilceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilceC.Location = new System.Drawing.Point(1215, 590);
            this.lblilceC.Name = "lblilceC";
            this.lblilceC.Size = new System.Drawing.Size(60, 20);
            this.lblilceC.TabIndex = 26;
            this.lblilceC.Text = "A Parti";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(747, 530);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "B Parti";
            // 
            // prbCilce
            // 
            this.prbCilce.Location = new System.Drawing.Point(846, 573);
            this.prbCilce.Name = "prbCilce";
            this.prbCilce.Size = new System.Drawing.Size(335, 37);
            this.prbCilce.TabIndex = 24;
            // 
            // lblilceB
            // 
            this.lblilceB.AutoSize = true;
            this.lblilceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilceB.Location = new System.Drawing.Point(1215, 530);
            this.lblilceB.Name = "lblilceB";
            this.lblilceB.Size = new System.Drawing.Size(60, 20);
            this.lblilceB.TabIndex = 23;
            this.lblilceB.Text = "A Parti";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(747, 590);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 20);
            this.label19.TabIndex = 22;
            this.label19.Text = "C Parti";
            // 
            // prbBilce
            // 
            this.prbBilce.Location = new System.Drawing.Point(846, 513);
            this.prbBilce.Name = "prbBilce";
            this.prbBilce.Size = new System.Drawing.Size(335, 37);
            this.prbBilce.TabIndex = 21;
            // 
            // lblilceA
            // 
            this.lblilceA.AutoSize = true;
            this.lblilceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilceA.Location = new System.Drawing.Point(1215, 471);
            this.lblilceA.Name = "lblilceA";
            this.lblilceA.Size = new System.Drawing.Size(60, 20);
            this.lblilceA.TabIndex = 20;
            this.lblilceA.Text = "A Parti";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(747, 471);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 20);
            this.label21.TabIndex = 19;
            this.label21.Text = "A Parti";
            // 
            // prbAilce
            // 
            this.prbAilce.Location = new System.Drawing.Point(846, 461);
            this.prbAilce.Name = "prbAilce";
            this.prbAilce.Size = new System.Drawing.Size(335, 37);
            this.prbAilce.TabIndex = 18;
            // 
            // lblIL
            // 
            this.lblIL.AutoSize = true;
            this.lblIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIL.Location = new System.Drawing.Point(200, 25);
            this.lblIL.Name = "lblIL";
            this.lblIL.Size = new System.Drawing.Size(153, 20);
            this.lblIL.TabIndex = 34;
            this.lblIL.Text = "İL OY SONUCLARI";
            // 
            // lblILCE
            // 
            this.lblILCE.AutoSize = true;
            this.lblILCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblILCE.Location = new System.Drawing.Point(937, 25);
            this.lblILCE.Name = "lblILCE";
            this.lblILCE.Size = new System.Drawing.Size(176, 20);
            this.lblILCE.TabIndex = 35;
            this.lblILCE.Text = "İLÇE OY SONUÇLARI";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 33);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSonuclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1399, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblILCE);
            this.Controls.Add(this.lblIL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblilceE);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.prbEilce);
            this.Controls.Add(this.lblilceD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.prbDilce);
            this.Controls.Add(this.lblilceC);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.prbCilce);
            this.Controls.Add(this.lblilceB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.prbBilce);
            this.Controls.Add(this.lblilceA);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.prbAilce);
            this.Controls.Add(this.chartILCE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblEOran);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prbEil);
            this.Controls.Add(this.lblDOran);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prbDil);
            this.Controls.Add(this.lblCOran);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prbCil);
            this.Controls.Add(this.lblBOran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prbBil);
            this.Controls.Add(this.lblAOran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prbAil);
            this.Controls.Add(this.chartIL);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmSonuclar";
            this.Text = "İl-İlçe Souçlar";
            this.Load += new System.EventHandler(this.FrmSonuclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartILCE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartIL;
        private System.Windows.Forms.ProgressBar prbAil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAOran;
        private System.Windows.Forms.Label lblBOran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prbBil;
        private System.Windows.Forms.Label lblCOran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar prbCil;
        private System.Windows.Forms.Label lblDOran;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar prbDil;
        private System.Windows.Forms.Label lblEOran;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar prbEil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartILCE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblilceE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar prbEilce;
        private System.Windows.Forms.Label lblilceD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ProgressBar prbDilce;
        private System.Windows.Forms.Label lblilceC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ProgressBar prbCilce;
        private System.Windows.Forms.Label lblilceB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ProgressBar prbBilce;
        private System.Windows.Forms.Label lblilceA;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ProgressBar prbAilce;
        private System.Windows.Forms.Label lblIL;
        private System.Windows.Forms.Label lblILCE;
        private System.Windows.Forms.Button button1;
    }
}