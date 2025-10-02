using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какие у тебя дела?");
            List<string> taskList = new List<string>();
            string opptions = "";

            while (opptions != "e")
            {
                Console.WriteLine("Что ты хочешь сделать?");
                Console.WriteLine("Нажми 1 что бы добавить задачу");
                Console.WriteLine("Нажми 2 что бы удалить задачу");
                Console.WriteLine("Нажми 3 что бы посмотреть список задач");
                Console.WriteLine("Нажми е что бы выйти из программы");

                opptions = Console.ReadLine();

                if (opptions == "1")
                {
                    Console.WriteLine("Напиши задачу для добавления");
                    String task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Задача добавлена");

                }
                else if (opptions == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }
                    Console.WriteLine("Введите номер для удаления задачи");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);

                }
                else if (opptions == "3")
                {
                    Console.WriteLine("Задачи в списке");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine((taskList[i]));
                    }
                }
                else if (opptions == "e")
                {
                    Console.WriteLine("Выход из программы");
                }
                else
                {
                    Console.WriteLine("Зачем ты это делаешь?");


                }
            }

        }
    }
}

