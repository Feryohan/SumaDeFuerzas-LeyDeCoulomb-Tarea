using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para el chart
using System.Windows.Forms.DataVisualization.Charting;

namespace Suma_de_Fuerzas___Ley_de_Coulomb__Tarea_
{
    public partial class Form1 : Form
    {
        #region Atributos
        //Variables globales del programa
        double carga1;
        double carga2;
        double radio;
        #endregion

        #region Métodos
        public Form1()
        {
            InitializeComponent();
        }

        #region Calculos
        //Método que calcula las fuerzas para antes del punto de equilibrio
        public void Calculos1(double fuerza1, double fuerza2, double distanciaGrap)
        {
            double sumaFuerzas = (fuerza1 - fuerza2) / 1e3;
            //Punto en la gráfica
            chart1.Series["Suma de Fuerzas"].Points.AddXY(distanciaGrap, sumaFuerzas);
            //Información mostrada en la pantalla
            txtBoxDQ1.Text = Convert.ToString(Math.Round(distanciaGrap,2));
            txtBoxSumFue.Text = Convert.ToString(Math.Round(sumaFuerzas,4));
        }

        //Método que calcula las fuerzas para después del punto de equilibrio
        public void Calculos2(double fuerza1, double fuerza2, double distanciaGrap)
        {
            double sumaFuerzas = (fuerza2 - fuerza1) / 1e3;
            chart1.Series["Suma de Fuerzas"].Points.AddXY(distanciaGrap, sumaFuerzas);
            txtBoxDQ1.Text = Convert.ToString(Math.Round(distanciaGrap, 2));
            txtBoxSumFue.Text = Convert.ToString(Math.Round(sumaFuerzas, 4));

            //Se muestra la distancia para el punto de equilibrio
            //La presición está dada por 2 decimales 0.00
           if (Math.Round(sumaFuerzas,2) == 0)
            {
                double equilibrioDistancia = Math.Round(distanciaGrap,2);
                double equilibrioFuerza = Math.Round(sumaFuerzas, 4);
                double error = (Math.Abs((pntEqui*1000) - distanciaGrap) / (pntEqui*1000)) * 100;

                //Los elementos invisibles se hacen visibles
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label21.Visible = true;
                txtBoxEqui.Visible = true;
                txtBoxFuerzas.Visible = true;
                txtBoxError.Visible = true;

                //Envío de información al formulario
                txtBoxEqui.Text = Convert.ToString(equilibrioDistancia);
                txtBoxFuerzas.Text = Convert.ToString(equilibrioFuerza);
                label17.Text = ("Distancia de equilibrio (Teórico) = "+pntEqui*1000+" [mm]");
                txtBoxError.Text = Convert.ToString(Math.Round(error,4));

           }
        }
        #endregion

        #region Botón
        //Método cuando se presiona el botón "Calcular", 
        //Para el usuario el botón dice "Graficar"
        public void BttnCalcular_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            carga1 = (double.Parse(txtBoxCarga1.Text))*1e-6; //coulombs
            carga2 = (double.Parse(txtBoxCarga2.Text))*1e-6; //coulombs
            radio = (double.Parse(txtBoxDistancia.Text))*1e-3; //metros 

            //Construcción de la gráfica
                //El área de los rectángulos es cero
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
                //Se pone nulo para que el numeros aparézcan en los ejes
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //Medidas del gráfico
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 60;
            chart.AxisX.Interval = 3;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 10;
            chart.AxisY.Interval = 1;

            //Diseño de la gráfica
            chart1.Series.Add("Suma de Fuerzas");
            chart1.Series["Suma de Fuerzas"].ChartType = SeriesChartType.Line;
            chart1.Series["Suma de Fuerzas"].Color = Color.Red;
            chart1.Series["Suma de Fuerzas"].IsVisibleInLegend = false;

            //Inicio del Timer
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
        #endregion

        //Método cuando la pantalla se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;
        }

        #region Timer
        //Constantes
        //No pueden haber constantes dentro del timer
        //No sé por qué
        double k = 9e9;
        double carga3 = 1e-6;
        double pntEqui = 0.06 - 0.0317;
        double incrementoR = 0.0001;

        //Método cuando el Timer está habilitado
        public void Timer1_Tick(object sender, EventArgs e)
        {
            //Variables
            double fuerza1;
            double fuerza2;
            double distanciaGrap;

            fuerza1 = (k * carga1 * carga3) / (Math.Pow((incrementoR), 2));
            fuerza2 = (k * carga2 * carga3) / (Math.Pow(radio - incrementoR, 2));
            distanciaGrap = incrementoR * 1e3;
            //Región menor al punto de equilibrio
            if (incrementoR < pntEqui)
                {
                    //Las variables fuerza1, fuerza2, distanciaGrap se envían al
                    //Método Calculos1
                    Calculos1(fuerza1, fuerza2, distanciaGrap);
                }
            //Región mayor al punto de equilibrio
            else
                {
                    Calculos2(fuerza1, fuerza2, distanciaGrap);
                }
            incrementoR = incrementoR + 0.0001;

            //Cuando la carga de prueba a alcanzado a la carga 2
            //El timer se detiene
            if (incrementoR > radio)
            {
                timer1.Stop();
            }

        }
        #endregion

        #endregion
    }
}
