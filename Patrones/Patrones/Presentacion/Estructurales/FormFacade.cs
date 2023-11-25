using Patrones.Patrones.Estructurales.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patrones.Presentacion.Estructurales
{
    public partial class FormFacade : Form
    {
        public string FileName = string.Empty;

        public FormFacade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileServiceFacade fileFacade = new FileServiceFacade();

            fileFacade.ReadFileLocally(FileName);
            fileFacade.WriteFileLocally(FileName, "Contenido del documento");
            fileFacade.SuccessMessageLocally();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileServiceFacade fileFacade = new FileServiceFacade();

            fileFacade.ReadFileFromCloud(FileName);
            fileFacade.WriteFileToCloud(FileName, "Contenido del archivo en la nube");
            fileFacade.SuccessMessageCloud();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";

            DialogResult resultado = openFileDialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    string rutaArchivo = openFileDialog.FileName;
                    FileName = openFileDialog.FileName;

                    Image imagenOriginal = Image.FromFile(rutaArchivo);
                    Image imagenRedimensionada = RedimensionarImagen(imagenOriginal, pictureBox1.Width, pictureBox1.Height);

                    pictureBox1.Image = imagenRedimensionada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Image RedimensionarImagen(Image imagenOriginal, int nuevoAncho, int nuevoAlto)
        {
            Bitmap imagenRedimensionada = new Bitmap(nuevoAncho, nuevoAlto);

            using (Graphics g = Graphics.FromImage(imagenRedimensionada))
            {
                g.DrawImage(imagenOriginal, 0, 0, nuevoAncho, nuevoAlto);
            }

            return imagenRedimensionada;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
