namespace CalificacionesApp
{
    class Calificacion
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public int DocenteId { get; set; }
        public Docente Docente { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public int AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Parcial1 { get; set; }
        public float Parcial2 { get; set; }
        public float Parcial3 { get; set; }
        public int Faltas1 { get; set; }
        public int Faltas2 { get; set; }
        public int Faltas3 { get; set; }
        public float Promedio { get; set; }
        public int Faltas { get; set; }
        public float Ordinario { get; set; }
        public float Final { get; set; }
    }
}