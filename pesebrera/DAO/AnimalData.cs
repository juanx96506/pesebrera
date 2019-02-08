using pesebrera.Business;
using pesebrera.Persistence;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace pesebrera.DAO
{
    public class AnimalData
    {
        private string allAnimalsFilePath;
        private string equinesFilePath;
        private string bovinesFilePath;

        public AnimalData()
        {
            allAnimalsFilePath = Path.Combine(
                System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data"), 
                "EQUINOSBOVINOS.DAT"
                );
            equinesFilePath = Path.Combine(
                System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data"),
                "EQUINOS.DAT"
                );
            bovinesFilePath = Path.Combine(
                System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data"),
                "BOVINOS.DAT"
                );
        }

        public IEnumerable<IAnimal> GetAllAnimals()
        {
            FileManager animalsFile = new FileManager(allAnimalsFilePath);
            string [] animalNames = animalsFile.ReadFile();

            List<IAnimal> animals = new List<IAnimal>();
            foreach (string name in animalNames)
            {
                IAnimal newAnimal = new Animal(name);
                animals.Add(newAnimal);
            }
            return animals;
        }
        public void SaveEquines(IEnumerable<IAnimal> equines)
        {
            FileManager equinesFile = new FileManager(equinesFilePath);
            string[] equinesText = equines.Select(x => x.Name).ToArray();
            equinesFile.WriteFile(equinesText);
        }
        public void SaveBovines(IEnumerable<IAnimal> bovines)
        {
            FileManager bovinesFile = new FileManager(bovinesFilePath);
            string[] bovinesText = bovines.Select(x => x.Name).ToArray();
            bovinesFile.WriteFile(bovinesText);
        }
    }
}