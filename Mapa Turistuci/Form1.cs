using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using modelo;
using System.Collections;
using System.Globalization;

namespace Mapa_Turistuci
{
    public partial class Form1 : Form
    {
        private ControlModelo contl;

        public Form1()
        {
            InitializeComponent();
            contl = new ControlModelo();
            cargarBD();
        }

        private void cargarBD()
        {
            try
            {
                StreamReader sr = new StreamReader("BD.csv");
                String line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    String[] data = Regex.Split(line, ", ");

                    double latitud = double.Parse(data[3], CultureInfo.InvariantCulture);
                    double longitud = double.Parse(data[4], CultureInfo.InvariantCulture);

                    contl.Puntos.Add(new PuntoTuristico(data[0], data[1], data[2], latitud, longitud));
                }
                sr.Close();

                /*ArrayList wea = contl.depts();

                for (int i=0;i<wea.Count;i++)
                {
                    MessageBox.Show("" + (String) wea[i]);
                }*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.GetType() + "__--__" + e.Message);
            }
        }

        private void BtMapa_Click(object sender, EventArgs e)
        {
            Form2Map f2 = new Form2Map(contl);
            f2.Show();
            this.Hide();
        }

       public ControlModelo modelo()
        {
            return contl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtEstadistica_Click(object sender, EventArgs e)
        {
            Form3Estadistica f3 = new Form3Estadistica(contl);
            f3.Show();
            this.Hide();
        }
    }
}
