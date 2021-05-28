using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CalificacionesApp
{
    class Alumno
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Curp { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string FechaDeIngreso { get; set; }
        public int PlanDeEstudioId { get; set; }
        public PlanDeEstudio PlanDeEstudio { get; set; }

        public static void imprimirBoleta( int Id)
        {
            using (var db = new SqliteDbContext())
            {
                var alumno = db.Alumnos
                .Where(al=> al.Id == Id)
                .Include(al => al.PlanDeEstudio)
                    .ThenInclude(planDeEstudio => planDeEstudio.Escuela)
                .Single();

                Helpers.PrintTitle("BOLETA");
                Console.WriteLine($"Escuela: {alumno.PlanDeEstudio.Escuela.Nombre}");
                Console.WriteLine($"Plan de Estudios: {alumno.PlanDeEstudio.Nombre} ({alumno.PlanDeEstudio.Año})");
                Console.WriteLine($"Alumno: {alumno.Nombre}\n");
                Helpers.printSubTitle("Calificaciones Finales");
                Helpers.printSubTitle("Asignaturas                        C1 F1    C2 F2    C3 F3");
            }

            using (var db = new SqliteDbContext())
            {
                var calificacion = db.Calificaciones
                .Where(cal => cal.DocenteId == cal.AlumnoId)
                .Include(cal => cal.Docente)
                .Include(cal => cal.Asignatura)
                .Single();
                db.Database.EnsureCreated();
                var asignaturas = db.Asignaturas;
                foreach (var asignatura in asignaturas)
                {
                    Console.WriteLine($"{asignatura.Nombre}              {calificacion.Parcial1}   {calificacion.Faltas1}     {calificacion.Parcial2}  {calificacion.Faltas2}    {calificacion.Parcial3}  {calificacion.Faltas3} ");

                }

                Console.WriteLine("");
                Helpers.printSubTitle("Calificaciones Finales");
                Helpers.printSubTitle("Asignaturas               Faltas    Prom   Ord   Final");
                foreach (var asignatura in asignaturas)
                {
                    Console.WriteLine($"{asignatura.Nombre}      {calificacion.Faltas}   {calificacion.Promedio}   {calificacion.Ordinario}   {calificacion.Final}");

                }

                Console.WriteLine("");
                Helpers.printSubTitle("Docentes");
                Helpers.printSubTitle("Asignatura                       Docentes");
                var docentes = db.Docentes;
                foreach (var docente in docentes)
                {
                    Console.WriteLine($"");
                }

           }
        }
    }
}