using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEFI_GestionTramites.Forms;
using IEFI_GestionTramites.Models;

namespace IEFI_GestionTramites
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarTramitesGenerales();
            CargarUrgencias();
            CargarHistorial();
        }

        private void CargarTramitesGenerales()
        {
            frmTramitesGenerales frm = new frmTramitesGenerales();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            tabPage1.Controls.Clear();
            tabPage1.Controls.Add(frm);
            frm.Show();
        }

        private void CargarUrgencias()
        {
            frmUrgencias frm = new frmUrgencias();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            tabPage2.Controls.Clear();
            tabPage2.Controls.Add(frm);
            frm.Show();
        }


        private void CargarHistorial()
        {
            frmHistorial frm = new frmHistorial(DatosCompartidos.Historial);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            tabPage3.Controls.Clear();
            tabPage3.Controls.Add(frm);
            frm.Show();
        }

    }
}
