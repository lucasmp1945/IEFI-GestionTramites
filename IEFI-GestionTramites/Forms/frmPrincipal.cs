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
using IEFI_GestionTramites.Repositories;

namespace IEFI_GestionTramites
{
    public partial class frmPrincipal : Form
    {

        private ColaTramites cola;
        private PilaUrgencias pila;
        private ListaFinalizados historial;
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cola = JornadaRepository.CargarCola();
            pila = JornadaRepository.CargarPila();
            historial = JornadaRepository.CargarHistorial();

            CargarTramitesGenerales();
            CargarUrgencias();
            CargarHistorial();
        }

        private void CargarTramitesGenerales()
        {
            frmTramitesGenerales frm = new frmTramitesGenerales(cola, historial);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            tabPage1.Controls.Clear();
            tabPage1.Controls.Add(frm);
            frm.Show();
        }


        private void CargarUrgencias()
        {
            frmUrgencias frm = new frmUrgencias(pila, historial);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            tabPage2.Controls.Clear();
            tabPage2.Controls.Add(frm);
            frm.Show();
        }



        private void CargarHistorial()
        {
            frmHistorial frm = new frmHistorial(historial);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            tabPage3.Controls.Clear();
            tabPage3.Controls.Add(frm);
            frm.Show();
        }


        private void btnAbrirJornada_Click(object sender, EventArgs e)
        {
            cola = JornadaRepository.CargarCola();
            pila = JornadaRepository.CargarPila();
            historial = JornadaRepository.CargarHistorial();

            CargarTramitesGenerales();
            CargarUrgencias();
            CargarHistorial();

            MessageBox.Show("Jornada cargada correctamente.");
        }

        private void btnCerrarJornada_Click(object sender, EventArgs e)
        {

            frmTramitesGenerales frm = new frmTramitesGenerales(cola, historial);

            JornadaRepository.GuardarCola(cola);
            JornadaRepository.GuardarPila(pila);
            JornadaRepository.GuardarHistorial(historial);

            MessageBox.Show("Jornada guardada correctamente.");
        }
    }
}
