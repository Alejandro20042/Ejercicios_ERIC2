namespace Ejercicios_ERIC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                // Ejercicio 1
                int[] arreglo1 = LeerArreglo("Ingrese valores para el primer arreglo:");
                int[] arreglo2 = LeerArreglo("Ingrese valores para el segundo arreglo:");
                int[] resultado = SumarArreglos(arreglo1, arreglo2);
                MostrarArreglos(arreglo1, arreglo2, resultado);

                // Ejercicio 2
                int[] arregloParaBuscar = LeerArreglo("Ingrese valores para el arreglo:");
                int elementoABuscar = LeerNumero("Ingrese el elemento que desea buscar:");
                int[] posiciones = BuscarElemento(arregloParaBuscar, elementoABuscar);
                MostrarPosiciones(posiciones);

                // Ejercicio 3
                int[] algebra = LeerIDs("Ingrese IDs de alumnos para Álgebra:");
                int[] analisis = LeerIDs("Ingrese IDs de alumnos para Análisis:");
                int[] alumnosComunes = EncontrarAlumnosComunes(algebra, analisis);
                MostrarArreglo("Alumnos inscritos en ambas asignaturas:", alumnosComunes);

                // Ejercicio 4
                int tamañoArreglo = LeerNumero("Ingrese el tamaño del arreglo:");
                int[] arregloNumerico = LeerArregloNumericoSinRepetir(tamañoArreglo);
                MostrarArreglo("Contenido del arreglo:", arregloNumerico);

                // Ejercicio 5
                int[] notas = LeerArreglo("Ingrese las notas separadas por espacio:");
                EstadisticasNotas(notas);
            
        }
    }
}