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
        int n = arreglo.Length;

        // i va desde 0 hasta n-1
        for (int i = 0; i < n - 1; i++)
        {
            // j va desde 0 hasta n-i-1
            for (int j = 0; j < n - i - 1; j++)
            {
                // Si el elemento actual es mayor al siguiente
                if (arreglo[j] > arreglo[j + 1])
                {
                    // Intercambio (Swap)
                    int temporal = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temporal;
                }
            }
        }
    }
}


    }
}
