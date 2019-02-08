using pesebrera.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pesebrera.Business
{
    public class AnimalClassifier
    {
        private IAnimalFamily[] _families;

        public AnimalClassifier()
        {
            _families = new IAnimalFamily[] 
            {
                new Equine(),
                new Bovine()
            };
        }
        public IEnumerable<IAnimal> ExecuteClassification()
        {
            AnimalData animalData = new AnimalData();
            IEnumerable<IAnimal> animals = animalData.GetAllAnimals();
            List<IAnimal> equines = new List<IAnimal>();
            List<IAnimal> bovines = new List<IAnimal>();

            foreach (IAnimal animal in animals)
            {
                ClassifyAnimal(animal);
                if(animal.Family is Equine)
                {
                    equines.Add(animal);
                }
                if (animal.Family is Bovine)
                {
                    bovines.Add(animal);
                }
            }
            animalData.SaveEquines(equines);
            animalData.SaveBovines(bovines);

            return animals;
        }
        private void ClassifyAnimal(IAnimal animal)
        {
            for(int i = 0; i < _families.Length; i++)
            {
                if (_families[i].IsFromThisFamily(animal))
                {
                    animal.Family = _families[i];
                    i = _families.Length;
                }
            }
        }
    }
}