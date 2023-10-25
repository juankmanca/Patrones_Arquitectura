namespace Patrones.Patrones.Creacionales.Factory_Method
{
    public class HibridoCreator : VehiculoCreator
    {
        private DatosHibrido DatosHibrido { get; set; }
        public override IVehiculo FactoryMethod()
        {
            return new VehiculoHibrido(DatosVehiculo, DatosHibrido);
        }

        public HibridoCreator(DatosVehiculo datosVehiculo, DatosHibrido datosHibrido)
        {
            DatosHibrido = datosHibrido;
            DatosVehiculo = datosVehiculo;
        }

        public class VehiculoHibrido : IVehiculo
        {
            public DatosVehiculo DatosVehiculo { get; set; }
            public DatosHibrido _DatosHibrido { get; set; }

            public VehiculoHibrido(DatosVehiculo datosVehiculo, DatosHibrido datosHibrido)
            {
                DatosVehiculo = datosVehiculo;
                _DatosHibrido = datosHibrido;
            }


            public void ConsultarPlaca()
            {
                DatosVehiculo.Placa = "DBD114";
            }

            public void ConsultarVelocidadMaxima()
            {
                DatosVehiculo.Velocidad = 180;
            }

            public string CRUD()
            {
                return "Proceos de inserción, actualización, desactivación y consulta de vehiculos.";
            }
        }
    }
}
