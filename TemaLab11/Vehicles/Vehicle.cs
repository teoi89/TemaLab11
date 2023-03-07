using System;
using System.Collections.Generic;
using System.Text;

namespace TemaLab11
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int Id { get; set; }
        public Vehicle(string model, int id)
        {
            Model = model;
            Id = id;
        }
        public void GetDescription()
        {
            Console.WriteLine($"This is a {Model} vehicle with ID {Id}.");
        }
    }
}
