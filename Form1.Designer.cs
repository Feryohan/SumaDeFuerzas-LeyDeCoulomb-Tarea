namespace Suma_de_Fuerzas___Ley_de_Coulomb__Tarea_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.txtBoxCarga1 = new System.Windows.Forms.TextBox();
            this.txtBoxCarga2 = new System.Windows.Forms.TextBox();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.labelCarga1 = new System.Windows.Forms.Label();
            this.labelCarga2 = new System.Windows.Forms.Label();
            this.txtBoxDistancia = new System.Windows.Forms.TextBox();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxDQ1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxSumFue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxEqui = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBoxError = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBoxFuerzas = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxCarga1
            // 
            this.txtBoxCarga1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCarga1.Location = new System.Drawing.Point(91, 192);
            this.txtBoxCarga1.Name = "txtBoxCarga1";
            this.txtBoxCarga1.Size = new System.Drawing.Size(119, 22);
            this.txtBoxCarga1.TabIndex = 0;
            // 
            // txtBoxCarga2
            // 
            this.txtBoxCarga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCarga2.Location = new System.Drawing.Point(91, 239);
            this.txtBoxCarga2.Name = "txtBoxCarga2";
            this.txtBoxCarga2.Size = new System.Drawing.Size(119, 22);
            this.txtBoxCarga2.TabIndex = 1;
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.BackColor = System.Drawing.Color.Yellow;
            this.bttnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCalcular.Location = new System.Drawing.Point(41, 345);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(169, 54);
            this.bttnCalcular.TabIndex = 2;
            this.bttnCalcular.Text = "Graficar";
            this.bttnCalcular.UseVisualStyleBackColor = false;
            this.bttnCalcular.Click += new System.EventHandler(this.BttnCalcular_Click);
            // 
            // labelCarga1
            // 
            this.labelCarga1.AutoSize = true;
            this.labelCarga1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarga1.Location = new System.Drawing.Point(12, 193);
            this.labelCarga1.Name = "labelCarga1";
            this.labelCarga1.Size = new System.Drawing.Size(62, 16);
            this.labelCarga1.TabIndex = 3;
            this.labelCarga1.Text = "Carga 1";
            // 
            // labelCarga2
            // 
            this.labelCarga2.AutoSize = true;
            this.labelCarga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarga2.Location = new System.Drawing.Point(12, 240);
            this.labelCarga2.Name = "labelCarga2";
            this.labelCarga2.Size = new System.Drawing.Size(62, 16);
            this.labelCarga2.TabIndex = 4;
            this.labelCarga2.Text = "Carga 2";
            // 
            // txtBoxDistancia
            // 
            this.txtBoxDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDistancia.Location = new System.Drawing.Point(91, 294);
            this.txtBoxDistancia.Name = "txtBoxDistancia";
            this.txtBoxDistancia.Size = new System.Drawing.Size(119, 22);
            this.txtBoxDistancia.TabIndex = 1;
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistancia.Location = new System.Drawing.Point(12, 295);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(50, 16);
            this.labelDistancia.TabIndex = 4;
            this.labelDistancia.Text = "Radio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "[μC] ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "[μC]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "[mm]";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(262, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1000, 600);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Colocamos 1 carga puntual entre 2 cargas positivas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gráfica de";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Suma de Fuerzas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "[kN]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(761, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "[mm]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Distancia desde Q1";
            // 
            // txtBoxDQ1
            // 
            this.txtBoxDQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDQ1.Location = new System.Drawing.Point(15, 450);
            this.txtBoxDQ1.Name = "txtBoxDQ1";
            this.txtBoxDQ1.ReadOnly = true;
            this.txtBoxDQ1.Size = new System.Drawing.Size(182, 22);
            this.txtBoxDQ1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(203, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "[mm]";
            // 
            // txtBoxSumFue
            // 
            this.txtBoxSumFue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSumFue.Location = new System.Drawing.Point(17, 513);
            this.txtBoxSumFue.Name = "txtBoxSumFue";
            this.txtBoxSumFue.ReadOnly = true;
            this.txtBoxSumFue.Size = new System.Drawing.Size(182, 22);
            this.txtBoxSumFue.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(205, 516);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "[kN]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Suma de fuerzas";
            // 
            // txtBoxEqui
            // 
            this.txtBoxEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEqui.Location = new System.Drawing.Point(555, 658);
            this.txtBoxEqui.Name = "txtBoxEqui";
            this.txtBoxEqui.ReadOnly = true;
            this.txtBoxEqui.Size = new System.Drawing.Size(113, 22);
            this.txtBoxEqui.TabIndex = 1;
            this.txtBoxEqui.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(674, 661);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "[mm]";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(326, 658);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Distancia de Equilibrio (Real)";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 632);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Suma de Fuerzas (Teórico) = 0 [kN]";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(55, 594);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "Valores de Equilibrio";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 655);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(238, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Distancia de Equilibrio (Teórico) = [kN]";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(731, 632);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "%Error";
            this.label18.Visible = false;
            // 
            // txtBoxError
            // 
            this.txtBoxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxError.Location = new System.Drawing.Point(734, 655);
            this.txtBoxError.Name = "txtBoxError";
            this.txtBoxError.ReadOnly = true;
            this.txtBoxError.Size = new System.Drawing.Size(113, 22);
            this.txtBoxError.TabIndex = 1;
            this.txtBoxError.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(326, 632);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Suma de Fuerzas (Real)";
            this.label19.Visible = false;
            // 
            // txtBoxFuerzas
            // 
            this.txtBoxFuerzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFuerzas.Location = new System.Drawing.Point(555, 626);
            this.txtBoxFuerzas.Name = "txtBoxFuerzas";
            this.txtBoxFuerzas.ReadOnly = true;
            this.txtBoxFuerzas.Size = new System.Drawing.Size(113, 22);
            this.txtBoxFuerzas.TabIndex = 1;
            this.txtBoxFuerzas.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(674, 626);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 16);
            this.label20.TabIndex = 3;
            this.label20.Text = "[mm]";
            this.label20.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(674, 629);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 16);
            this.label21.TabIndex = 3;
            this.label21.Text = "[kN]";
            this.label21.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(857, 683);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelDistancia);
            this.Controls.Add(this.labelCarga2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCarga1);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.txtBoxError);
            this.Controls.Add(this.txtBoxFuerzas);
            this.Controls.Add(this.txtBoxEqui);
            this.Controls.Add(this.txtBoxSumFue);
            this.Controls.Add(this.txtBoxDQ1);
            this.Controls.Add(this.txtBoxDistancia);
            this.Controls.Add(this.txtBoxCarga2);
            this.Controls.Add(this.txtBoxCarga1);
            this.Name = "Form1";
            this.Text = "SumaDeFuerzas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCarga1;
        private System.Windows.Forms.TextBox txtBoxCarga2;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Label labelCarga1;
        private System.Windows.Forms.Label labelCarga2;
        private System.Windows.Forms.TextBox txtBoxDistancia;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxDQ1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxSumFue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxEqui;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBoxError;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxFuerzas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

