// See https://aka.ms/new-console-template for more information

using Cruxlab_lib.Services;

var _service = new CruxlabService();

var actualResult = await _service.GetCountOfValidPasswordInFile();

Console.WriteLine(actualResult);
Console.ReadKey();
