namespace TaskApp
{
    public class TaskManager
    {
     List<Task> tasks = new();

        public void ShowTasks(List<Task> tasks)
        {
            if (tasks.Count > 0)
            {
                Console.WriteLine("\nLista de tareas:");
                foreach (var task in tasks)
                {
                    Console.WriteLine($"{task.Id}: {task.Description} - {task.Priority} - {task.LimitDate.ToShortDateString()} - {(task.IsComplete ? "Completada" : "Pendiente")}");
                }
            }
            else
            {
                Console.WriteLine("\nAún no hay ninguna tarea.");
            }
        }

        public void AddTask(List<Task> tasks)
        {
            Console.WriteLine("Ingrese descripción de la tarea:");
            string description = Console.ReadLine()!;

            Console.WriteLine("Ingrese prioridad (Low, Medium, High):");
            string priorityInput = Console.ReadLine()!;
            if (!Enum.TryParse(priorityInput, true, out Priority priority))
            {
                Console.WriteLine("Prioridad no válida. Intente nuevamente.");
                return;
            }

            Console.WriteLine("Ingrese fecha límite (YYYY-MM-DD):");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime limitDate))
            {
                Console.WriteLine("Fecha no válida. Intente nuevamente.");
                return;
            }

            string id = Guid.NewGuid().ToString();
            var newTask = new Task(id, description, priority, limitDate);

            tasks.Add(newTask);
            Console.WriteLine("Tarea agregada exitosamente.");
        }

        public void MarkTaskComplete(List<Task> tasks)
        {
            Console.WriteLine("Ingrese el ID de la tarea a marcar como completada:");
            string id = Console.ReadLine()!;

            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsComplete = true;
                Console.WriteLine("Tarea marcada como completada.");
            }
            else
            {
                Console.WriteLine("Tarea no encontrada.");
            }
        }
    }
}