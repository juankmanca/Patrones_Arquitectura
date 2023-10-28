namespace Patrones.Patrones.Creacionales.Abstract_Factory
{
    public interface IAbstractFactoryBD
    {
        eBaseDatos baseDatos { get; set; }
        IAbstractFactoryBaseDatos CrearBaseDatos();
    }
    public interface IAbstractFactoryBaseDatos
    {
        //Propiedades y métodos de la clase
        string SQL { get; set; }
        //string Error { get; set; }
        string Insertar();
        string Actualizar();
        string Eliminar();
        string Consultar();
    }
    public enum eBaseDatos
    {
        SQLServer = 1,
        Access = 2,
        SQLite = 3,
        PostGreSQL = 4
    }

    public class BaseDatosFactory : IAbstractFactoryBD
    {
        public eBaseDatos baseDatos { get; set; }
        public IAbstractFactoryBaseDatos CrearBaseDatos()
        {
            switch (baseDatos)
            {
                case eBaseDatos.SQLServer:
                    //Retorna la conexión de SQL Server
                    return new ConexionSQL();
                case eBaseDatos.Access:
                    return new ConexionAccess();
                case eBaseDatos.SQLite:
                    return new ConexionSQLite();
                case eBaseDatos.PostGreSQL:
                    return new ConexionPostgreSQL();
                default: return null;
            }
        }
    }
}
