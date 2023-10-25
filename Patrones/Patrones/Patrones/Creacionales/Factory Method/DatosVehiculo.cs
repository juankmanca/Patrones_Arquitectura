namespace Patrones.Patrones.Creacionales.Factory_Method
{
    public enum TipoVehiculo
    {
        Hibrido = 1,
        Electrico = 2
    }

    public class DatosVehiculo
    {
        public TipoVehiculo TipoVehiculo { get; set; }    
        public string Marca { get; set; }
        public double Velocidad { get; set; }
        public string Placa { get; set; }
    }

    public class DatosHibrido
    {
        public double ConsumoCombustible { get; set; }
        public double CapacidadBatería { get; set; }
    }

    public class DatosElectrico
    {
        public double CapacidadBatería { get; set; }
    }
}
