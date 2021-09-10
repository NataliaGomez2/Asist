using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    { 
        public string NombreCompleto { get; set; }
        public Boolean TipoIdentificacion { get; set; }
        public int NumeroIdentificacion { get; set; }
        public Boolean Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public Boolean EstadoCivil { get; set; }
        public string DireccionResidenca { get; set; }
        public string CiudadResidencia { get; set; }
        public int TelefonoContacto { get; set; }
        public string Ocupacion { get; set; }

        public Boolean NivelEscolatidad { get; set; }
        public string Eps { get; set; }
        public Boolean Regimen { get; set; }
        public string Email { get; set; }
        public int ContactoCasoEmergencia { get; set; }

    }
}
