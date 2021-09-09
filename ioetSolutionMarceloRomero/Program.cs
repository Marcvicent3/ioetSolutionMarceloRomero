using System;
using System.IO;

namespace ioetSolutionMarceloRomero
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            ConnectionFile fileRecibed = new ConnectionFile();
            Schedule scheduleRecibed = new Schedule();
            StreamReader file = fileRecibed.ReadFile();

            while ((line = file.ReadLine()) != null)
            {
                Person worker = new Person();
                string[] name = line.Split("=");
                worker.SetName(name[0]);
                string[] schedule = name[1].Split(',');
                if (!scheduleRecibed.SeparateSchedule(schedule, worker))
                {
                    Console.WriteLine("The amount to pay " + worker.GetName() + " is: " + worker.SalaryToPay() + " USD");

                }

            }

            fileRecibed.CloseFile(file);
            // Suspend the screen.  
            Console.ReadLine();

        }
    }
}
