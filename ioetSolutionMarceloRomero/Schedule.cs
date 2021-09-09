using System;
using System.Collections.Generic;
using System.Text;

namespace ioetSolutionMarceloRomero
{
    class Schedule
    {
        private string[] daysWeek = new string[] { "MO", "TU", "WE", "TH", "FR" };
        private string[] daysWeekend = new string[] { "SA", "SU" };

        public bool SeparateSchedule(string[] schedule, Person worker)
        {
            int count = 0;
            bool flag = false;
            while (count < schedule.Length - 1 && !flag)
            {
                string day = schedule[count].Substring(0, 2);
                string hours = schedule[count].Substring(2);
                string[] date = hours.Split('-');
                string[] startHourSeparated = date[0].Split(':');
                string[] endHourSeparated = date[1].Split(':');

                int hoursCounter = HoursCounter(Int32.Parse(startHourSeparated[0]), Int32.Parse(startHourSeparated[1]), Int32.Parse(endHourSeparated[0]), Int32.Parse(endHourSeparated[1]));
                if (hoursCounter != 0)
                {
                    int[] hourDivided = HoursSplitter(Int32.Parse(startHourSeparated[0]), hoursCounter);
                    worker.SetHoursWorked(IdentifyDay(day), hourDivided[0], hourDivided[1], hourDivided[2]);
                }
                else
                {
                    flag = true;
                }
                count++;
            }

            return flag;

        }

        public bool DayRestriction(string day)
        {
            bool flag = true;
            if (Array.IndexOf(daysWeek, day) == -1 && Array.IndexOf(daysWeekend, day) == -1)
            {
                Console.WriteLine("El día ingresado no es válido");
                flag = false;
            }

            return flag;
        }

        public char IdentifyDay(string day)
        {
            char dayCompare = 'E'; // E means Error
            if (DayRestriction(day))
            {
                dayCompare = 'N'; // N means that it isn't a Day of Week
                for (int i = 0; i < 5; i++)
                {
                    if (day == daysWeek[i])
                    {
                        dayCompare = 'W'; // Means that is a day of Week
                    }
                }
            }
            return (dayCompare);
        }

        public bool HourControl(int hour, int minute)
        {
            bool flag = false;

            if (hour > 24 || hour < 0)
            {
                Console.WriteLine("The hour can not be more than 23 hours");
            }
            else if (minute > 60 || minute < 0)
            {
                Console.WriteLine("The minute can not be more than 59 minutes");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public bool HourException(int startHour, int startMinute, int endHour, int endMinute)
        {
            bool flag = false;

            if (HourControl(startHour, startMinute) && HourControl(endHour, endMinute))
            {
                if (startHour > endHour)
                {
                    Console.WriteLine("The start hour can not be greater than the end hour");
                }
                else if ((endHour == startHour) && startMinute >= endMinute)
                {
                    Console.WriteLine("The start minutes can not be the same or greater that the end minutes");
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }

        public int HoursCounter(int startHour, int startMinute, int endHour, int endMinute)
        {
            int finalHour = 0;
            if (endHour == 0 && endMinute == 0)
            {
                endHour = 24;
            }
            if (HourException(startHour, startMinute, endHour, endMinute))
            {
                if (endMinute < startMinute)
                {
                    finalHour = endHour - startHour - 1;
                }
                else
                {
                    finalHour = endHour - startHour;
                }
            }

            return finalHour;
        }


        public int[] HoursSplitter(int startHour, int hourCounter)
        {
            int[] scheduleSplitter = new int[] { 0, 0, 0 };
            while (hourCounter > 0)
            {
                if (startHour >= 0 && startHour <= 9)
                {
                    scheduleSplitter[0] += 1;
                }
                else if (startHour > 9 && startHour < 18)
                {
                    scheduleSplitter[1] += 1;
                }
                else
                {
                    scheduleSplitter[2] += 1;
                }
                startHour++;
                hourCounter--;
            }
            return scheduleSplitter;
        }



    }

}
