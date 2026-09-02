using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_Programm1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            toDoManager toDoManager = new toDoManager();
            Task task = new Task();

            while (true)
            {

                Console.WriteLine("Hier kannst du die nächste Aufgabe notieren\n" +
                                  "[1] Aufgabe hinzufügen\n"
                                + "[2] Aufgabe entfernen\n" +
                                  "[3] Aufgaben anzeigen"
                                 );

                int auswahl = Convert.ToInt32(Console.ReadLine());
                switch (auswahl)
                {
                    case 1:
                        toDoManager.AddTask();
                        break;
                    case 2:
                        toDoManager.RemoveTask();
                        break;
                    case 3:
                        toDoManager.DisplayTasks();
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wähle eine gültige Option.");
                        break;

                }


            }

        }

        class toDoManager
        {
            private List<Task> tasks;
            private Task task;
            public toDoManager()
            {
                tasks = new List<Task>();
                task = new Task();
            }
            public void AddTask()
            {
                
                bool repeat = false;


                    try
                    {
                        Console.WriteLine("Gib bitte die Aufgabenbeschreibung ein");
                        string description = Console.ReadLine();
                        task.Description = description;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Fehler beim Hinzufügen der Aufgabe: {ex.Message}");
                    }               

                    Console.WriteLine("Gib bitte noch an, ob die Aufgabe abgeschlossen\n"                     
                                      + "Für abgeschlossen [True]\n" 
                                      + "Für nicht abgeschlossen [False]"
                                    );
                    try
                    {
                        bool isCompleted = Convert.ToBoolean(Console.ReadLine());
                        task.IsCompleted = isCompleted;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib 'True' oder 'False' ein.");
                        return;
                    }                

                    tasks.Add(task);

            }
            public void RemoveTask()
            {



            }
            public void DisplayTasks()
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"Aufgabe: {task.Description}, Abgeschlossen: {task.IsCompleted}");
                }

            }
        }

        class Task
        {
            public string Description { get; set; }
            public bool IsCompleted { get; set; }


            public Task()
            {
               
            }
            public void MarkAsCompleted()
            {
                IsCompleted = true;
                Console.WriteLine($"Task '{Description}' marked as completed.");
            }
        }
    }
}





