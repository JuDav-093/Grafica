using GraphicsAlgorithmVisualizer.Algorithms.Clipping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmVisualizer.Forms
{
    public partial class FrmSutherlandH : Form
    {
        private CCorte visualizer; // Renombrado para claridad, usado para dibujar la ventana
        private SutherlandHodgman polyClipper; // El nuevo clipper de polígonos

        // lista de vértices para el polígono
        private List<PointF> polygonVertices;
        private List<PointF> clippedPolygon;
        private RectangleF clipWindow;

        private bool showClipped;
        public FrmSutherlandH()
        {
            InitializeComponent();
            visualizer = new CCorte();
            polyClipper = new SutherlandHodgman();            
            polygonVertices = new List<PointF>();
            clippedPolygon = null;
            showClipped = false;

            // Definir la ventana de recorte aquí para usarla en todo el formulario
           
            int XMin = 83, XMax = 166, YMin = 83, YMax = 166;
            clipWindow = new RectangleF(XMin, YMin, XMax - XMin, YMax - YMin);

            picCanvas.BackColor = Color.White;
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // Solo se permite dibujar si no estamos en modo recortado
            if (showClipped)
            {
                MessageBox.Show("Presiona 'Resetear' para dibujar un nuevo polígono.");
                return;
            }

            PointF clickPoint = new PointF(e.X, e.Y);
            polygonVertices.Add(clickPoint);
            Console.WriteLine($"Vértice agregado: ({clickPoint.X}, {clickPoint.Y})");

            txtX0.Text = clickPoint.X.ToString("F0");
            txtY0.Text = clickPoint.Y.ToString("F0");


            picCanvas.Invalidate(); // Forzar redibujado para mostrar el nuevo vértice/línea

        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Dibujar la ventana de recorte y los cuadrantes (usando la clase original)
                visualizer.DrawQuadrants(g);

                // Dibujar el polígono original (rojo)
                if (polygonVertices.Count > 1)
                {
                    using (Pen redPen = new Pen(Color.Red, 2))
                    {
                        // DrawLines dibuja las aristas entre los vértices
                        g.DrawLines(redPen, polygonVertices.ToArray());
                    }
                }
                // Dibujar los vértices para que el usuario vea dónde ha hecho clic
                using (SolidBrush vertexBrush = new SolidBrush(Color.DarkRed))
                {
                    foreach (var vertex in polygonVertices)
                    {
                        g.FillEllipse(vertexBrush, vertex.X - 3, vertex.Y - 3, 6, 6);
                    }
                }

                // Si estamos en modo recorte, dibujar el polígono recortado (azul)
                if (showClipped && clippedPolygon != null && clippedPolygon.Count > 0)
                {
                    using (Pen bluePen = new Pen(Color.Blue, 2))
                    using (Brush blueBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 255))) // Relleno semitransparente
                    {
                        g.FillPolygon(blueBrush, clippedPolygon.ToArray());
                        g.DrawPolygon(bluePen, clippedPolygon.ToArray());
                        Console.WriteLine($"Polígono recortado dibujado con {clippedPolygon.Count} vértices.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Paint: {ex.Message}");
            }
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            //Llama al nuevo algoritmo de recorte de polígonos
            if (polygonVertices.Count < 3)
            {
                MessageBox.Show("Se necesitan al menos 3 vértices para formar un polígono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clippedPolygon = polyClipper.ClipPolygon(polygonVertices, clipWindow);
            showClipped = true;
            Console.WriteLine("Modo recorte activado. Polígono recortado calculado.");
            picCanvas.Invalidate();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            //Limpia las listas de polígonos
            polygonVertices.Clear();
            clippedPolygon = null;
            showClipped = false;

            txtX0.Text = "";
            txtY0.Text = "";

            Console.WriteLine("Formulario reseteado");
            picCanvas.Invalidate();
        }
    }
}
