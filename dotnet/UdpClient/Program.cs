//Cliente UDP en .NET Core 
using System.Net;
using System.Net.Sockets;
using System.Text;
using UdpClient client = new UdpClient();
byte[] msg = Encoding.UTF8.GetBytes("Hola servidor UDP");
await client.SendAsync(msg, msg.Length, "localhost", 5005);
UdpReceiveResult result = await client.ReceiveAsync();
Console.WriteLine("Respuesta: " + Encoding.UTF8.GetString(result.Buffer));