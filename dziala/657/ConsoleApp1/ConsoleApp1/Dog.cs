using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public struct Dog
    {
        public string Name;
        public string Breed;

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
        public void Speak()
        {
            Console.WriteLine("Wabię się {0}. Moja rasa to {1}.", Name, Breed);
        }
    }
}
