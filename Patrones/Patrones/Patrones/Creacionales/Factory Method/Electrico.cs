namespace Patrones.Patrones.Creacionales.Factory_Method
{
    public class ElectricoCreator : VehiculoCreator
    {
        private DatosElectrico DatosElectrico { get; set; }
        public override IVehiculo FactoryMethod()
        {
            return new VehiculoElectrico(DatosVehiculo, DatosElectrico);
        }

        public ElectricoCreator(DatosVehiculo datosVehiculo, DatosElectrico datosElectrico)
        {
            DatosElectrico = DatosElectrico;
            DatosVehiculo = datosVehiculo;
        }

        public class VehiculoElectrico : IVehiculo
        {
            public DatosVehiculo DatosVehiculo { get; set; }
            public DatosElectrico DatosElectrico { get; set; }

            public VehiculoElectrico(DatosVehiculo datosVehiculo, DatosElectrico datosElectrico)
            {
                DatosVehiculo = datosVehiculo;
                DatosElectrico = datosElectrico;
            }


            public void ConsultarPlaca()
            {
                DatosVehiculo.Placa = "YUS821";
            }

            public void ConsultarVelocidadMaxima()
            {
                DatosVehiculo.Velocidad = 250;
            }

            public string CRUD()
            {
                return "Proceos de inserción, actualización, desactivación y consulta de vehiculos.";
            }

           
        }
    }
}
