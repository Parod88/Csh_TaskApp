using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskApp;

namespace TaskApp
{
    class Program
    {
        static  void Main(string[] args)
        {

            TaskManager taskManager = new TaskManager();
             while (true)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Salir");

            Console.WriteLine("Seleccione una opción:");
            string option = Console.ReadLine()!;

            switch (option)
            {
                case "1":
                    taskManager.ShowTasks();
                    break;
                case "2":
                    taskManager.AddTask();
                    break;
                case "3":
                    taskManager.MarkTaskComplete();
                    break;
                case "4":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
        }

        
    }
}
