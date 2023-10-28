using Newtonsoft.Json;
using Patrones.Patrones.Clases;
using Patrones.Patrones.Creacionales.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Patrones.Presentacion.Creacionales
{
    public partial class FormAbstractFactory : Form
    {
        Usuario usuario = new Usuario();
        public FormAbstractFactory()
        {
            InitializeComponent();
        }

        private void FormAbstractFactory_Load(object sender, EventArgs e)
        {
            LlenarComboBaseDatos();
        }

        private void LlenarComboBaseDatos()
        {
            cboBaseDatos.Items.Add("SQLServer");
            cboBaseDatos.Items.Add("Access");
            cboBaseDatos.Items.Add("SQLite");
            cboBaseDatos.Items.Add("PostGreSQL");
        }

        private void LeerDatos()
        {
            usuario.Documento = txtDocumento.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Email = txtEmail.Text;
            usuario.Celular = txtCelular.Text;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            LeerDatos();
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            lblMensaje.Text = bUsuario.Insertar();
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            string Rpta = bUsuario.ConsultarTodos();
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(Rpta);
            grdUsuarios.DataSource = usuarios;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            LeerDatos();
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            string Rpta = bUsuario.Consultar();
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(Rpta);
            if(usuarios.Count > 0)
            {
                txtNombre.Text = usuarios[0].Nombre;
                txtEmail.Text = usuarios[0].Email;
                txtCelular.Text = usuarios[0].Celular;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            LeerDatos();
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            lblMensaje.Text = bUsuario.Actualizar();
            LlenarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            LeerDatos();
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            lblMensaje.Text = bUsuario.Eliminar();
            LlenarGrid();
        }
    }
}
