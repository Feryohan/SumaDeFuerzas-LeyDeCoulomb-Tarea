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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxCarga1
            // 
            this.txtBoxCarga1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCarga1.Location = new System.Drawing.Point(91, 236);
            this.txtBoxCarga1.Name = "txtBoxCarga1";
            this.txtBoxCarga1.Size = new System.Drawing.Size(119, 22);
            this.txtBoxCarga1.TabIndex = 0;
            // 
            // txtBoxCarga2
            // 
            this.txtBoxCarga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCarga2.Location = new System.Drawing.Point(91, 283);
            this.txtBoxCarga2.Name = "txtBoxCarga2";
            this.txtBoxCarga2.Size = new System.Drawing.Size(119, 22);
            this.txtBoxCarga2.TabIndex = 1;
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.BackColor = System.Drawing.Color.Yellow;
            this.bttnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCalcular.Location = new System.Drawing.Point(41, 395);
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
            this.labelCarga1.Location = new System.Drawing.Point(12, 237);
            this.labelCarga1.Name = "labelCarga1";
            this.labelCarga1.Size = new System.Drawing.Size(62, 16);
            this.labelCarga1.TabIndex = 3;
            this.labelCarga1.Text = "Carga 1";
            // 
            // labelCarga2
            // 
            this.labelCarga2.AutoSize = true;
            this.labelCarga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarga2.Location = new System.Drawing.Point(12, 284);
            this.labelCarga2.Name = "labelCarga2";
            this.labelCarga2.Size = new System.Drawing.Size(62, 16);
            this.labelCarga2.TabIndex = 4;
            this.labelCarga2.Text = "Carga 2";
            // 
            // txtBoxDistancia
            // 
            this.txtBoxDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDistancia.Location = new System.Drawing.Point(91, 338);
            this.txtBoxDistancia.Name = "txtBoxDistancia";
            this.txtBoxDistancia.Size = new System.Drawing.Size(119, 22);
            this.txtBoxDistancia.TabIndex = 1;
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistancia.Location = new System.Drawing.Point(12, 339);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(73, 16);
            this.labelDistancia.TabIndex = 4;
            this.labelDistancia.Text = "Distancia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "[μC] ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "[μC]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "[mm]";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(262, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1000, 600);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Colocamos 1 carga puntual entre 2 cargas positivas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gráfica de";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Suma de Fuerzas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "[kN]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(705, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "[mm]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(735, 683);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelDistancia);
            this.Controls.Add(this.labelCarga2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCarga1);
            this.Controls.Add(this.bttnCalcular);
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
    }
}

