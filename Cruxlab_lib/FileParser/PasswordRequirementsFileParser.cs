using Cruxlab_lib.Model;

namespace Cruxlab_lib.FileParser
{
    public class PasswordRequirementsFileParser
    {
        public PasswordRequirementsModel ParseData(string data)
        {
            var indexOfRequiredString = 0;
            var indexOfPassword = 2;
            var indexOfMinMaxStr = 1;
            var indexOfMinValueInMinMaxArr = 0;
            var indexOfMaxValueInMinMaxArr = 1;

            var values = data.Split(' ');

            var minMaxSrt = values[indexOfMinMaxStr];

            var minMaxArr = minMaxSrt.Remove(minMaxSrt.Length - 1).Split('-');

            Int32.TryParse(minMaxArr[indexOfMinValueInMinMaxArr], out var min);
            Int32.TryParse(minMaxArr[indexOfMaxValueInMinMaxArr], out var max);

            return new PasswordRequirementsModel()
            { 
                RequiredString = values[indexOfRequiredString],
                MinCountOfRequiredString = min,
                MaxCountOfRequiredString = max,
                Password = values[indexOfPassword]
            };
        }
    }
}
