using Cruxlab_lib.FileWorker;

namespace Cruxlab_test
{
    public class FileWorkerTest
    {
        private TextFileWorker _fileWorker;

        public FileWorkerTest()
        {
            _fileWorker = new TextFileWorker();
        }

        [Fact]
        public async void GetDataAsyncSuccessCase()
        {
            var actualResult = await _fileWorker.GetDataAsync();

            Assert.True(!string.IsNullOrEmpty(actualResult));
        }
    }
}
