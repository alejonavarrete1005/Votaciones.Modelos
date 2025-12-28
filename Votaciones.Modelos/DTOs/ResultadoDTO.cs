using System;
using System.Collections.Generic;
using System.Text;

namespace Votaciones.Modelos.DTOs
{
    public class ResultadoDto
    {
        public string Candidato { get; set; }
        public int TotalVotos { get; set; }
        public double Porcentaje { get; set; }
    }

}
