using Patrones.Patrones.Creacionales.Factory_Method;
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
    public partial class FormFactory : Form
    {
        DatosVehiculo DatosVehiculo = new DatosVehiculo();
        DatosHibrido DatosHibrido = new DatosHibrido();
        DatosElectrico DatosElectrico = new DatosElectrico();
        public FormFactory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            DatosVehiculo.TipoVehiculo = TipoVehiculo.Hibrido;
            DatosHibrido.CapacidadBatería = 5000;
            DatosHibrido.ConsumoCombustible = 20000;
            InvocaFactory(new HibridoCreator(DatosVehiculo, DatosHibrido));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            DatosVehiculo.TipoVehiculo = TipoVehiculo.Electrico;
            DatosElectrico.CapacidadBatería = 5000;
            InvocaFactory(new ElectricoCreator(DatosVehiculo, DatosElectrico));
        }

        private void CapturarDatos()
        {
            DatosVehiculo.Placa = txtPlaca.Text;
            DatosVehiculo.Marca = txtMarca.Text;
            DatosVehiculo.Velocidad = double.Parse(txtVelocidad.Text);
        }

        private void InvocaFactory(VehiculoCreator vehiculo)
        {
            vehiculo.DatosVehiculo = DatosVehiculo;
            txtRespuesta.Text = vehiculo.Consultar();
        }
    }
}
