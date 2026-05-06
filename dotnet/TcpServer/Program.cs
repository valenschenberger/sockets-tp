//Servidor TCP en .NET Core
using System.Net.Sockets;
using System.Net;
using System.Text;
TcpListener server = new TcpListener(IPAddress.Any, 6000);
server.Start();
Console.WriteLine("Servidor TCP escuchando en puerto 6000...");
using TcpClient client = await server.AcceptTcpClientAsync();
Console.WriteLine("Cliente conectado.");
using NetworkStream stream = client.GetStream();
byte[] buffer = new byte[1024];
while (true)
{
int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
if (bytesRead == 0)
break;
string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
Console.WriteLine("Recibido: " + message);
byte[] response = Encoding.UTF8.GetBytes("Mensaje recibido por TCP");
await stream.WriteAsync(response, 0, response.Length);
}
server.Stop();