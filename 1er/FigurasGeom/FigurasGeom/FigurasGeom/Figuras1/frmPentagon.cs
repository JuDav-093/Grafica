﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    public partial class frmPentagon : Form
    {
        //definición de un objeto tipo CPentagono
        private CPentagon ObjPentagon = new CPentagon();
        public frmPentagon()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.btnCalculate.PreviewKeyDown += Control_PreviewKeyDown;
            this.btnReset.PreviewKeyDown += Control_PreviewKeyDown;
            this.btnExit.PreviewKeyDown += Control_PreviewKeyDown;

        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }


        private void frmPentagon_Load(object sender, EventArgs e)
        {
            //inicialización de los datos y controles
            //llamada a la función InitializeData
            ObjPentagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjPentagon.ReadData(txtLado);
            //cálculo perimetro -  llamada a la funcion PerimetrePentagon
            ObjPentagon.PerimeterPentagon();
            //Cálculo area - llamada a la func AreaPentagon
            ObjPentagon.AreaPentagon();
            //impresión de datos - llamada a func PintData
            ObjPentagon.PrintData(txtPerimeter, txtArea);
            //Graficación del pentágono - llamada fun PlotShape
            ObjPentagon.PlotShape(picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //inicialización de datos y controles - llamada a fun InitializeData
            ObjPentagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //funcion para que el pentagono gire al lado izquierdo
       
        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int valor = trackBar1.Value;
            txtLado.Text = valor.ToString();
            ObjPentagon.ReadData(valor);
            ObjPentagon.PerimeterPentagon();
            ObjPentagon.AreaPentagon();
            ObjPentagon.PrintData(txtPerimeter, txtArea);
            ObjPentagon.PlotShape(picCanvas);
            this.ActiveControl = null;

        }

        private void trackBar1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void trackBar1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true; 
        }

        private void frmPentagon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    ObjPentagon.Mover("arriba");
                    break;
                case Keys.Down:
                    ObjPentagon.Mover("abajo");
                    break;
                case Keys.Left:
                    ObjPentagon.Mover("izquierda");
                    break;
                case Keys.Right:
                    ObjPentagon.Mover("derecha");
                    break;
                case Keys.R:
                    ObjPentagon.Rotar("horario");
                    break;
                case Keys.L:
                    ObjPentagon.Rotar("antihorario");
                    break;
            }

            ObjPentagon.PlotShape(picCanvas);
        }
    }
}
