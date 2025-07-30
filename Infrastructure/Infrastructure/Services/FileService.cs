
using ETicaretAPI.Infrastructure.Operations;

namespace ETicaretAPI.Infrastructure.Services
{
    public class FileService 
    {
        public async Task<string> FileRenameAsync(string path, string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string baseName = NameOperation.CharacterRegulatory(Path.GetFileNameWithoutExtension(fileName));
            string newFileName = $"{baseName}{extension}";
            int counter = 1;

            while (File.Exists(Path.Combine(path, newFileName)))
            {
                
                newFileName = $"{baseName}-{counter}{extension}";
                counter++;
            }

            return newFileName;
        }

    }
}
