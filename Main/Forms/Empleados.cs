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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
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
            pnlContainerEmpleados.Controls.Add(formularioHijo);
            pnlContainerEmpleados.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Roles());
        }
    }
}
