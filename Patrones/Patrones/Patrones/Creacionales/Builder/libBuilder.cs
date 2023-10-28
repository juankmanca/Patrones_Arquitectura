using System;
using System.Collections.Generic;

namespace Patrones.Patrones.Creacionales.Builder
{
    public class HojaVida
    {
        public IList<DatosPersonales> datosPersonales;
        public IList<Educacion> FormacionAcademica;
        public IList<Trabajo> ExperienciaLaboral;
        public IList<Referencias> ReferenciasLaborales;
        public IList<Skills> Habilidades;
    }
    public class DatosPersonales
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
    }
    public class Educacion
    {
        public string NombrePrograma { get; set; }
        public string NombreInstitucion { get; set; }
        public string Tipo { get; set; } //Tipo pueder: Bachillerato, profesional, tecnólogo, etc
        public DateTime FechaGrado { get; set; }
        public string Titulo { get; set; }
    }
    public class Trabajo
    {
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Funciones { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
    public class Referencias
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
    }
    public class Skills
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
    public class HojaVidaBuilder
    {
        private readonly HojaVida hojaVida = new HojaVida();
        public HojaVidaBuilder()
        {
            hojaVida.datosPersonales = new List<DatosPersonales>();
            hojaVida.FormacionAcademica = new List<Educacion>();
            hojaVida.ExperienciaLaboral = new List<Trabajo>();
            hojaVida.ReferenciasLaborales = new List<Referencias>();
            hojaVida.Habilidades = new List<Skills>();
        }
        public DatosPersonalesBuilder AgregarDatosPersonales()
        {
            return new DatosPersonalesBuilder(this, hojaVida);
        }
        public ColegioBuilder AgregarColegio()
        {
            return new ColegioBuilder(this, hojaVida);
        }
    }

    public class DatosPersonalesBuilder
    {
        private readonly DatosPersonales datosPersonales = new DatosPersonales();
        private readonly HojaVidaBuilder hojaVidaBuilder;
        private readonly HojaVida hojaVida;
        public DatosPersonalesBuilder(HojaVidaBuilder hvBuilder, HojaVida hv)
        {
            hojaVidaBuilder = hvBuilder;
            hojaVida = hv;
        }
        public DatosPersonalesBuilder AgregarDocumento(string documento)
        {
            datosPersonales.Documento = documento;
            return this;
        }
        public DatosPersonalesBuilder AgregarNombre(string Nombre)
        {
            datosPersonales.Nombre = Nombre;
            return this;
        }
        public ColegioBuilder AgregarColegio()
        {
            hojaVida.datosPersonales.Add(datosPersonales);
            return new ColegioBuilder(hojaVidaBuilder, hojaVida);
        }
    }
    public class ColegioBuilder
    {
        private readonly Educacion educacion = new Educacion();
        private readonly HojaVidaBuilder hojaVidaBuilder;
        private readonly HojaVida hojaVida;
        public ColegioBuilder(HojaVidaBuilder hvBuilder, HojaVida hv)
        {
            hojaVidaBuilder = hvBuilder;
            hojaVida = hv;
            educacion.Titulo = "Colegio";
        }
        public ColegioBuilder AgregarNombre(string Nombre)
        {
            educacion.NombrePrograma = Nombre;
            return this;
        }
        public ColegioBuilder AgregarInstitucion(string institucion)
        {
            educacion.NombreInstitucion = institucion;
            return this;
        }
        public ColegioBuilder AgregarFechaGrado(DateTime fechaGrado)
        {
            educacion.FechaGrado = fechaGrado;
            return this;
        }
        public ColegioBuilder AgregarTitulo(string Titulo)
        {
            educacion.Titulo = Titulo;
            return this;
        }
        public EducacionUniversitariaBuilder AgregarEducacionUniversitaria()
        {
            hojaVida.FormacionAcademica.Add(educacion);
            return new EducacionUniversitariaBuilder(hojaVidaBuilder, hojaVida);
        }
    }
    public class EducacionUniversitariaBuilder
    {
        private readonly Educacion educacion = new Educacion();
        private readonly HojaVidaBuilder hojaVidaBuilder;
        private readonly HojaVida hojaVida;
        public EducacionUniversitariaBuilder(HojaVidaBuilder hvBuilder, HojaVida hv)
        {
            hojaVidaBuilder = hvBuilder;
            hojaVida = hv;
            educacion.Tipo = "Universitaria";
        }
        public EducacionUniversitariaBuilder AgregarNombre(string Nombre)
        {
            educacion.NombrePrograma = Nombre;
            return this;
        }
        public EducacionUniversitariaBuilder AgregarInstitucion(string institucion)
        {
            educacion.NombreInstitucion = institucion;
            return this;
        }
        public EducacionUniversitariaBuilder AgregarFechaGrado(DateTime fechaGrado)
        {
            educacion.FechaGrado = fechaGrado;
            return this;
        }
        public EducacionUniversitariaBuilder AgregarTitulo(string Titulo)
        {
            educacion.Titulo = Titulo;
            return this;
        }
        public EducacionUniversitariaBuilder AgregarEducacionUniversitaria()
        {
            hojaVida.FormacionAcademica.Add(educacion);
            return new EducacionUniversitariaBuilder(hojaVidaBuilder, hojaVida);
        }
        public ExperienciaLaboralBuilder AgregarExperienciaLaboral()
        {
            hojaVida.FormacionAcademica.Add(educacion);
            return new ExperienciaLaboralBuilder(hojaVidaBuilder, hojaVida);
        }
    }
    public class ExperienciaLaboralBuilder
    {
        private readonly Trabajo trabajo = new Trabajo();
        private readonly HojaVidaBuilder hojaVidaBuilder;
        private readonly HojaVida hojaVida;
        public ExperienciaLaboralBuilder(HojaVidaBuilder hvBuilder, HojaVida hv)
        {
            hojaVidaBuilder = hvBuilder;
            hojaVida = hv;
        }
        public ExperienciaLaboralBuilder AgregarCargo(string cargo)
        {
            trabajo.Cargo = cargo;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarFunciones(string funciones)
        {
            trabajo.Funciones = funciones;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarCompañia(string empresa)
        {
            trabajo.Empresa = empresa;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarFechaInicio(DateTime fechaInicio)
        {
            trabajo.FechaInicio = fechaInicio;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarFechaFin(DateTime fechaFin)
        {
            trabajo.FechaFin = fechaFin;
            return this;
        }
        public ExperienciaLaboralBuilder AgregarExperienciaLaboral()
        {
            hojaVida.ExperienciaLaboral.Add(trabajo);
            return new ExperienciaLaboralBuilder(hojaVidaBuilder, hojaVida);
        }
        public HojaVida Build()
        {
            hojaVida.ExperienciaLaboral.Add(trabajo);
            return hojaVida;
        }
        public ReferenciaLaboralBuilder AgregarReferenciaLaboral()
        {
            hojaVida.ExperienciaLaboral.Add(trabajo);
            return new ReferenciaLaboralBuilder(hojaVidaBuilder, hojaVida);
        }
    }

    public class ReferenciaLaboralBuilder
    {
        private readonly Referencias referencia = new Referencias();
        private readonly HojaVidaBuilder hojaVidaBuilder;
        private readonly HojaVida hojaVida;
        public ReferenciaLaboralBuilder(HojaVidaBuilder hvBuilder, HojaVida hv)
        {
            hojaVidaBuilder = hvBuilder;
            hojaVida = hv;
        }
        public ReferenciaLaboralBuilder AgregarNombre(string nombre)
        {
            referencia.Nombre = nombre;
            return this;
        }
        public ReferenciaLaboralBuilder AgregarCargo(string cargo)
        {
            referencia.Cargo = cargo;
            return this;
        }
        public ReferenciaLaboralBuilder AgregarEmpresa(string empresa)
        {
            referencia.Empresa = empresa;
            return this;
        }
        public ReferenciaLaboralBuilder AgregarTelefono(string telefono)
        {
            referencia.Telefono = telefono;
            return this;
        }
        public ReferenciaLaboralBuilder AgregarReferenciaLaboral()
        {
            hojaVida.ReferenciasLaborales.Add(referencia);
            return new ReferenciaLaboralBuilder(hojaVidaBuilder, hojaVida);
        }

        public HabilidadesBuilder AgregarHabilidades()
        {
            hojaVida.ReferenciasLaborales.Add(referencia);
            return new HabilidadesBuilder(hojaVidaBuilder, hojaVida);
        }


        public HojaVida Build()
        {
            hojaVida.ReferenciasLaborales.Add(referencia);
            return hojaVida;
        }

        public class HabilidadesBuilder
        {
            private readonly Skills Habilidad = new Skills();
            private readonly HojaVidaBuilder hojaVidaBuilder;
            private readonly HojaVida hojaVida;
            public HabilidadesBuilder(HojaVidaBuilder hvBuilder, HojaVida hv)
            {
                hojaVidaBuilder = hvBuilder;
                hojaVida = hv;
            }
            public HabilidadesBuilder AgregarNombre(string nombre)
            {
                Habilidad.Nombre = nombre;
                return this;
            }
            public HabilidadesBuilder AgregarDescripcion(string descripcion)
            {
                Habilidad.Descripcion = descripcion;
                return this;
            }

            public HabilidadesBuilder AgregarHabilidades()
            {
                hojaVida.Habilidades.Add(Habilidad);
                return new HabilidadesBuilder(hojaVidaBuilder, hojaVida);
            }
            public HojaVida Build()
            {
                hojaVida.Habilidades.Add(Habilidad);
                return hojaVida;
            }
        }
    }
}
