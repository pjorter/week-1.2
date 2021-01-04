using System;
using System.Collections.Generic;
using System.Text;
using MyNamespace2;

namespace MyNamespace
{
    class Person
    {
        private List<Animal> pets;


        private string firstname;
        private string lastname;
        private int age;
        private Animal newanimal;

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public string Getname() { return firstname + " " + lastname; }

        public int Getage() { return age; }

        public List<Animal> GetPet() { return pets; }

        public override string ToString() { return Getname(); }

        public List<Animal> AddPet() { pets.Add(newanimal); }

        //public List<Animal> AddPet() { return pets.Add(public Animal); }


    }
}
