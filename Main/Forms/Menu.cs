using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHoraReal.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFechaReal.Text = DateTime.Now.ToLongDateString();
        }
        private Form formularioActivo = null;
        private void abrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(formularioHijo);
            pnlContainer.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Productos());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Empleados());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
