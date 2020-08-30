using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_7._2
{
    class Program
    {
        static void Sort(Train[] trains)
        {
            Train z = new Train();
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length - 1; j++)
                {
                    if (trains[j].NumTrain > trains[j + 1].NumTrain)
                    {
                        z = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = z;
                    }
                }
            }
        }
        static Train Search(Train[] trains, uint num)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (num == trains[i].NumTrain)
                {
                    return trains[i];
                }
            }
            Train notTrain = new Train() { NameDest = "" };
            return notTrain;
        }
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            trains[0].NameDest = "Львов-Харьков"; trains[0].NumTrain = 123; trains[0].TimeDep = 12.23;
            trains[1].NameDest = "Харьков-Львов"; trains[1].NumTrain = 321; trains[1].TimeDep = 21.18;
            trains[2].NameDest = "Одесса-Киев"; trains[2].NumTrain = 234; trains[2].TimeDep = 05.20;
            trains[3].NameDest = "Киев-Одесса"; trains[3].NumTrain = 432; trains[3].TimeDep = 23.47;
            trains[4].NameDest = "Черкассы-Луцк"; trains[4].NumTrain = 345; trains[4].TimeDep = 01.34;
            trains[5].NameDest = "Луцк-Черкассы"; trains[5].NumTrain = 543; trains[5].TimeDep = 08.55;
            trains[6].NameDest = "Киев-Днепр"; trains[6].NumTrain = 456; trains[6].TimeDep = 07.45;
            trains[7].NameDest = "Днепр-Киев"; trains[7].NumTrain = 654; trains[7].TimeDep = 14.15;
            Sort(trains);
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Номер поезда : {trains[i].NumTrain}, {trains[i].NameDest}," +
                    $" время отправления : {trains[i].TimeDep}");
            }

            Train newTrain = new Train();
            Console.Write("Введите номер поезда : ");
            uint num = uint.Parse(Console.ReadLine());
            newTrain = Search(trains, num);
            if (newTrain.NameDest != "")
            {
                Console.WriteLine($"Номер поезда : {newTrain.NumTrain}, {newTrain.NameDest}," +
                    $" время отправления : {newTrain.TimeDep}");
            }
            else
                Console.WriteLine("Поезда с таким номером нет.");

            Console.ReadKey();
        }
    }
}
