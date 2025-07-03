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
    public partial class FrmCohenSutherland : Form
    {
        private CohenSutherland clipper;
        private List<(PointF p0, PointF p1)> lines; // Lista de líneas dibujadas
        private PointF? startPoint; // Punto inicial para la línea actual
        private bool showClipped; // Bandera para mostrar solo líneas recortadas
        public FrmCohenSutherland()
        {
            InitializeComponent();
            clipper = new CohenSutherland();
            lines = new List<(PointF p0, PointF p1)>();
            startPoint = null;
            showClipped = false;
            picCanvas.BackColor = Color.White; // Fondo blanco para visibilidad
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            // Activar modo de recorte
            showClipped = true;
            Console.WriteLine("Modo recorte activado");
            picCanvas.Invalidate();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Limpiar todo
            lines.Clear();
            startPoint = null;
            showClipped = false;
            txtX0.Text = "";
            txtY0.Text = "";
            txtX1.Text = "";
            txtY1.Text = "";
            Console.WriteLine("Formulario reseteado");
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // Ajustar coordenadas relativas al PictureBox dentro del groupBox3
            PointF clickPoint = new PointF(e.X, e.Y);
            Console.WriteLine($"Clic en: ({clickPoint.X}, {clickPoint.Y})");

            if (startPoint == null)
            {
                // Primer clic: punto inicial
                startPoint = clickPoint;
                txtX0.Text = clickPoint.X.ToString("F0");
                txtY0.Text = clickPoint.Y.ToString("F0");
            }
            else
            {
                // Segundo clic: punto final, agregar línea
                txtX1.Text = clickPoint.X.ToString("F0");
                txtY1.Text = clickPoint.Y.ToString("F0");
                lines.Add((startPoint.Value, clickPoint));
                Console.WriteLine($"Línea agregada: ({startPoint.Value.X}, {startPoint.Value.Y}) a ({clickPoint.X}, {clickPoint.Y})");
                startPoint = null; // Reiniciar para la próxima línea
                showClipped = false; // Mostrar líneas originales
                picCanvas.Invalidate();
            }
            picCanvas.Invalidate(); // Forzar redibujado
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Dibujar los 9 cuadrantes
                clipper.DrawQuadrants(g);

                if (showClipped)
                {
                    // Dibujar solo las líneas recortadas en rojo
                    using (Pen bluePen = new Pen(Color.Red, 2))
                    {
                        foreach (var line in lines)
                        {
                            if (clipper.ClipLine(line.p0, line.p1, out PointF newP0, out PointF newP1))
                            {
                                g.DrawLine(bluePen, newP0, newP1);
                                Console.WriteLine($"Línea recortada dibujada: ({newP0.X}, {newP0.Y}) a ({newP1.X}, {newP1.Y})");
                            }
                        }
                    }
                }
                else
                {
                    // Dibujar todas las líneas originales en rojo
                    using (Pen redPen = new Pen(Color.Purple, 2))
                    {
                        foreach (var line in lines)
                        {
                            g.DrawLine(redPen, line.p0, line.p1);
                            Console.WriteLine($"Línea original dibujada: ({line.p0.X}, {line.p0.Y}) a ({line.p1.X}, {line.p1.Y})");
                        }
                    }

                    // Dibujar el punto inicial como un círculo si existe
                    if (startPoint.HasValue)
                    {
                        using (SolidBrush brush = new SolidBrush(Color.Black))
                        {
                            g.FillEllipse(brush, startPoint.Value.X - 3, startPoint.Value.Y - 3, 6, 6);
                            Console.WriteLine($"Punto inicial dibujado en: ({startPoint.Value.X}, {startPoint.Value.Y})");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Paint: {ex.Message}");
            }
        }
    }
}
