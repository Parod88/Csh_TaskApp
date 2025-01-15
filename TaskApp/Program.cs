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
            string filePath = "tasks.txt";
            FileTaskStorage taskStorage = new FileTaskStorage(filePath);

            List<Task> tasks = taskStorage.LoadTasks();
            bool exit = false;

             while (!exit)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Guardar y Salir");

            Console.WriteLine("Seleccione una opción:");
            string option = Console.ReadLine()!;

            switch (option)
            {
                case "1":
                    taskManager.ShowTasks(tasks);
                    break;
                case "2":
                    taskManager.AddTask(tasks);
                    break;
                case "3":
                    taskManager.MarkTaskComplete(tasks);
                    break;
                case "4":
                    taskStorage.SaveTasks(tasks);
                    Console.WriteLine("Tareas guardadas. Saliendo del programa...");
                    exit = true;
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
        }

        
    }
}
