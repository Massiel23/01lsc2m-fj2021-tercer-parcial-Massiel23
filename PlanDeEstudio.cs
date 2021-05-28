using System.Collections.Generic;

namespace CalificacionesApp
{
    class PlanDeEstudio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
        public int Creditos { get; set; }
        public int EscuelaId { get; set; }
        public Escuela Escuela { get; set; }

    }
}