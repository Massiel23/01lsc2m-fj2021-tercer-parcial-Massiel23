using System;

namespace CalificacionesApp
{
    class Calificacion
    {
        public int Id {get; set;}
        public string Fecha {get; set;}
        public int Docenteid {get; set;}
        public int Alumnoid {get; set;}
        public int  Asignaturaid {get; set;}
        public int Parcial1 {get; set;}
        public int Parcial2 {get; set;}
        public int Parcial3 {get; set;}
        public int Faltas1 {get; set;}
        public int Faltas2 {get; set;}
        public int Faltas3 {get; set;}
        public int Promedio {get; set;}
        public int TotalFaltas {get; set;}
        public int Ordinario {get; set;}
        public int Final { get; set; }
        

    }
}