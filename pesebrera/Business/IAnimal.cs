using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesebrera.Business
{
    public interface IAnimal
    {
        string Name { get; set; }
        IAnimalFamily Family { get; set; }
    }
}
