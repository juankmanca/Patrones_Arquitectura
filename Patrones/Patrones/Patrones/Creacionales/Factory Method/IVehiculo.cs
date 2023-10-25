namespace Patrones.Patrones.Creacionales.Factory_Method
{
    public interface IVehiculo
    {
        DatosVehiculo DatosVehiculo { get; set; }
        void ConsultarPlaca();

        void ConsultarVelocidadMaxima();

        string CRUD();
    }
}
