
guia_desarrollo_sockets_vscode.md

Página
1
/
1
100 %
# Guía de Desarrollo — Programación de Sockets en Python, .NET Core y NodeJS

## Objetivo de la guía

Esta guía tiene como finalidad orientar el desarrollo de ejemplos de comunicación cliente-servidor mediante **sockets**, utilizando los protocolos **UDP** y **TCP** en tres lenguajes de programación: **Python**, **C# con .NET Core** y **NodeJS**.

La propuesta está pensada para alumnos universitarios de Redes de Datos y utiliza **Visual Studio Code** como entorno de desarrollo común para todos los lenguajes. La guía incluye preparación del entorno, estructura de carpetas, nombres de archivos y librerías necesarias para cada tecnología.

---

# 1. Entorno general de trabajo

## 1.1. Instalación de Visual Studio Code

Se recomienda utilizar **Visual Studio Code** por ser un editor liviano, multiplataforma y adecuado para trabajar con varios lenguajes dentro de una misma carpeta de proyecto.

Descargar Visual Studio Code desde:

```text
https://code.visualstudio.com/
```

Luego de instalarlo, abrir una terminal y verificar que el comando `code` esté disponible:

```bash
code --version
```

Si el comando no funciona, abrir Visual Studio Code y ejecutar:

```text
Ctrl + Shift + P
```

Luego buscar y seleccionar:

```text
Shell Command: Install 'code' command in PATH
```

En Windows, si esta opción no aparece, se puede abrir la carpeta manualmente desde Visual Studio Code usando:

```text
File > Open Folder
```

---

# 3. Desarrollo en C# con .NET Core

## 3.1. Preparación del entorno .NET Core

Para desarrollar sockets en C# se utilizará **.NET SDK**, que permite crear, compilar y ejecutar aplicaciones de consola multiplataforma.

Se recomienda instalar **.NET 8 SDK o superior**.

Verificar la instalación:

```bash
dotnet --version
```

También se puede listar la información completa del entorno:

```bash
dotnet --info
```

En Visual Studio Code se recomienda instalar alguna de las siguientes extensiones:

```text
C# Dev Kit - Microsoft
```

O también:

```text
C# - Microsoft
```

La extensión permite autocompletado, depuración, navegación entre clases y reconocimiento de proyectos `.csproj`.

---

## 3.2. Librerías necesarias en .NET Core

Para los ejemplos básicos de sockets no es necesario instalar paquetes externos mediante NuGet. Se utilizan namespaces incluidos en .NET:

```csharp
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
```

Los principales componentes utilizados serán:

```text
UdpClient
TcpClient
TcpListener
NetworkStream
IPEndPoint
IPAddress
Encoding
```

Opcionalmente, para proyectos más avanzados se podrían instalar paquetes como:

```bash
dotnet add package Microsoft.Extensions.Configuration
```

O:

```bash
dotnet add package Microsoft.Extensions.Configuration.Json
```

Esto permitiría manejar archivos `appsettings.json`. Para los ejemplos iniciales no es obligatorio.

---

## 3.3. Estructura de carpetas en .NET Core

Desde la carpeta principal `sockets-tp`, crear una carpeta para los proyectos .NET:

```bash
mkdir dotnet
cd dotnet
```

Crear cuatro aplicaciones de consola independientes:

```bash
dotnet new console -n UdpServer
dotnet new console -n UdpClient
dotnet new console -n TcpServer
dotnet new console -n TcpClient
```

La estructura esperada será:

```text
dotnet/
│
├── UdpServer/
│   ├── Program.cs
│   ├── UdpServer.csproj
│   ├── bin/
│   └── obj/
│
├── UdpClient/
│   ├── Program.cs
│   ├── UdpClient.csproj
│   ├── bin/
│   └── obj/
│
├── TcpServer/
│   ├── Program.cs
│   ├── TcpServer.csproj
│   ├── bin/
│   └── obj/
│
└── TcpClient/
    ├── Program.cs
    ├── TcpClient.csproj
    ├── bin/
    └── obj/
```

Los archivos `bin/` y `obj/` son generados automáticamente por .NET durante la compilación y ejecución.

---

## 3.4. Archivos del proyecto .NET Core

### Servidor UDP

Proyecto:

```text
dotnet/UdpServer/
```

Archivo principal:

```text
dotnet/UdpServer/Program.cs
```

En este archivo se implementa el servidor UDP que escucha en un puerto determinado.

### Cliente UDP

Proyecto:

```text
dotnet/UdpClient/
```

Archivo principal:

```text
dotnet/UdpClient/Program.cs
```

En este archivo se implementa el cliente UDP que envía un mensaje al servidor.

### Servidor TCP

Proyecto:

```text
dotnet/TcpServer/
```

Archivo principal:

```text
dotnet/TcpServer/Program.cs
```

En este archivo se implementa el servidor TCP que espera una conexión entrante.

### Cliente TCP

Proyecto:

```text
dotnet/TcpClient/
```

Archivo principal:

```text
dotnet/TcpClient/Program.cs
```

En este archivo se implementa el cliente TCP que se conecta al servidor.

---

## 3.5. Ejecución desde Visual Studio Code

Desde la terminal integrada de VS Code, ejecutar primero el servidor y luego el cliente correspondiente.

### Ejecutar servidor UDP

```bash
cd dotnet/UdpServer
dotnet run
```

### Ejecutar cliente UDP

Abrir otra terminal:

```bash
cd dotnet/UdpClient
dotnet run
```

### Ejecutar servidor TCP

```bash
cd dotnet/TcpServer
dotnet run
```

### Ejecutar cliente TCP

Abrir otra terminal:

```bash
cd dotnet/TcpClient
dotnet run
```

---

## 3.6. Compilación en .NET Core

Para compilar sin ejecutar:

```bash
dotnet build
```

Para limpiar archivos generados:

```bash
dotnet clean
```

Para ejecutar una aplicación:

```bash
dotnet run
```

---

# 5. Recomendaciones para trabajar en Visual Studio Code

## 5.1. Abrir siempre la carpeta principal

Se recomienda abrir la carpeta completa del trabajo:

```bash
cd sockets-tp
code .
```

Esto permite ver los proyectos de Python, .NET Core y NodeJS en un único explorador de archivos.

---

## 5.2. Usar terminales separadas

Como los ejemplos cliente-servidor requieren ejecutar más de un programa al mismo tiempo, se recomienda abrir varias terminales integradas:

```text
Terminal > New Terminal
```

Una terminal debe quedar ejecutando el servidor y otra terminal debe ejecutar el cliente.

---

## 5.3. Ejecutar siempre primero el servidor

En todos los ejemplos se debe iniciar primero el servidor.

Orden recomendado:

```text
1. Ejecutar servidor UDP o TCP.
2. Verificar que quedó escuchando.
3. Ejecutar cliente UDP o TCP.
4. Observar mensajes enviados y recibidos.
```

---

## 5.4. Uso de localhost

Para las primeras pruebas se utilizará:

```text
localhost
```

O también:

```text
127.0.0.1
```

Esto significa que cliente y servidor se ejecutan en la misma computadora.

---

## 5.5. Prueba entre dos computadoras

Para probar en una red real, el servidor debe ejecutarse en una computadora y el cliente en otra.

En ese caso, reemplazar:

```text
localhost
```

Por la dirección IP de la computadora donde corre el servidor.

Ejemplo:

```text
192.168.1.25
```

En Windows se puede consultar la IP con:

```bash
ipconfig
```

En Linux o macOS:

```bash
ip addr
```

O:

```bash
ifconfig
```

---

# 6. Puertos utilizados en los ejemplos

Se recomienda usar puertos distintos para evitar conflictos:

```text
UDP: 5005
TCP: 6000
```

Si el puerto está ocupado, se puede cambiar por otro valor, por ejemplo:

```text
UDP: 5010
TCP: 6010
```

Debe recordarse cambiar el puerto tanto en el servidor como en el cliente.

---

# 7. Problemas frecuentes

## 7.1. El cliente no se conecta

Verificar que el servidor esté ejecutándose antes que el cliente.

## 7.2. El puerto está ocupado

Cambiar el puerto o cerrar el proceso que lo está utilizando.

## 7.3. Firewall bloqueando la conexión

En pruebas entre computadoras, el firewall puede bloquear conexiones entrantes. Se debe permitir el acceso de Python, .NET o NodeJS en la red local.

## 7.4. Error con localhost

Probar usando:

```text
127.0.0.1
```

## 7.5. Problemas entre dos computadoras

Verificar:

```text
- Que ambas computadoras estén en la misma red.
- Que se pueda hacer ping entre ellas.
- Que el servidor use IPAddress.Any o 0.0.0.0 cuando corresponda.
- Que el cliente apunte a la IP correcta del servidor.
```

---

# 8. Resumen de librerías por lenguaje

| Lenguaje | Librería / Módulo | Instalación requerida | Uso principal |
|---|---|---|---|
| Python | `socket` | No | TCP y UDP |
| C# .NET Core | `System.Net.Sockets` | No | TCP y UDP |
| NodeJS | `net` | No | TCP |
| NodeJS | `dgram` | No | UDP |
| Python opcional | `python-dotenv` | Sí | Configuración externa |
| .NET opcional | `Microsoft.Extensions.Configuration.Json` | Sí | Configuración con JSON |
| NodeJS opcional | `dotenv` | Sí | Configuración externa |

---

# 9. Comandos principales por tecnología

## Python

```bash
python --version
python archivo.py
```

## .NET Core

```bash
dotnet --version
dotnet new console -n NombreProyecto
dotnet run
dotnet build
dotnet clean
```

## NodeJS

```bash
node --version
npm --version
npm init -y
node archivo.js
```

---

# 10. Cierre

Esta guía permite preparar un entorno de desarrollo común para implementar aplicaciones de sockets en Python, .NET Core y NodeJS. La comparación entre lenguajes permite observar que los conceptos fundamentales de redes —IP, puerto, socket, cliente, servidor, TCP y UDP— se mantienen constantes, aunque cambie la sintaxis y la forma de trabajo de cada plataforma.

El uso de Visual Studio Code facilita una experiencia integrada, permitiendo trabajar con varios lenguajes, ejecutar terminales simultáneas y organizar los proyectos de forma profesional.
Mostrando guia_desarrollo_sockets_vscode.md.
