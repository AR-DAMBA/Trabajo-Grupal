using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            abriPanle(new Historial());
        }


        private void abriPanle(object formulario)
        {
            Form fnd = formulario as Form;
            if (fnd != null)
            {
                fnd.TopLevel = false;
                fnd.Dock = DockStyle.Fill;
                fnd.FormBorderStyle = FormBorderStyle.None; 
                paneluso.Controls.Add(fnd);
                paneluso.Tag = fnd;
                fnd.BringToFront();
                fnd.Show();
            }
        }


        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            abriPanle(new Gestion());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            abriPanle(new Crear_Producto());
        }
    }
}
