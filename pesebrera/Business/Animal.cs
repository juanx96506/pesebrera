using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pesebrera.Business
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public IAnimalFamily Family { get; set; }

        public Animal(string insertedName)
        {
            if (string.IsNullOrEmpty(insertedName))
            {
                throw new ArgumentException("Invalid Name", "insertedName");
            }
            Name = insertedName;
        }
    }
}