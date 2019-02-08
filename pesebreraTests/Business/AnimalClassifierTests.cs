using Microsoft.VisualStudio.TestTools.UnitTesting;
using pesebrera.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesebrera.Business.Tests
{
    [TestClass()]
    public class AnimalClassifierTests
    {
        [TestMethod()]
        public void ExecuteClassificationTest()
        {
            AnimalClassifier classifier = new AnimalClassifier();
            IAnimal[] animals = classifier.ExecuteClassification();
            Assert.IsNotNull(animals);
            int numberOfBovines = animals.Where(x => x.Family is Bovine).Count();
            Assert.AreEqual(numberOfBovines, 4);
        }
    }
}