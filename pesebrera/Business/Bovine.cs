using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pesebrera.Business
{
    public class Bovine : IAnimalFamily
    {
        public string Name { get => "Bovino"; }

        public bool IsFromThisFamily(IAnimal animal)
        {
            bool isBovino = false;
            if (animal.Name.StartsWith("b"))
            {
                isBovino = true;
            }
            return isBovino;
        }
    }
}