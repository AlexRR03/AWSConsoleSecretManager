// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using AWSConsoleSecretManager.Helpers;
using AWSConsoleSecretManager.Models;
using Microsoft.Extensions.DependencyInjection;
using AWSConsoleSecretManager;

Console.WriteLine("Ejemplo Secret Manager");

string miSecreto = await HelperSecretManager.GetSecretAsync();
KeysModel model = JsonConvert.DeserializeObject<KeysModel>(miSecreto);
Console.WriteLine($"MySql: {model.MySql}");
Console.WriteLine($"Bucket: {model.Bucket}");
Console.WriteLine($"Api: {model.Api}");

//Almacenar el objeto keysmodel dentro de builder para recuperarlo donde sea
var provider = new ServiceCollection()
    .AddTransient<ClaseTest>()
    .AddSingleton<KeysModel>(x=> model)
    .BuildServiceProvider();
var test = provider.GetService<ClaseTest>();
Console.WriteLine($"Api desde el test: {test.GetApiVulue()}");

Console.WriteLine("Presione una tecla para continuar...");
Console.ReadLine();


