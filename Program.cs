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
            Console.WriteLine("Ingrese la posición del elemento que desea eliminar (0 a {0}):", listaNumeros.Count - 1);
            int posicionAEliminar = Convert.ToInt32(Console.ReadLine());
            if (posicionAEliminar >= 0 && posicionAEliminar < listaNumeros.Count)
            {
                listaNumeros.RemoveAt(posicionAEliminar);
                Console.WriteLine("Elemento eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Posición no válida.");
            }
            break;
        case 3:
            Console.WriteLine("Ingrese el número que desea buscar en la lista:");
            int numeroABuscarLista = Convert.ToInt32(Console.ReadLine());
            int indice = listaNumeros.IndexOf(numeroABuscarLista);
            if (indice != -1)
            {
                Console.WriteLine("El número {0} se encuentra en el índice {1}", numeroABuscarLista, indice);
            }
            else
            {
                Console.WriteLine("El número {0} no se encuentra en la lista", numeroABuscarLista);
            }
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

//Crear una lista de números desordenados y ordenarlos con bubble sort
List<int> listaDesordenada = new List<int> { 34, 12, 56, 78, 23, 45, 67, 89, 10 };
Console.WriteLine("Lista desordenada:");
foreach (int numero in listaDesordenada)
{
    Console.WriteLine(numero);
}

//Ordenar la lista con bubble sort
for (int i = 0; i < listaDesordenada.Count - 1; i++)
{
    for (int j = 0; j < listaDesordenada.Count - i - 1; j++)
    {
        if (listaDesordenada[j] > listaDesordenada[j + 1])
        {
            // Intercambiar
            int temp = listaDesordenada[j];
            listaDesordenada[j] = listaDesordenada[j + 1];
            listaDesordenada[j + 1] = temp;
        }
    }
}

//Mostrar la lista ordenada
Console.WriteLine("Lista ordenada:");
foreach (int numero in listaDesordenada)
{
    Console.WriteLine(numero);
}

//Crear una nueva lista de números desordenados y ordenarlos con selection sort
List<int> listaDesordenada2 = new List<int> { 34, 12, 56, 78, 23, 45, 67, 89, 10 };
Console.WriteLine("Lista desordenada 2:");
foreach (int numero in listaDesordenada2)
{
    Console.WriteLine(numero);
}

//Ordenar y mostrar la lista con selection sort
for (int i = 0; i < listaDesordenada2.Count - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < listaDesordenada2.Count; j++)
    {
        if (listaDesordenada2[j] < listaDesordenada2[minIndex])
        {
            minIndex = j;
        }
    }
    // Intercambiar
    int temp = listaDesordenada2[minIndex];
    listaDesordenada2[minIndex] = listaDesordenada2[i];
    listaDesordenada2[i] = temp;
}
Console.WriteLine("Lista ordenada 2:");
foreach (int numero in listaDesordenada2)
{
    Console.WriteLine(numero);
}