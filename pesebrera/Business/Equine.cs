using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pesebrera.Business
{
    public class Equine : IAnimalFamily
    {
        public string Name { get => "Equino"; }

        public bool IsFromThisFamily(IAnimal animal)
        {
            bool isEquino = true;
            return isEquino;
        }
    }
}