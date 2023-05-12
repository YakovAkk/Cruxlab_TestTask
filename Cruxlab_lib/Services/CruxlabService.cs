using Cruxlab_lib.FileParser;
using Cruxlab_lib.FileWorker;
using Cruxlab_lib.Validator;

namespace Cruxlab_lib.Services
{
    public class CruxlabService
    {
        private readonly PasswordValidator _validator;
        private readonly TextFileWorker _fileWorker;
        private readonly PasswordRequirementsFileParser _parser;
        public CruxlabService()
        {
            _fileWorker = new TextFileWorker();
            _parser = new PasswordRequirementsFileParser();
            _validator = new PasswordValidator();
        }
        public async Task<int> GetCountOfValidPasswordInFile()
        {
            var separatedString = "\r\n";

            var data = await _fileWorker.GetDataAsync();
            var list = data.Split(separatedString);
            var listOfModels = list.Select(x => _parser.ParseData(x)).ToList();

            var count = 0;
            foreach (var item in listOfModels)
            {
                if(_validator.IsValidPassword(item))
                    count++;
            }

            return count;
        }
    }
}
