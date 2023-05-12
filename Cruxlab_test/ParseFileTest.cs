using Cruxlab_lib.FileParser;
using Cruxlab_lib.Model;

namespace Cruxlab_test
{
    public class ParseFileTest
    {
        private PasswordRequirementsFileParser _parser;

        public ParseFileTest()
        {
            _parser = new PasswordRequirementsFileParser();
        }

        [Fact]
        public void GetDataAsyncSuccessCase()
        {
            //Arrange
            var data = "a 1-5: abcdj";

            var expectedResult = new PasswordRequirementsModel()
            {
                RequiredString = "a",
                MaxCountOfRequiredString = 5,
                MinCountOfRequiredString = 1,
                Password = "abcdj",
            };

            //Act
            var actualResult = _parser.ParseData(data);

            //Assert
            Assert.NotNull(actualResult);
            Assert.Equal(expectedResult.RequiredString, actualResult.RequiredString);
            Assert.Equal(expectedResult.Password, actualResult.Password);
            Assert.Equal(expectedResult.MinCountOfRequiredString, actualResult.MinCountOfRequiredString);
            Assert.Equal(expectedResult.MaxCountOfRequiredString, actualResult.MaxCountOfRequiredString);
        }
    }
}
