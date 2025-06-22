using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEFI_GestionTramites.Models;

namespace IEFI_GestionTramites.Forms
{
    public partial class frmHistorial : Form
    {

        private ListaFinalizados historial;
        public frmHistorial(ListaFinalizados listaHistorial)
        {
            InitializeComponent();
            historial = listaHistorial;
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            cmbTipoTramite.Items.Add("Todos");
            cmbTipoTramite.Items.Add("DNI");
            cmbTipoTramite.Items.Add("Pasaporte");
            cmbTipoTramite.Items.Add("Licencia de conducir");
            cmbTipoTramite.Items.Add("Urgencia médica");
            cmbTipoTramite.Items.Add("Otro");
            cmbTipoTramite.SelectedIndex = 0;

            dtpDesde.Value = DateTime.Today.AddDays(-7);
            dtpHasta.Value = DateTime.Today;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipoTramite.SelectedItem.ToString();
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1); // incluir hasta última hora del día

            var resultados = historial.Filtrar(tipo, desde, hasta);

            lsbHistorial.Items.Clear();
            foreach (var tramite in resultados)
            {
                lsbHistorial.Items.Add(tramite.ToString());
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = $"tramites_finalizados_{DateTime.Now:yyyyMMdd}.txt";
            using (StreamWriter writer = new StreamWriter(nombreArchivo))
            {
                foreach (var item in lsbHistorial.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("Historial exportado correctamente.");
        }
    }
}
