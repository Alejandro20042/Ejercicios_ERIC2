    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Ejercicios_ERIC2
    {
        internal class Ejercicios
        {
            class Program
            {
                static int[] LeerArreglo(string mensaje)
                {
                    Console.WriteLine(mensaje);
                    return Console.ReadLine().Split().Select(int.Parse).ToArray();
                }

                static int LeerNumero(string mensaje)
                {
                    Console.WriteLine(mensaje);
                    return Convert.ToInt32(Console.ReadLine());
                }

                static int[] SumarArreglos(int[] arreglo1, int[] arreglo2)
                {
                    int[] resultado = new int[arreglo1.Length];
                    for (int i = 0; i < arreglo1.Length; i++)
                    {
                        resultado[i] = arreglo1[i] + arreglo2[i];
                    }
                    return resultado;
                }

                static void MostrarArreglos(int[] arreglo1, int[] arreglo2, int[] resultado)
                {
                    for (int i = 0; i < arreglo1.Length; i++)
                    {
                        Console.WriteLine($"{arreglo1[i]} + {arreglo2[i]} = {resultado[i]}");
                    }
                }

                static int[] BuscarElemento(int[] arreglo, int elemento)
                {
                    var posiciones = Enumerable.Range(0, arreglo.Length).Where(i => arreglo[i] == elemento).ToArray();
                    return posiciones;
                }

                static void MostrarPosiciones(int[] posiciones)
                {
                    if (posiciones.Length > 0)
                    {
                        Console.WriteLine("El elemento se encuentra en las posiciones:");
                        foreach (var posicion in posiciones)
                        {
                            Console.Write(posicion + " ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El elemento no se encuentra en el arreglo.");
                    }
                }

                static int[] LeerIDs(string mensaje)
                {
                    int[] ids = LeerArreglo(mensaje);
                    return ids;
                }

                static int[] EncontrarAlumnosComunes(int[] algebra, int[] analisis)
                {
                    return algebra.Intersect(analisis).ToArray();
                }

                static int[] LeerArregloNumericoSinRepetir(int tamaño)
                {
                    int[] arreglo = new int[tamaño];
                    Console.WriteLine("Ingrese valores numéricos sin repetir:");
                    for (int i = 0; i < tamaño; i++)
                    {
                        int valor = LeerNumero($"Ingrese el valor {i + 1}:");
                        while (arreglo.Contains(valor))
                        {
                            Console.WriteLine("Este valor ya ha sido ingresado. Intente de nuevo.");
                            valor = LeerNumero($"Ingrese el valor {i + 1}:");
                        }
                        arreglo[i] = valor;
                    }
                    return arreglo;
                }

                static void MostrarArreglo(string mensaje, int[] arreglo)
                {
                    Console.WriteLine(mensaje);
                    foreach (var elemento in arreglo)
                    {
                        Console.Write(elemento + " ");
                    }
                    Console.WriteLine();
                }

                static void EstadisticasNotas(int[] notas)
                {
                    int aprobadas = 0;
                    int desaprobadas = 0;
                    int sumaAprobadas = 0;
                    int sumaDesaprobadas = 0;

                    foreach (var nota in notas)
                    {
                        if (nota >= 0 && nota <= 5)
                        {
                            desaprobadas++;
                            sumaDesaprobadas += nota;
                        }
                        else if (nota >= 6 && nota <= 10)
                        {
                            aprobadas++;
                            sumaAprobadas += nota;
                        }
                    }

                    double promedioAprobadas = aprobadas > 0 ? (double)sumaAprobadas / aprobadas : 0;
                    double promedioDesaprobadas = desaprobadas > 0 ? (double)sumaDesaprobadas / desaprobadas : 0;

                    Console.WriteLine($"Notas aprobadas: {aprobadas}");
                    Console.WriteLine($"Promedio de notas aprobadas: {promedioAprobadas:F2}");
                    Console.WriteLine($"Notas desaprobadas: {desaprobadas}");
                    Console.WriteLine($"Promedio de notas desaprobadas: {promedioDesaprobadas:F2}");
                }
            }

        }
    }


