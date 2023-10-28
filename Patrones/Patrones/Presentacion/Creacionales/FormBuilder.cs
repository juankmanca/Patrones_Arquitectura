using Patrones.Patrones.Creacionales.Builder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patrones.Presentacion.Creacionales
{
    public partial class FormBuilder : Form
    {
        public FormBuilder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var hojaVidaBuilder = new HojaVidaBuilder();
            HojaVida hojaVida = hojaVidaBuilder
                .AgregarDatosPersonales()
                    .AgregarDocumento("10012548588")
                    .AgregarNombre("Pedro Gómez")
                .AgregarColegio()
                    .AgregarNombre("Bachillerato técnico")
                    .AgregarInstitucion("Colegio Salazar y Herrera")
                    .AgregarTitulo("Bachiller técnico en ...")
                    .AgregarFechaGrado(new DateTime(2005, 11, 30))
                .AgregarEducacionUniversitaria()
                    .AgregarNombre("Tecnólogía en Sistemas")
                    .AgregarInstitucion("ITM")
                    .AgregarTitulo("Tecnólogo en Sistemas de Información")
                    .AgregarFechaGrado(new DateTime(2008, 11, 15))
                .AgregarEducacionUniversitaria()
                    .AgregarNombre("Ingenería Sistemas")
                    .AgregarInstitucion("ITM")
                    .AgregarTitulo("Ingeniero de Sistemas")
                    .AgregarFechaGrado(new DateTime(2012, 07, 28))
                .AgregarExperienciaLaboral()
                    .AgregarCargo("Desarrollador")
                    .AgregarCompañia("InterDesarrollo")
                    .AgregarFunciones("Programador en ...")
                    .AgregarFechaInicio(new DateTime(2007, 03, 01))
                .Build();

            //Presentar los resultados en el textbox
            lblMensaje.Text = "HOJA DE VIDA\nDATOS PERSONALES";
            foreach (DatosPersonales datosPersonales in hojaVida.datosPersonales)
            {
                lblMensaje.Text += "\nDocumento: " + datosPersonales.Documento +
                                   "\nNombre: " + datosPersonales.Nombre + "\n";
            }
            lblMensaje.Text += "\nINFORMACIÓN ACADÉMICA";
            foreach (Educacion educacion in hojaVida.FormacionAcademica)
            {
                lblMensaje.Text += "\nPrograma: " + educacion.NombrePrograma +
                                   "\nInstitución: " + educacion.NombreInstitucion +
                                   "\nTítulo: " + educacion.Titulo + " - " +
                                   "\nFecha grado: " + educacion.FechaGrado.ToString("yyyy-MMM") + "\n";
            }
            lblMensaje.Text += "\nEXPERIENCIA LABORAL\n";
            foreach (Trabajo trabajo in hojaVida.ExperienciaLaboral)
            {
                lblMensaje.Text += "Cargo: " + trabajo.Cargo + " - " +
                                        "Funciones: " + trabajo.Funciones + "\n" +
                                        "Empresa: " + trabajo.Empresa + " - " +
                                        "Fecha inicio: " + trabajo.FechaInicio.ToString("yyyy-MMM") + "\n";
                if (trabajo.FechaFin > new DateTime(1920, 1, 1))
                {
                    lblMensaje.Text += "Fecha terminación contrato: " +
                                            trabajo.FechaFin.ToString("yyyy-MMM") + "\n\n";
                }
                else
                {
                    lblMensaje.Text += "Trabajo actual\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var hojaVidaBuilder = new HojaVidaBuilder();
            HojaVida hojaVida = hojaVidaBuilder
                .AgregarColegio()
                    .AgregarNombre("Bachillerato técnico")
                    .AgregarInstitucion("Colegio Salazar y Herrera")
                    .AgregarTitulo("Bachiller técnico en ...")
                    .AgregarFechaGrado(new DateTime(2005, 11, 30))
                .AgregarEducacionUniversitaria()
                    .AgregarNombre("Tecnólogía en Sistemas")
                    .AgregarInstitucion("ITM")
                    .AgregarTitulo("Tecnólogo en Sistemas de Información")
                    .AgregarFechaGrado(new DateTime(2008, 11, 15))
                .AgregarExperienciaLaboral()
                    .AgregarCargo("Desarrollador")
                    .AgregarCompañia("InterDesarrollo")
                    .AgregarFunciones("Programador en ...")
                    .AgregarFechaInicio(new DateTime(2007, 03, 01))
                .AgregarReferenciaLaboral()
                    .AgregarNombre("Paula Rojas")
                    .AgregarCargo("Líder desarrollo")
                    .AgregarEmpresa("InterDesarrollo")
                    .AgregarTelefono("3002547896")
                .AgregarReferenciaLaboral()
                    .AgregarNombre("Andrés Botero")
                    .AgregarCargo("Desarrollador senior")
                    .AgregarEmpresa("InterDesarrollo")
                    .AgregarTelefono("3152015247")
                .Build();

            //Presentar los resultados en el textbox
            lblMensaje.Text = "HOJA DE VIDA\nINFORMACIÓN ACADÉMICA";
            foreach (Educacion educacion in hojaVida.FormacionAcademica)
            {
                lblMensaje.Text += "Programa: " + educacion.NombrePrograma +
                                   "\nInstitución: " + educacion.NombreInstitucion +
                                   "\nTítulo: " + educacion.Titulo + " - " +
                                   "\nFecha grado: " + educacion.FechaGrado.ToString("yyyy-MMM") + "\n";
            }
            lblMensaje.Text += "\nEXPERIENCIA LABORAL\n";
            foreach (Trabajo trabajo in hojaVida.ExperienciaLaboral)
            {
                lblMensaje.Text += "Cargo: " + trabajo.Cargo + " - " +
                                    "Funciones: " + trabajo.Funciones + "\n" +
                                    "Empresa: " + trabajo.Empresa + " - " +
                                    "Fecha inicio: " + trabajo.FechaInicio.ToString("yyyy-MMM") + "\n";
                if (trabajo.FechaFin > new DateTime(1920, 1, 1))
                {
                    lblMensaje.Text += "Fecha terminación contrato: " +
                                            trabajo.FechaFin.ToString("yyyy-MMM") + "\n\n";
                }
                else
                {
                    lblMensaje.Text += "Trabajo actual\n";
                }
            }
            lblMensaje.Text += "\nREFERENCIAS LABORALES\n";
            foreach (Referencias referencias in hojaVida.ReferenciasLaborales)
            {
                lblMensaje.Text += "Nombre: " + referencias.Nombre + "\n " +
                                    "Cargo  : " + referencias.Cargo + "\n" +
                                    "Empresa: " + referencias.Empresa + " - " +
                                    "Telefono: " + referencias.Telefono + "\n\n";
            }
        }
    }
}
