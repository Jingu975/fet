using desayunos.desayunos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Security.Cryptography;
namespace desayunos
{
    internal class Desayuno { public String Nombre { get; set; } public Double Precio { get; set; } public String Dias { get; set; } public override string ToString() { return $"Desayuno {Nombre}, servido los {Dias} a S/{Precio}."; } public string[] ListaDias() { return Dias.Split(';'); } }
    class Program
    {
        static List<Desayuno> listaDesayunos = new List<Desayuno>(); static void Main() { byte opcion; string regresar; do { Console.WriteLine("Programa de Desayunos\n"); Console.WriteLine("******* MENÚ *******"); Console.WriteLine("* 1. Crear *"); Console.WriteLine("* 2. Lista *"); Console.WriteLine("* 3. Eliminar *"); Console.WriteLine("* 0. Salir *"); Console.WriteLine("********************\n"); Console.Write("Ingrese opción: "); while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3) { Console.Write("Error: Ingrese opción: "); } switch (opcion) { case 0: Environment.Exit(0); break; case 1: CrearDesayuno(); break; case 2: ListarDesayunos(); break; case 3: EliminarDesayuno(); break; } Console.WriteLine("¿Desea regresar al menú? [si]: "); regresar = Console.ReadLine(); Console.Clear(); } while (regresar == "si"); }
        static void CrearDesayuno() { Desayuno desayuno = new Desayuno(); Console.Write("Ingrese el nombre del desayuno: "); desayuno.Nombre = Console.ReadLine(); Console.Write("Ingrese los ingredientes del desayuno: "); desayuno.Ingredientes = Console.ReadLine(); Console.Write("Ingrese el precio del desayuno: "); while (!double.TryParse(Console.ReadLine(), out double precio)) { Console.Write("Error: Ingrese un precio válido: "); } desayuno.Precio = precio; Console.Write("Ingrese los días en que se sirve el desayuno (separados por ';'): "); desayuno.Dias = Console.ReadLine(); listaDesayunos.Add(desayuno); Console.WriteLine("Desayuno creado exitosamente.\n"); }
        static void ListarDesayunos() { Console.WriteLine("Lista de desayunos:"); if (listaDesayunos.Count == 0) { Console.WriteLine("No hay desayunos disponibles.\n"); } else { foreach (var desayuno in listaDesayunos) { Console.WriteLine(desayuno.ToString()); } Console.WriteLine(); } }
        static void EliminarDesayuno() { Console.Write("Ingrese el nombre del desayuno a eliminar: "); string nombre = Console.ReadLine(); Desayuno desayunoAEliminar = listaDesayunos.Find(d => d.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)); if (desayunoAEliminar != null) { listaDesayunos.Remove(desayunoAEliminar); Console.WriteLine("Desayuno eliminado exitosamente.\n"); } else { Console.WriteLine("Desayuno no encontrado.\n"); } }
        para que es el overrride
        El término override en programación orientada a objetos, específicamente en C#, se utiliza para modificar el comportamiento de un método heredado en una clase derivada. En otras palabras, permite proporcionar una nueva implementación de un método que está definido en una clase base.


para que se utiliza el switch en c++
En C++, la estructura de control switch se utiliza para seleccionar una de varias opciones posibles basadas en el valor de una variable o expresión.Es especialmente útil cuando se tienen múltiples condiciones que dependen del valor de una misma variable, permitiendo una organización más clara y eficiente del código en comparación con múltiples sentencias if-else.

Aquí te dejo un ejemplo sencillo de cómo se utiliza switch:

cpp
#include <iostream>

int main() {
            int numero = 2;
            switch (numero)
            {
                case 1:
                    std::cout << "El número es uno." << std::endl;
                    break;
                case 2:
                    std::cout << "El número es dos." << std::endl;
                    break;
                case 3:
                    std::cout << "El número es tres." << std::endl;
                    break;
                default:
                    std::cout << "Número desconocido." << std::endl;
                    break;
            }

            return 0;
        }
        En este ejemplo, la variable numero es evaluada y, dependiendo de su valor, se ejecuta el bloque de código correspondiente.Si numero es 2, se imprime "El número es dos.". La cláusula default es opcional y se ejecuta si ninguna de las condiciones anteriores es satisfecha.

        Espero que esto te sea útil. ¿Hay algo más en lo que pueda asistirte?


        explicame la logica de esto:﻿using desayunos; byte opcion; string regresar; do { Console.WriteLine("Programa de Desayunos\n"); Console.WriteLine("*** MENÚ **"); Console.WriteLine(" 1. Crear "); Console.WriteLine(" 2. Lista "); Console.WriteLine(" 3. Eliminar "); Console.WriteLine(" 0. Salir "); Console.WriteLine("*******\n"); Console.Write("Ingrese opcion: "); while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3) { Console.Write("Error: Ingrese opcion: "); }
switch (opcion) { case 0: Environment.Exit(0); break; case 1: break; case 2: break; case 3: break; }
Console.WriteLine("Desea regresar al menú? [si]: "); regresar = Console.ReadLine(); Console.Clear(); } while (regresar == "si") ;
Claro, te explico la lógica del código:

Librerías y Variables Iniciales:

csharp
using desayunos;

byte opcion;
string regresar;
Se incluyen las librerías necesarias (en este caso, desayunos, aunque no está claro cuál es su contenido). Se declaran dos variables: opcion de tipo byte para almacenar la opción seleccionada por el usuario, y regresar de tipo string para determinar si se debe volver al menú.

Bucle do-while:

csharp
do
{
    // Menú y lectura de opción
} while (regresar == "si") ;
Se utiliza un bucle do-while que permite repetir el menú hasta que el usuario decida no regresar (es decir, mientras regresar sea igual a "si").

Menú y Lectura de Opción:

csharp
Console.WriteLine("Programa de Desayunos\n");
Console.WriteLine("*** MENÚ ***");
Console.WriteLine("* 1. Crear         *");
Console.WriteLine("* 2. Lista         *");
Console.WriteLine("* 3. Eliminar      *");
Console.WriteLine("* 0. Salir         *");
Console.WriteLine("********\n");

Console.Write("Ingrese opcion: ");
Se presenta un menú al usuario con las opciones disponibles: Crear, Lista, Eliminar y Salir. El usuario debe ingresar una opción.

Validación de Entrada:

csharp
while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
{
    Console.Write("Error: Ingrese opcion: ");
}
Se valida la entrada del usuario para asegurarse de que sea un número entre 0 y 3. Si no es así, se solicita nuevamente hasta que se ingrese un valor válido.

Estructura switch:

csharp
switch (opcion)
{
    case 0: Environment.Exit(0); break;  // Salir del programa
    case 1: break;  // Placeholder para la opción "Crear"
case 2: break;  // Placeholder para la opción "Lista"
case 3: break;  // Placeholder para la opción "Eliminar"
}
Dependiendo de la opción ingresada, se ejecuta el caso correspondiente. En el caso 0, se termina el programa con Environment.Exit(0). Los otros casos (1, 2 y 3) están vacíos y pueden ser completados según la funcionalidad deseada (por ejemplo, crear, listar o eliminar desayunos).

Pregunta para Regresar al Menú:

csharp
Console.WriteLine("Desea regresar al menú? [si]: ");
regresar = Console.ReadLine();
Console.Clear();
Se pregunta al usuario si desea regresar al menú. Si el usuario responde "si", el bucle do-while se repetirá, mostrando nuevamente el menú.

Este código es un esqueleto básico para un programa de consola que presenta un menú y permite al usuario seleccionar opciones. Puedes agregar la lógica específica en los case del switch para que el programa realice acciones concretas como crear, listar o eliminar desayunos.

Si tienes alguna otra pregunta o necesitas más detalles, no dudes en decírmelo.

como completarias el switch
Para completar el switch con funcionalidad específica para cada opción (crear, listar, eliminar desayunos), podrías agregar la lógica necesaria en cada caso. Aquí te dejo un ejemplo de cómo podrías hacerlo:

csharp
using desayunos;

byte opcion;
string regresar;

do
{
    Console.WriteLine("Programa de Desayunos\n");
    Console.WriteLine("*** MENÚ ***");
    Console.WriteLine("* 1. Crear         *");
    Console.WriteLine("* 2. Lista         *");
    Console.WriteLine("* 3. Eliminar      *");
    Console.WriteLine("* 0. Salir         *");
    Console.WriteLine("********\n");
    Console.Write("Ingrese opcion: ");

    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {
        Console.Write("Error: Ingrese opcion: ");
    }

    switch (opcion)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            CrearDesayuno();
            break;
        case 2:
            ListarDesayunos();
            break;
        case 3:
            EliminarDesayuno();
            break;
    }

    Console.WriteLine("Desea regresar al menú? [si]: ");
    regresar = Console.ReadLine();
    Console.Clear();

} while (regresar == "si");

// Métodos para las funcionalidades

void CrearDesayuno()
{
    // Lógica para crear un desayuno
    Console.WriteLine("Creando un nuevo desayuno...");
    // Aquí se puede agregar código para solicitar datos y crear el desayuno
}

void ListarDesayunos()
{
    // Lógica para listar los desayunos
    Console.WriteLine("Lista de desayunos:");
    // Aquí se puede agregar código para mostrar la lista de desayunos
}

void EliminarDesayuno()
{
    // Lógica para eliminar un desayuno
    Console.WriteLine("Eliminando un desayuno...");
    // Aquí se puede agregar código para solicitar identificación y eliminar el desayuno
}
En este ejemplo, he creado tres métodos: CrearDesayuno, ListarDesayunos y EliminarDesayuno. Cada uno de estos métodos puede ser completado con la lógica específica necesaria para manejar la creación, listado y eliminación de desayunos. Puedes personalizar estos métodos según las necesidades de tu aplicación.

Si necesitas más detalles o tienes alguna otra pregunta, ¡no dudes en decírmelo!

logica para crear desayuno
Para la lógica de la función CrearDesayuno, puedes pedir al usuario que ingrese los datos necesarios para crear un desayuno y luego almacenar esa información en una estructura adecuada. Aquí hay un ejemplo de cómo podrías implementar esto:

Definir una estructura para almacenar la información del desayuno.

Solicitar al usuario los datos necesarios para crear un desayuno.

Almacenar el nuevo desayuno en una lista.

Aquí tienes una implementación básica en C#:

csharp
using System;
using System.Collections.Generic;

// Definir la estructura del desayuno
public class Desayuno
{
    public string Nombre { get; set; }
    public string Ingredientes { get; set; }
    public decimal Precio { get; set; }
}

class Program
{
    static List<Desayuno> listaDesayunos = new List<Desayuno>();

    static void Main()
    {
        byte opcion;
        string regresar;

        do
        {
            Console.WriteLine("Programa de Desayunos\n");
            Console.WriteLine("*** MENÚ ***");
            Console.WriteLine("* 1. Crear         *");
            Console.WriteLine("* 2. Lista         *");
            Console.WriteLine("* 3. Eliminar      *");
            Console.WriteLine("* 0. Salir         *");
            Console.WriteLine("********\n");
            Console.Write("Ingrese opcion: ");

            while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
            {
                Console.Write("Error: Ingrese opcion: ");
            }

            switch (opcion)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    CrearDesayuno();
                    break;
                case 2:
                    ListarDesayunos();
                    break;
                case 3:
                    EliminarDesayuno();
                    break;
            }

            Console.WriteLine("Desea regresar al menú? [si]: ");
            regresar = Console.ReadLine();
            Console.Clear();

        } while (regresar == "si");
    }

    static void CrearDesayuno()
    {
        Desayuno desayuno = new Desayuno();

        Console.Write("Ingrese el nombre del desayuno: ");
        desayuno.Nombre = Console.ReadLine();

        Console.Write("Ingrese los ingredientes del desayuno: ");
        desayuno.Ingredientes = Console.ReadLine();

        Console.Write("Ingrese el precio del desayuno: ");
        while (!decimal.TryParse(Console.ReadLine(), out decimal precio))
        {
            Console.Write("Error: Ingrese un precio válido: ");
        }
        desayuno.Precio = precio;

        listaDesayunos.Add(desayuno);
        Console.WriteLine("Desayuno creado exitosamente.\n");
    }

    static void ListarDesayunos()
    {
        Console.WriteLine("Lista de desayunos:");
        foreach (var desayuno in listaDesayunos)
        {
            Console.WriteLine($"Nombre: {desayuno.Nombre}, Ingredientes: {desayuno.Ingredientes}, Precio: {desayuno.Precio}");
        }
        Console.WriteLine();
    }

    static void EliminarDesayuno()
    {
        Console.Write("Ingrese el nombre del desayuno a eliminar: ");
        string nombre = Console.ReadLine();

        Desayuno desayunoAEliminar = listaDesayunos.Find(d => d.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (desayunoAEliminar != null)
        {
            listaDesayunos.Remove(desayunoAEliminar);
            Console.WriteLine("Desayuno eliminado exitosamente.\n");
        }
        else
        {
            Console.WriteLine("Desayuno no encontrado.\n");
        }
    }
}
En esta implementación:

La clase Desayuno define la estructura para almacenar la información de cada desayuno.

La función CrearDesayuno solicita al usuario que ingrese el nombre, los ingredientes y el precio del desayuno, y luego agrega el nuevo desayuno a la lista listaDesayunos.

La función ListarDesayunos muestra todos los desayunos en la lista.

La función EliminarDesayuno permite al usuario eliminar un desayuno por su nombre.

Puedes personalizar y ampliar estas funciones según las necesidades de tu aplicación. Si tienes alguna otra pregunta o necesitas más detalles, ¡házmelo saber!

cual seria la logica:namespace desayunos
{
    internal class desayunos { public String Nombre { get; set; } public Double Precio { get; set; } public String Dias { get; set; } public override string ToString() { return $"Desayuno {Nombre}, servido los {Dias} a S/{Precio}."; } public string[] ListaDias() { return Dias.Split(';'); } }
    La lógica de la clase desayunos en el espacio de nombres desayunos se puede explicar de la siguiente manera:

Definición de la Clase:

csharp
namespace desayunos
    {
        internal class desayunos
        {
            // Propiedades y métodos aquí
        }
    }
    La clase desayunos se define dentro del espacio de nombres desayunos.Esto organiza el código y evita conflictos de nombres.
    Propiedades de la Clase:

csharp
    public String Nombre { get; set; }
    public Double Precio { get; set; }
    public String Dias { get; set; }
    La clase tiene tres propiedades: Nombre(nombre del desayuno), Precio(precio del desayuno) y Dias(días en que se sirve el desayuno). Estas propiedades utilizan get y set para permitir la lectura y modificación de sus valores.
    Método ToString:

csharp
    public override string ToString()
    {
        return $"Desayuno {Nombre}, servido los {Dias} a S/{Precio}.";
    }
    Este método sobreescribe el método ToString de la clase base Object.Se utiliza para proporcionar una representación en forma de cadena de la instancia de desayunos, describiendo el nombre, los días y el precio del desayuno.
    Método ListaDias:

csharp
    public string[] ListaDias()
    {
        return Dias.Split(';');
    }
    Este método convierte la cadena Dias, que contiene los días separados por puntos y comas(;), en un arreglo de cadenas.Cada elemento del arreglo representa un día en que se sirve el desayuno.Esto es útil para manejar y procesar los días de manera individual.
    Aquí está la clase completa con estas explicaciones integradas:


    csharp
namespace desayunos
    {
        internal class desayunos
        {
            public String Nombre { get; set; }
            public Double Precio { get; set; }
            public String Dias { get; set; }
            public override string ToString()
            {
                return $"Desayuno {Nombre}, servido los {Dias} a S/{Precio}.";
            }

            public string[] ListaDias()
            {
                return Dias.Split(';');
            }
        }
    }
    Esta clase encapsula la información relevante de un desayuno, permitiendo crear instancias con nombre, precio y días de servicio, y proporciona métodos para representar esta información de manera útil.

    Si necesitas más detalles o alguna otra explicación, ¡dímelo!


    que es split?
    En programación, el método Split es utilizado para dividir una cadena de texto en un arreglo de subcadenas, utilizando un delimitador específico. Es una forma práctica de descomponer una cadena en partes más manejables.


    Por ejemplo, en C#, si tienes una cadena que contiene días de la semana separados por comas, puedes usar Split para obtener cada día como un elemento separado en un arreglo:

csharp
    string dias = "Lunes;Martes;Miércoles;Jueves;Viernes";
    string[] listaDias = dias.Split(';');
    Después de ejecutar este código, listaDias será un arreglo de cadenas que contiene: "Lunes", "Martes", "Miércoles", "Jueves" y "Viernes".

Este método es muy útil cuando necesitas procesar elementos individuales a partir de una cadena más larga, como en el caso de los días en los que se sirve un desayuno.

Si tienes alguna otra duda o necesitas más detalles, ¡estoy aquí para ayudarte!


















































