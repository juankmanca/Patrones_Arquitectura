using Patrones.Patrones.Clases;
using System;
using System.Collections.Generic;

namespace Patrones.Patrones.Estructurales.Composite
{
    // Clase Componente
    public abstract class ComponenteAcademico
    {
        public string Nombre { get; set; }

        public ComponenteAcademico(string nombre)
        {
            Nombre = nombre;
        }

        public abstract void AgregarCurso(ComponenteAcademico curso);
        public abstract void EliminarCurso(ComponenteAcademico curso);
        public abstract string MostrarDetalles(int nivel);
    }

    // Clase Hoja
    public class Curso : ComponenteAcademico
    {
        public string Profesor { get; set; }
        public string IDPrograma { get; set; }

        public Curso(string nombre, string profesor, string iDPrograma) : base(nombre)
        {
            Profesor = profesor;
            IDPrograma = iDPrograma;
        }

        public override void AgregarCurso(ComponenteAcademico curso)
        {
            Console.WriteLine("No se pueden agregar cursos a un curso individual.");
        }

        public override void EliminarCurso(ComponenteAcademico curso)
        {
            Console.WriteLine("No se pueden eliminar cursos de un curso individual.");
        }

        public override string MostrarDetalles(int nivel)
        {
            return $"{new string('-', nivel)} Curso: {Nombre} - Profesor: {Profesor}";
        }

    }

    // Clase Nodo
    public class ProgramaAcademico : ComponenteAcademico
    {
        SQLServerConnection db = new SQLServerConnection("localhost", "Patrones", "sa", "123456789");
        private List<ComponenteAcademico> _cursos = new List<ComponenteAcademico>();

        public ProgramaAcademico(string nombre) : base(nombre)
        {
        }

        public override void AgregarCurso(ComponenteAcademico curso)
        {
            _cursos.Add(curso);
        }

        public override void EliminarCurso(ComponenteAcademico curso)
        {
            _cursos.Remove(curso);
        }

        public void AgregarCursoDB(Curso curso)
        {
            string query = $"INSERT INTO Cursos (Nombre, Profesor, IDProgramas) VALUES ('{curso.Nombre}', '{curso.Profesor}',{curso.IDPrograma}) ";
            db.InsertDataByQuery(query);
        }

        public override string MostrarDetalles(int nivel)
        {
            var detalles = $"{new string('-', nivel)} Programa Académico: {Nombre}";
            foreach (var curso in _cursos)
            {
                detalles += $"\n{curso.MostrarDetalles(nivel + 1)}";
            }
            return detalles;
        }

        public void AgregarProgramaDB()
        {
            string query = $"INSERT INTO Programas (Nombre) VALUES ('{Nombre}') ";
            db.InsertDataByQuery(query);
        }

    }
}
