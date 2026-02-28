using System;
using System.Linq; // Necesario para Enumerable y ToArray()

public class Algoritmo
{
    public int[] GenerarNumeros(int n)
    {
        // Semilla fija (42) garantiza que todos los alumnos ordenen la misma secuencia
        Random r = new Random(42);
        return Enumerable.Range(0, n).Select(_ => r.Next(0, 50000)).ToArray();
    }

    public bool EstaOrdenado(int[] arr)
    {
        if (arr == null || arr.Length == 0) return true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Si el actual es mayor al siguiente, no está ordenado
            if (arr[i] > arr[i + 1]) return false;
        }
        return true;
    }

    public void BubbleSort(int[] arr)
    {
        // TODO: Implementar el algoritmo de Bubble Sort tradicional




    }
}
