using Patrones.Patrones.Clases;
using Patrones.Patrones.Creacionales.Factory_Method;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patrones.Presentacion.Creacionales
{
    public partial class FormFactory : Form
    {
        DatosVehiculo DatosVehiculo = new DatosVehiculo();
        DatosHibrido DatosHibrido = new DatosHibrido();
        DatosElectrico DatosElectrico = new DatosElectrico();
        SQLServerConnection db = new SQLServerConnection("localhost", "Patrones", "sa", "123456789");
        public FormFactory()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            try
            {
                db.OpenConnection();
                DataTable dt = db.ExecuteQuery("SELECT * FROM Vehiculos");
                if (dt == null) return;
                grdVehiculo.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            if (!validateFields()) return;
            DatosVehiculo.TipoVehiculo = TipoVehiculo.Hibrido;
            DatosHibrido.CapacidadBatería = 5000;
            DatosHibrido.ConsumoCombustible = 20000;
            InvocaFactory(new HibridoCreator(DatosVehiculo, DatosHibrido));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            if (!validateFields()) return;
            DatosVehiculo.TipoVehiculo = TipoVehiculo.Electrico;
            DatosElectrico.CapacidadBatería = 5000;
            InvocaFactory(new ElectricoCreator(DatosVehiculo, DatosElectrico));
        }

        public bool validateFields()
        {
            if (string.IsNullOrEmpty(DatosVehiculo.Placa) || string.IsNullOrEmpty(DatosVehiculo.Placa) || string.IsNullOrEmpty(DatosVehiculo.Placa))
            {
                txtRespuesta.Text = "Fill all fields";
                return false;
            }
            else
            {
                txtRespuesta.Text = "";
                return true;
            }
        }

        private void CapturarDatos()
        {
            DatosVehiculo.Placa = txtPlaca.Text;
            DatosVehiculo.Marca = txtMarca.Text;
            double.TryParse(txtVelocidad.Text, out double result);
            DatosVehiculo.Velocidad = result;
        }

        private void InvocaFactory(VehiculoCreator vehiculo)
        {
            vehiculo.DatosVehiculo = DatosVehiculo;
            //txtRespuesta.Text = vehiculo.Consultar();
            InsertarDatos(vehiculo);
        }

        public void InsertarDatos(VehiculoCreator vehiculo)
        {
            string query = vehiculo.Insertar();
            db.InsertDataByQuery(query);
            GetData();
        }

    }
}
