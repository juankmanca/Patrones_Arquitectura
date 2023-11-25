using Patrones.Presentacion.Creacionales;
using Patrones.Presentacion.Estructurales;
using System;
using System.Windows.Forms;

namespace Patrones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactoryMethod_Click(object sender, EventArgs e)
        {
            FormFactory fFactoryMethod = new FormFactory();
            fFactoryMethod.Show();
        }

        private void btnAbstractFactory_Click(object sender, EventArgs e)
        {
            FormAbstractFactory fAbstractFactoryMethod = new FormAbstractFactory();
            fAbstractFactoryMethod.Show();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBuilder formBuilder = new FormBuilder();
            formBuilder.Show();
        }

        private void btnComposite_Click(object sender, EventArgs e)
        {
            FormComposite formComposite = new FormComposite();
            formComposite.Show();
        }

        private void btnFacade_Click(object sender, EventArgs e)
        {
            FormFacade formFacade = new FormFacade();
            formFacade.Show();
        }
    }
}
