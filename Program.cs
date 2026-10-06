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

