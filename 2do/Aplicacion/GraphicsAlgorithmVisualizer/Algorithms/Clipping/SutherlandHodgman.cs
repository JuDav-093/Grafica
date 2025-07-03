using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgorithmVisualizer.Algorithms.Clipping
{
    internal class SutherlandHodgman
    {
        // Enum para identificar claramente contra qué borde estamos recortando.
        private enum Edge { Left, Right, Top, Bottom };

        /// Recorta un polígono (subjectPolygon) contra una ventana de recorte convexa (clipWindow).
        
        public List<PointF> ClipPolygon(List<PointF> subjectPolygon, RectangleF clipWindow)
        {
            // Empezamos con la lista de vértices del polígono original.
            List<PointF> outputList = new List<PointF>(subjectPolygon);

            // Recortamos secuencialmente contra cada borde de la ventana.
            // La salida de un recorte se convierte en la entrada del siguiente.
            outputList = ClipAgainstEdge(outputList, Edge.Left, clipWindow);
            outputList = ClipAgainstEdge(outputList, Edge.Top, clipWindow);
            outputList = ClipAgainstEdge(outputList, Edge.Right, clipWindow);
            outputList = ClipAgainstEdge(outputList, Edge.Bottom, clipWindow);

            return outputList;
        }

       
        /// Recorta una lista de vértices contra un único borde de la ventana de recorte.
       
        private List<PointF> ClipAgainstEdge(List<PointF> inputVertices, Edge edge, RectangleF clipWindow)
        {
            List<PointF> outputVertices = new List<PointF>();
            if (inputVertices.Count == 0) return outputVertices;

            PointF S = inputVertices[inputVertices.Count - 1]; // El último punto para empezar el ciclo

            foreach (PointF P in inputVertices)
            {
                bool sInside = IsInside(S, edge, clipWindow);
                bool pInside = IsInside(P, edge, clipWindow);

                // Caso 1: Ambos vértices están dentro. Guardar solo el segundo (P).
                if (sInside && pInside)
                {
                    outputVertices.Add(P);
                }
                // Caso 2: El vértice inicial está dentro y el final fuera. Guardar solo la intersección.
                else if (sInside && !pInside)
                {
                    outputVertices.Add(GetIntersection(S, P, edge, clipWindow));
                }
                // Caso 3: Ambos vértices están fuera. No guardar nada.
                else if (!sInside && !pInside)
                {
                    // No hacer nada
                }
                // Caso 4: El vértice inicial está fuera y el final dentro. Guardar la intersección y luego el punto final (P).
                else if (!sInside && pInside)
                {
                    outputVertices.Add(GetIntersection(S, P, edge, clipWindow));
                    outputVertices.Add(P);
                }

                S = P; // Mover al siguiente vértice
            }

            return outputVertices;
        }

       
        /// Comprueba si un punto está en el lado "interior" de un borde de recorte.
       
        private bool IsInside(PointF p, Edge edge, RectangleF clipWindow)
        {
            switch (edge)
            {
                case Edge.Left: return p.X >= clipWindow.Left;
                case Edge.Right: return p.X <= clipWindow.Right;
                case Edge.Top: return p.Y >= clipWindow.Top;
                case Edge.Bottom: return p.Y <= clipWindow.Bottom;
            }
            return false;
        }

       
        /// Calcula el punto de intersección de la arista S-P con un borde de la ventana.
     
        private PointF GetIntersection(PointF S, PointF P, Edge edge, RectangleF clipWindow)
        {
            float m; // Pendiente de la línea

            if (P.X - S.X != 0)
                m = (P.Y - S.Y) / (P.X - S.X);
            else
                m = float.PositiveInfinity; // Línea vertical

            switch (edge)
            {
                case Edge.Left:
                    float yl = S.Y + m * (clipWindow.Left - S.X);
                    return new PointF(clipWindow.Left, yl);
                case Edge.Right:
                    float yr = S.Y + m * (clipWindow.Right - S.X);
                    return new PointF(clipWindow.Right, yr);
                case Edge.Top:
                    float xt = (m != float.PositiveInfinity) ? S.X + (clipWindow.Top - S.Y) / m : S.X;
                    return new PointF(xt, clipWindow.Top);
                case Edge.Bottom:
                    float xb = (m != float.PositiveInfinity) ? S.X + (clipWindow.Bottom - S.Y) / m : S.X;
                    return new PointF(xb, clipWindow.Bottom);
                default:
                    return PointF.Empty;
            }
        }
    }
}
