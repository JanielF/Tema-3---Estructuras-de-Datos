using static Practica3.Program;

Cliente Cliente1 = new Cliente("Daniel Ramirez Flores ", 154321354, "Alma Rosa", "DanielRamirezFlores@gmail.com", true);
Console.WriteLine(Cliente1.nombre);
Console.WriteLine(Cliente1.telefono);
Console.WriteLine(Cliente1.direccion);
Console.WriteLine(Cliente1.correo);
Console.WriteLine(Cliente1.clienteN);
Console.WriteLine(Cliente1);


namespace Practica3
{
    class Program { 

        public struct Cliente
        {
            public Cliente(string nombreCompleto, long Telefono, string Direccion, string Correo, bool Nuevo)
            {

                nombre = nombreCompleto;
                telefono = Telefono;
                direccion = Direccion;
                correo = Correo;
                clienteN = Nuevo;

                
            }

            public string nombre { get; }
            public long telefono { get; }
            public string direccion { get; }
            public string correo { get; }
            public bool clienteN { get; }

            public override string ToString() => $"({nombre}, {telefono} , {direccion} , {correo} , {clienteN})";
            
        }
    }
} 