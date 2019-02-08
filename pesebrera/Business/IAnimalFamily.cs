using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pesebrera.Business
{
    public interface IAnimalFamily
    {
        string Name { get; }
        bool IsFromThisFamily(IAnimal animal);
    }
}