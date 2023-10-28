using Patrones.Presentacion.Creacionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
