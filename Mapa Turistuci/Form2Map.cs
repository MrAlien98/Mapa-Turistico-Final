using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using System.IO;
using System.Collections;
using modelo;

namespace Mapa_Turistuci
{
    public partial class Form2Map : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        private ControlModelo contl;

        String nombre = "";
        double latInicial = 3.3417918;
        double lngInicial = -76.5328215;
        private int childFormNumber = 0;

        private String nombreLugar = "";

        public Form2Map(ControlModelo contl)
        {
            InitializeComponent();
            this.contl = contl;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Mapa_Load(object sender, EventArgs e)
        {

            //          AQUI NECESITO EL ARRAYLIST QUE TENES EN CONTROL MODELO CON LOS PUNTOS
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("NOMBRE", typeof(String)));
            dt.Columns.Add(new DataColumn("DESCRIPCIÓN", typeof(String)));
            dt.Columns.Add(new DataColumn("LATITUD", typeof(double)));
            dt.Columns.Add(new DataColumn("LONGITUD", typeof(double)));

            cargar(dt);
            dataGrid.DataSource = dt;
            dataGrid.Columns[1].Visible = false;
            dataGrid.Columns[2].Visible = false;
            dataGrid.Columns[3].Visible = false;

            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.Position = new PointLatLng(latInicial, lngInicial);
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 9;
            mapa.AutoScroll = true;

            //marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lngInicial), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            

            mapa.Overlays.Add(markerOverlay);
        }

        private void seleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;
            nombre = dataGrid.Rows[filaSeleccionada].Cells[0].Value.ToString();
            tbDescripcion.Text = dataGrid.Rows[filaSeleccionada].Cells[1].Value.ToString();
            tbLatitud.Text = ""+dataGrid.Rows[filaSeleccionada].Cells[2].Value;
            txLongitud.Text = ""+dataGrid.Rows[filaSeleccionada].Cells[3].Value;

            marker.Position = new PointLatLng(Convert.ToDouble(tbLatitud.Text), Convert.ToDouble(txLongitud.Text));
            mapa.Position = marker.Position;
        }

        private void cargar(DataTable data) 
        {
            ArrayList singles = contl.Puntos;
            for (int i = 0; i < singles.Count; i++)
            {
                    PuntoTuristico a = (PuntoTuristico)singles[i];
                    String nombre = a.Nombre;
                    String descripcion = "El punto turistico esta ubicado en la ciudad de "+a.Ciudad+", departamento del "+a.Depto;
                    //MessageBox.Show("" + a.Latitud + "\n" + a.Longitud);
                    data.Rows.Add(nombre, descripcion, a.Latitud, a.Longitud);
            }
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
