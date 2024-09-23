using ConsoleAppJsonSchemaExporter.Models;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Schema;

Console.WriteLine("***** Testes com .NET 9 | Utilizando JsonSchemaExporter *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

Console.WriteLine($"Schema do tipo {nameof(TorneioEsportivo)} no formato JSON:");
Console.WriteLine(JsonSchemaExporter.GetJsonSchemaAsNode(
    JsonSerializerOptions.Default, typeof(TorneioEsportivo)));