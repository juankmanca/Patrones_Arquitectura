using System.Windows.Forms;

namespace Patrones.Patrones.Estructurales.Facade
{

    public interface IFileService
    {
        void ReadFile(string fileName);
        void WriteFile(string fileName, string content);
        void SuccessMesagge();
    }

    public class LocalFileService : IFileService
    {
        public void ReadFile(string fileName)
        {
            MessageBox.Show($"Leyendo archivo {fileName} desde el sistema de archivos local.");
        }

        public void SuccessMesagge()
        {
            MessageBox.Show("Archivo guardado en el servidor local exitosamente!!!");
        }

        public void WriteFile(string fileName, string content)
        {
            MessageBox.Show($"Escribiendo contenido en el archivo {fileName} en el sistema de archivos local.");
        }
    }

    public class CloudFileService : IFileService
    {
        public void ReadFile(string fileName)
        {
            MessageBox.Show($"Descargando archivo {fileName} desde el servicio en la nube.");
        }

        public void WriteFile(string fileName, string content)
        {
            MessageBox.Show($"Subiendo contenido {fileName} al servicio en la nube.");
        }

        public void SuccessMesagge()
        {
            MessageBox.Show("Archivo guardado la nube exitosamente!!!");
        }
    }
    public class FileServiceFacade
    {
        private IFileService localFileService;
        private IFileService cloudFileService;

        public FileServiceFacade()
        {
            localFileService = new LocalFileService();
            cloudFileService = new CloudFileService();
        }

        public void ReadFileLocally(string fileName)
        {
            localFileService.ReadFile(fileName);
        }

        public void WriteFileLocally(string fileName, string content)
        {
            localFileService.WriteFile(fileName, content);
        }

        public void ReadFileFromCloud(string fileName)
        {
            cloudFileService.ReadFile(fileName);
        }

        public void WriteFileToCloud(string fileName, string content)
        {
            cloudFileService.WriteFile(fileName, content);
        }

        public void SuccessMessageLocally()
        {
            localFileService.SuccessMesagge();
        }

        public void SuccessMessageCloud()
        {
            cloudFileService.SuccessMesagge();
        }
    }

}
