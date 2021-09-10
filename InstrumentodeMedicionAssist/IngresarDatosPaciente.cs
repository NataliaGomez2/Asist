using Entidades;
using Negocio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumentodeMedicionAssist
{
    public partial class IngresarDatosPaciente : Form
    {
        IRepositorioPaciente repositorio = new RepositorioPaciente();
        public IngresarDatosPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InicioEvaluacion form = new InicioEvaluacion();
            form.Show();
            this.Hide();

            var paciente = new Paciente()
            {
                NombreCompleto = txtNombreCompleto.Text
                TipoIdentificacion = cmbTipoID.Enabled
                NumeroIdentificacion = txtNumeroID.Text
                Genero = cmbGenero.Text

             };

            NegocioPaciente negocioPaciente = new NegocioPaciente(repositorioPaciente);
            negocioPaciente.Ingresar
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    
    }

}
