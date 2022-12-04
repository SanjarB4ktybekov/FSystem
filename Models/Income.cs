using System;
using System.Collections.Generic;

namespace FSystem.Models
{
    public class Income
    {
        public int IncomeId { get; set; }
        public int Sum { get; set; }
        public string Source { get; set; }
        public DateTime DateOfOperation { get; set; }
    }
}