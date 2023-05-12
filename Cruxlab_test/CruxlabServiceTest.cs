using Cruxlab_lib.FileWorker;
using Cruxlab_lib.Services;

namespace Cruxlab_test
{
    public class CruxlabServiceTest
    {
        private CruxlabService _service;

        public CruxlabServiceTest()
        {
            _service = new CruxlabService();
        }

        [Fact]
        public async void GetDataAsyncSuccessCase()
        {
            //Arrange
            var expectedResult = 3;

            //Act
            var actualResult = await _service.GetCountOfValidPasswordInFile();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
