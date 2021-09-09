using System;
using System.Collections.Generic;
using System.Text;

namespace ioetSolutionMarceloRomero
{
    class Person
    {
        private string name;
        
        // Week Hours refers to the three Schedules in the Week 
        
        private int firstWeekHours = 0;
        private int secondWeekHours = 0;
        private int thirdWeekHours = 0;
        
        // Weekend Hours refers to the three Schedules in the Weekend

        private int firstWeekendHours = 0;
        private int secondWeekendHours = 0;
        private int thirdWeekendHours = 0;

        public void SetName(string nameRecibed)
        {
            this.name = nameRecibed;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetHoursWorked(char day, int morningHours, int noonHours, int nightHours)
        {
            if (day == 'W')
            {
                this.firstWeekHours += morningHours;
                this.secondWeekHours += noonHours;
                this.thirdWeekHours += nightHours;
            }
            else
            {
                this.firstWeekendHours += morningHours;
                this.secondWeekendHours += noonHours;
                this.thirdWeekendHours += nightHours;
            }
        }

        public int SalaryToPay()
        {
            int salary = (25 * firstWeekHours) + (15 * secondWeekHours) + (20 * thirdWeekHours) + (30 * firstWeekendHours) + (20 * secondWeekendHours) + (25 * thirdWeekendHours);

            return salary;
        }
    }
}

