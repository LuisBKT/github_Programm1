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

            while (true)
            {

                Console.WriteLine("Hier kannst du die nächste Aufgabe notieren\n" +
                                  "[1] Aufgabe hinzufügen"
                              + "\n[2] Aufgabe entfernen" +
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
            public toDoManager()
            {
                tasks = new List<Task>();
            }
            public void AddTask()
            {



            }
            public void RemoveTask()
            {



            }
            public void DisplayTasks()
            {



            }
        }

        class Task
        {
            public string Description { get; set; }
            public bool IsCompleted { get; set; }


            public Task(string description)
            {
                Description = description;
                IsCompleted = false;
            }
            public void MarkAsCompleted()
            {
                IsCompleted = true;
                Console.WriteLine($"Task '{Description}' marked as completed.");
            }
        }
    }
}





