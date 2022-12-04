using System;
using System.Collections.Generic;

namespace FSystem.Models
{
    public class Account
    {
        public int AccountId{get;set;}

        public string Name{get;set;}
        public Schedule Schedule{get;set;}
        public Coach Coach{get;set;}
        public List<Player> Players{get;set;}
        public Income Income{get;set;}
        public Consumption Consumption {get;set;}
    }
}