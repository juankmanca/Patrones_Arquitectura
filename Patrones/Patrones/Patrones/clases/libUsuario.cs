using Patrones.Patrones.Creacionales.Abstract_Factory;

namespace Patrones.Patrones.Clases
{
    public class Usuario
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }

    public class brokerUsuario
    {
        //Clase que se encargará de conectar con la base de datos e invocar el factory correspondiente
        public Usuario usuario { get; set; }
        private string SQL;
        public string Consultar()
        {
            SQL = "SELECT       Documento, Nombre, Email, Celular " +
                  "FROM         Usuario " +
                  "WHERE        Documento = '" + usuario.Documento + "'";
            //Crea la factory
            BaseDatosFactory factory = new BaseDatosFactory();
            return InvocarFactorySelect(factory);
        }
        public string ConsultarTodos()
        {
            SQL = "SELECT       Documento, Nombre, Email, Celular " +
                  "FROM         Usuario ";
            //Crea la factory
            BaseDatosFactory factory = new BaseDatosFactory();
            return InvocarFactorySelect(factory);
        }
        public string Insertar()
        {
            SQL = "INSERT INTO Usuario (Documento, Nombre, Email, Celular) " +
                  "VALUES ('" + usuario.Documento + "', '" + usuario.Nombre + "', '" +
                            usuario.Email + "', '" + usuario.Celular + "')";
            //Crea la factory
            BaseDatosFactory factory = new BaseDatosFactory();
            return InvocarFactoryExec(factory, "Insertar");
        }
        public string Actualizar()
        {
            SQL = "UPDATE       Usuario " +
                  "SET          Nombre      = '" + usuario.Nombre + "', " +
                               "Email       = '" + usuario.Email + "', " +
                               "Celular     = '" + usuario.Celular + "' " +
                  "WHERE        Documento   = '" + usuario.Documento + "'";
            //Crea la factory
            BaseDatosFactory factory = new BaseDatosFactory();
            return InvocarFactoryExec(factory, "Actualizar");
        }
        public string Eliminar()
        {
            SQL = "DELETE FROM  Usuario " +
                  "WHERE        Documento = '" + usuario.Documento + "'";
            //Crea la factory
            BaseDatosFactory factory = new BaseDatosFactory();
            return InvocarFactoryExec(factory, "Eliminar");
        }
        private string InvocarFactoryExec(IAbstractFactoryBD factoryBD, string Comando)
        {
            //Invoca la conexión para ejecutar consultas de acción
            factoryBD.baseDatos = Configuracion.baseDatos;
            var bdUsuarios = factoryBD.CrearBaseDatos();
            bdUsuarios.SQL = SQL;
            switch (Comando)
            {
                case "Insertar":
                    return bdUsuarios.Insertar();
                case "Actualizar":
                    return bdUsuarios.Actualizar();
                case "Eliminar":
                    return bdUsuarios.Eliminar();
                default: return null;
            }
        }
        private string InvocarFactorySelect(IAbstractFactoryBD factoryBD)
        {
            //Invoca la conexión para la consulta (SELECT)
            factoryBD.baseDatos = Configuracion.baseDatos;
            var bdUsuarios = factoryBD.CrearBaseDatos();
            bdUsuarios.SQL = SQL;
            return bdUsuarios.Consultar();
        }
    }
}
