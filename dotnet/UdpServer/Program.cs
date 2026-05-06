//Servidor UDP .NET Core
using System.Net;
using System.Net.Sockets;
using System.Text;
Console.WriteLine("Servidor UDP escuchando en puerto 5005...");
using UdpClient server = new UdpClient(5005);
IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
while (true)
{
byte[] data = server.Receive(ref remoteEP);
string message = Encoding.UTF8.GetString(data);
Console.WriteLine($"Mensaje de {remoteEP}: {message}");
byte[] response = Encoding.UTF8.GetBytes("Mensaje recibido");
server.Send(response, response.Length, remoteEP);
}
