using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEFI_GestionTramites.Models;

namespace IEFI_GestionTramites.Forms
{
    public partial class frmUrgencias : Form
    {

        private PilaUrgencias pila;
        private ListaFinalizados historial;

        public frmUrgencias(PilaUrgencias pila, ListaFinalizados historial)
        {
            InitializeComponent();
            this.pila = pila;
            this.historial = historial;

            ActualizarLista();
        }

        private void frmUrgencias_Load(object sender, EventArgs e)
        {
            CargarTiposDeTramite();
            dtpFecha.Value = DateTime.Now;

        }

        private void CargarTiposDeTramite()
        {
            cmbTipoTramite.Items.Clear();

            cmbTipoTramite.Items.Add("DNI");
            cmbTipoTramite.Items.Add("Pasaporte");
            cmbTipoTramite.Items.Add("Licencia de conducir");
            cmbTipoTramite.Items.Add("Certificado de domicilio");
            cmbTipoTramite.Items.Add("Cambio de domicilio");
            cmbTipoTramite.Items.Add("Otro");

            cmbTipoTramite.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Tramite tramite = new Tramite(
                txtDNI.Text.Trim(),
                txtNombre.Text.Trim(),
                cmbTipoTramite.SelectedItem.ToString(),
                dtpFecha.Value,
                txtMotivo.Text.Trim()
            );

            pila.Apilar(tramite);
            ActualizarLista();
            LimpiarCampos();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (pila.EstaVacia())
            {
                MessageBox.Show("No hay urgencias.");
                return;
            }

            Tramite atendido = pila.Desapilar();
            historial.AgregarOrdenado(atendido);
            lblLlamado.Text = $"{atendido.Nombre} ({atendido.DNI}) - {atendido.TipoTramite}";
            ActualizarLista();
        }


        private void ActualizarLista()
        {
            lsbUrgencias.Items.Clear();
            foreach (var tramite in pila.ObtenerTodos())
            {
                lsbUrgencias.Items.Add(tramite.ToString());
            }
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtMotivo.Clear();
            cmbTipoTramite.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
        }
    }
}
