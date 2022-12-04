using System;
using System.Collections.Generic;

namespace FSystem.Models
{
    public class Schedule
    {
        public int ScheduleId{get;set;}
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
    }
}