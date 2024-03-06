namespace Koutye.Utils
{
    public class FileUpload
    {
        public string uploadPicture(IFormFile file)
        {
            string path = null;
            if (file == null) throw new ArgumentNullException("Aucun fichier n'est téléchargé...");
            else
            {
                string fileName = Path.GetFileName(file.FileName);
                path = "C:\\Koutye_Folder\\Users";
                
                using (Stream fileStream = new FileStream(path, FileMode.Open,FileAccess.ReadWrite))
                {
                    file.CopyToAsync(fileStream);
                }
                
            }

            return path;
        }
    }
}
