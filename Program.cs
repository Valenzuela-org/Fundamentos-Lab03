//Crear un arreglo que almacene 10 números enteros
int[] numeros = {12, 34, 56, 78, 90, 23, 45, 67, 89, 10};

//Recorrer el arreglo con un ciclo for y mostrar los números en la consola
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//Solicitar al usuario que ingrese un número para el tercer elemento del arreglo
Console.WriteLine("Ingrese un número para el tercer elemento del arreglo:");
numeros[2] = Convert.ToInt32(Console.ReadLine());

//Mostrar el valor del tercer elemento del arreglo después de la modificación
Console.WriteLine("El valor del tercer elemento del arreglo es: " + numeros[2]);

//Mostrar el arreglo completo después de la modificación
Console.WriteLine("El arreglo completo después de la modificación es:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//Solicitar al usuario un número para buscar en el arreglo
Console.WriteLine("Ingrese un número para buscar en el arreglo:");
int numeroABuscar = Convert.ToInt32(Console.ReadLine());

//Buscar el número en el arreglo
bool encontrado = false;
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == numeroABuscar)
    {
        Console.WriteLine("El número {0} se encuentra en el índice {1}", numeroABuscar, i);
        encontrado = true;
        break;
    }
}

if (!encontrado)
{
    Console.WriteLine("El número {0} no se encuentra en el arreglo", numeroABuscar);
}

//Crear una matriz de 3x3
int[,] matriz = new int[3, 3];

//Solicitar al usuario que ingrese los valores para la matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Ingrese el valor para la posición [{0},{1}]:", i, j);
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

//Recorrer la matriz y mostrar sus valores en la consola
Console.WriteLine("Los valores de la matriz son:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

//Crear una variable para almacenar la suma de los elementos de la matriz
int suma = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        suma += matriz[i, j];
    }
}
Console.WriteLine("La suma de los elementos de la matriz es: " + suma);

//Crear una lista dinámica de números enteros
List<int> listaNumeros = new List<int>();

//Crear un menú de opciones que se repita hasta que el usuario decida salir
int opcion;
do
{
    Console.WriteLine("Menú de opciones:");
    Console.WriteLine("1. Insertar elemento");
    Console.WriteLine("2. Eliminar por posición");
    Console.WriteLine("3. Buscar elemento");
    Console.WriteLine("4. Mostrar lista");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());
    
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese un número para insertar en la lista:");
            int numeroAInsertar = Convert.ToInt32(Console.ReadLine());
            listaNumeros.Add(numeroAInsertar);
            Console.WriteLine("Número insertado correctamente.");
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            Console.WriteLine("Los elementos de la lista son:");
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
            break;
        case 5:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            break;
    }
} while (opcion != 5);