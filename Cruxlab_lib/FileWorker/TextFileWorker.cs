namespace Cruxlab_lib.FileWorker
{
    public class TextFileWorker
    {
        private readonly string _path;

        public TextFileWorker()
        {
            _path = "../../../../CruxlabPasswordsRequirements.txt";
        }

        public async Task<string> GetDataAsync()
        {
            try
            {
                return await File.ReadAllTextAsync(_path);
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
