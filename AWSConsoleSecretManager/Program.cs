// See https://aka.ms/new-console-template for more information
using AWSConsoleSecretManager.Helpers;

Console.WriteLine("Ejemplo Secret Manager");

string miSecreto = await HelperSecretManager.GetSecretAsync();
Console.WriteLine($"El secreto es: {miSecreto}");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadLine();


