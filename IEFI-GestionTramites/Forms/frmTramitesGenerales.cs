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
    public partial class frmTramitesGenerales : Form
    {

        private ColaTramites cola = new ColaTramites();

        public frmTramitesGenerales()
        {
            InitializeComponent();
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

            cmbTipoTramite.SelectedIndex = 0; // Selecciona el primero por defecto
        }


        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (cola.EstaVacia())
            {
                MessageBox.Show("No hay trámites pendientes.");
                return;
            }


            Tramite atendido = cola.Desencolar();
            DatosCompartidos.Historial.AgregarOrdenado(atendido);
            lblLlamado.Text = $"{atendido.Nombre} ({atendido.DNI}) - {atendido.TipoTramite}";
            ActualizarLista();
        }



        private void ActualizarLista()
        {
            lsbTramites.Items.Clear();
            foreach (var tramite in cola.ObtenerTodos())
            {
                lsbTramites.Items.Add(tramite.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || cmbTipoTramite.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Tramite nuevo = new Tramite(
                txtDNI.Text.Trim(),
                txtNombre.Text.Trim(),
                cmbTipoTramite.SelectedItem.ToString(),
                dtpFecha.Value
            );

            cola.Encolar(nuevo);
            ActualizarLista();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            cmbTipoTramite.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        private void frmTramitesGenerales_Load(object sender, EventArgs e)
        {
            CargarTiposDeTramite();
            dtpFecha.Value = DateTime.Now;
        }

        private void lblLlamado_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
