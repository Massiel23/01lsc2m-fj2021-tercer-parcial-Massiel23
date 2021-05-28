namespace CalificacionesApp
{
    class Asignatura
    {
        public int Id { get; set; }
        public int PlanDeEstudioId { get; set; }
        public PlanDeEstudio PlanDeEstudio { get; set; }
        public string Nombre { get; set; }
        public float Horas { get; set; }
        public int Semestre { get; set; }
        public int Creditos { get; set; }

    }
}