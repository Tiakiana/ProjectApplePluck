using System;

namespace ProjectFruit
{
    internal class Work
    {
        private int harvested { get; set; }
        private int workedHours { get; set; }
        private DateTime workDay { get; set; }
        public Work(int harvested, int workedHours, DateTime workDay)
        {
            this.harvested = harvested;
            this.workedHours = workedHours;
            this.workDay = workDay;
        }
    }
}