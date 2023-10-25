namespace Patrones.Patrones.Creacionales.Factory_Method
{
    public abstract class VehiculoCreator
    {
        public DatosVehiculo DatosVehiculo { get; set; }

        public abstract IVehiculo FactoryMethod();

        public string Consultar()
        {
            var Vehiculo = FactoryMethod();
            Vehiculo.ConsultarPlaca();
            Vehiculo.ConsultarVelocidadMaxima();
            return $"El Vehiculo de placas {DatosVehiculo.Placa} \n" +
                $"Con Velocidad Maxima de: {DatosVehiculo.Velocidad}Km\\h \n" +
                $"El tipo de vehiculo es {DatosVehiculo.TipoVehiculo} \n" +
                "El CRUD implementado es: " + Vehiculo.CRUD();
        }
    }
}
