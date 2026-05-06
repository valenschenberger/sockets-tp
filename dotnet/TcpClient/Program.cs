//Cliente TCP en .NET Core
using System.Net.Sockets;
using System.Text;
using TcpClient client = new TcpClient();
await client.ConnectAsync("localhost", 6000);
using NetworkStream stream = client.GetStream();
byte[] msg = Encoding.UTF8.GetBytes("Hola servidor TCP");
await stream.WriteAsync(msg, 0, msg.Length);
byte[] buffer = new byte[1024];
int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
Console.WriteLine("Respuesta: " + Encoding.UTF8.GetString(buffer, 0, bytesRead));