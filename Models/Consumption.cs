using System;
using System.Collections.Generic;

namespace FSystem.Models
{
    public class Consumption
    {
        public int ConsumptionId { get; set; }
        public int Sum { get; set; }
        public string Reason { get; set; }
        public DateTime DateOfOperation { get; set; }
    }
}