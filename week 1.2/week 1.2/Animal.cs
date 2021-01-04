using System;
using System.Collections.Generic;
using System.Text;

namespace MyNamespace2
{
    class Animal: Attribute
    {
        private string naam;
        private string soort;



        public Animal(string naam, string soort)
        {
            this.naam = naam;
            this.soort = soort;
        }

        public string Getname() { return naam + " " + soort; }

        //public override string ToString() { return naam(); }


    }
}
