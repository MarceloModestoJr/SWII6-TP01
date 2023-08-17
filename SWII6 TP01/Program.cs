using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel;
using TP01;
using TP01.Controller;

// Marcelo Modesto de Lima Junior CB3015823
// Bruna Helena Silva Santos CB3016111

var controller = new BookController();

controller.DesmostrarMetodos();

Console.WriteLine("\n\n\n\n");

IWebHost host = new WebHostBuilder()
    .UseKestrel()
    .UseStartup<Startup>()
    .Build();

host.Run();