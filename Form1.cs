using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Suma_de_Fuerzas___Ley_de_Coulomb__Tarea_
{
    public partial class Form1 : Form
    {
        #region Atributos
        double carga1;
        double carga2;
        double radio;


        #endregion

        #region Métodos
        public Form1()
        {
            InitializeComponent();
           
        }

        public void Calculos1(double fuerza1, double fuerza2, double distanciaGrap)
        {
            double sumaFuerzas = (fuerza1 - fuerza2) / 1e3;
            chart1.Series["Suma de Fuerzas"].Points.AddXY(distanciaGrap, sumaFuerzas);
        }

        public void Calculos2(double fuerza1, double fuerza2, double distanciaGrap)
        {
            double sumaFuerzas = (fuerza2 - fuerza1) / 1e3;
            chart1.Series["Suma de Fuerzas"].Points.AddXY(distanciaGrap, sumaFuerzas);
        }

        public void BttnCalcular_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            carga1 = (double.Parse(txtBoxCarga1.Text))*1e-6; //coulombs
            carga2 = (double.Parse(txtBoxCarga2.Text))*1e-6; //coulombs
            radio = (double.Parse(txtBoxDistancia.Text))*1e-3; //metros 

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //Medidas del gráfico
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 60;
            chart.AxisX.Interval = 3;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 50;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("Suma de Fuerzas");
            chart1.Series["Suma de Fuerzas"].ChartType = SeriesChartType.Line;
            chart1.Series["Suma de Fuerzas"].Color = Color.Red;
            chart1.Series["Suma de Fuerzas"].IsVisibleInLegend = false;

            //Constantes
            double k = 9e9;
            double carga3 = 1e-6;
            double pntEqui = 0.06 - 0.0317;
            double incrementoR = 0.001;

            //Variables
            double fuerza1;
            double fuerza2;
            double distanciaGrap;

            while (incrementoR < radio)
            {
                fuerza1 = (k * carga1 * carga3) / (Math.Pow((incrementoR), 2));
                fuerza2 = (k * carga2 * carga3) / (Math.Pow(radio - incrementoR, 2));
                distanciaGrap = incrementoR * 1e3;
                //Región menor al punto de equilibrio
                if (incrementoR < pntEqui)
                {
                    Calculos1(fuerza1, fuerza2, distanciaGrap);
                }
                //Región mayor al punto de equilibrio
                else
                {
                    Calculos2(fuerza1, fuerza2, distanciaGrap);
                }
                incrementoR = incrementoR + 0.001;
            }
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
