using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Human human = new Human();
            Console.WriteLine(human);
            Console.WriteLine(human.ToString());
            Console.WriteLine(human.genre);
            Console.WriteLine(human.nationality);
            Console.WriteLine(human.Name); //поле: чтение
            human.Name = "Вася";           //поле: запись
            Console.WriteLine(human.Name); 
            Console.WriteLine(human.getName());*/

            try
            {
                //класс абстрактный - нет возможности создать его экземпляр
                //Human human = new Human("Марко", "Поло", "Иммануилович", new DateTime(1775, 10, 25), Genre.MALE, Nationality.English);
                //Employee employee = new Employee();
                //Console.WriteLine(employee);

                /*Tutor tutor = new Tutor();
                Console.WriteLine(tutor);
                tutor.Show();

                Tutor tutor_two = new Tutor("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English, 
                                        EducationLevel.Higher, 3500f, TutorSpeciality.Biologist);

                Console.WriteLine(tutor_two);


                Worker worker = new Worker("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English,
                                        EducationLevel.Higher, 3500f, "Колоть дрова");

                if (!worker.IsWorking)
                {
                    worker.NextTask("Выпить кофе");
                }
                worker.StopWorking();
                worker.NextTask("Покурить");
                Console.WriteLine(worker.Work());
                worker.StopWorking();
                worker.NextTask("Колоть дрова");
                Console.WriteLine(worker.Work());

                
                Manager manager = new Manager();
                manager.addWorker(worker);
                */

                ListOfWorkers listOfWorkers = new ListOfWorkers();
                for (int i = 0; i < 25; i++)
                {
                    listOfWorkers.AddWorker(
                        new Worker (
                            "worker_" + i,
                            "tested",
                            "tested",
                            DateTime.Now,
                            Genre.UNDEFINED,
                            Nationality.Argentine,
                            EducationLevel.Higher,
                            1555f,
                            "что-то делает и слава богу")
                    );
                }

                /*for (int i = listOfWorkers.Count - 1; i >= 0; i--)
                {
                    listOfWorkers.RemoveWorker(listOfWorkers.Workers[i]);
                }*/

                //for (int i = 0; i < 25; i++)
                //{
                //    listOfWorkers.RemoveWorker(listOfWorkers.Workers[0]);
                //}

                for (int i = 0; i < listOfWorkers.Count; i++)
                {
                    Console.WriteLine(listOfWorkers.GetWorker(i));
                }

                Console.WriteLine("end.");
                Console.ReadKey();

               // Console.WriteLine(listOfWorkers);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Я ошибка, но программа не вылетела :)");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            Console.WriteLine("Я программа и я все одно работаю :)");
        }
    }
}
