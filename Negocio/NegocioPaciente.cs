using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPaciente : INegocioPaciente
    {
        IRepositorioPaciente repositorioPaciente;
        public NegocioPaciente(IRepositorioPaciente repositorioPaciente)
        { this.repositorioPaciente = repositorioPaciente; }
        public void GuardarPaciente(Paciente paciente)
        {
            repositorioPaciente.GuardarPaciente(paciente);

        }
    }
}
