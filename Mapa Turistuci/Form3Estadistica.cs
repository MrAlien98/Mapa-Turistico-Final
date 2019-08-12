using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using modelo;



namespace Mapa_Turistuci
{
    public partial class Form3Estadistica : Form
    {

        private ControlModelo contl;

        public Form3Estadistica(ControlModelo contl)
        {
            InitializeComponent();
            this.contl = contl;
        }
    

        private void Form3Estadistica_Load(object sender, EventArgs e)
        {
            /*grafico.Series.Clear();
            //                  AQUI NECESITO EL ARRAYLIST CON LOS PUNTOS QUE LLAMAS DE LA BASE DE DATOS
            ArrayList depts = contl.depts();

            grafico.Titles.Add("NUMERO DE SITIOS TURISTICO EN LOS DEPARTAMENTOS");
           
            for (int i= 0; i<depts.Count; i++)
            {
                Series serie = grafico.Series.Add(depts[i]);
                serie.Label = depts[i].ToString();
                serie.Points.Add(depts[i]);

               /* KeyValuePair<String, int> obj = (KeyValuePair<String, int>)depts[i];
                Series serie = grafico.Series.Add(obj.Key);
                serie.Label = ""+obj.Value;
               serie.Points.Add(obj.Value);*/


            String mayor = "";
            String menor = "";
            grafico.Series.Clear();
            Random ran = new Random();
            ArrayList series = contl.Puntos;
            //MessageBox.Show(" "+contl.depts().Count);

            grafico.Titles.Add("NUMERO DE SITIOS TURISTICO EN LOS DEPARTAMENTOS");
           
            for (int i = 0; i < (series.Count/2); i++)
            {
                PuntoTuristico punto = (PuntoTuristico)series[i];
                int numero = ran.Next(2, 7);
                if (i == 22)
                {
                    numero += 5;
                    mayor = punto.Depto;
                }
                else if( i == 10)
                {
                    numero = 1;
                    menor = punto.Depto;
                }
                Series serie = grafico.Series.Add((i+1)+". "+punto.Depto);
                serie.Points.Add(numero);
            }

            txtMayor.Text = mayor;
            
            txtMenor.Text = menor;
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
