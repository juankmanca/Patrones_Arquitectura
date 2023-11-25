using Patrones.Patrones.Clases;
using Patrones.Patrones.Estructurales.Composite;
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
    public partial class FormComposite : Form
    {
        SQLServerConnection db = new SQLServerConnection("localhost", "Patrones", "sa", "123456789");

        string IDPrograma = string.Empty;
        ProgramaAcademico programaSelected;
        public FormComposite()
        {
            InitializeComponent();
            GetData();
        }

        private void FormComposite_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNodoPadre.Text;
            var Programa = new ProgramaAcademico(nombre);
            Programa.AgregarProgramaDB();
            GetData();
        }

        public void GetData()
        {
            try
            {
                db.OpenConnection();
                DataTable dt = db.ExecuteQuery("SELECT * FROM Programas");
                if (dt == null) return;
                grid1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
                {
                    DataGridViewRow selectedRow = grid1.Rows[e.RowIndex];
                    DataGridViewCell selectedCell = selectedRow.Cells[e.ColumnIndex];
                    DataGridViewCell selectedCellID = selectedRow.Cells[e.ColumnIndex - 1];

                    string cellValue = selectedCell.Value.ToString();
                    string IDPadre = selectedCellID.Value.ToString();
                    programaSelected = new ProgramaAcademico(cellValue);

                    txtNodoPadre.Text = cellValue;
                    IDPrograma = IDPadre;
                    ShowForm2();
                    GetData2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select only the name of the program");
            }
        }

        public void ShowForm2()
        {

        }

        public void GetData2()
        {
            try
            {
                db.OpenConnection();
                string query = $"SELECT C.* FROM Cursos C INNER JOIN Programas P ON P.ID = C.IDProgramas WHERE P.ID = {IDPrograma}";
                DataTable dt = db.ExecuteQuery(query);
                if (dt == null) return;
                grid2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string nombreCurso = txtCurso.Text;
            string nombreProf = txtProfesor.Text;
            var curso = new Curso(nombreCurso, nombreProf, IDPrograma);
            programaSelected.AgregarCursoDB(curso);
            GetData2();
        }
    }
}
