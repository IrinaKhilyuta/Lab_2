// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="f">
//   f
// </copyright>
// <summary>
//   The unit test 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1CatDog
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The unit test 1.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Find types in assembly
        /// </summary>
        [TestMethod]
        public void TestMethodTypesInAssembly()
        {
            var types = typeof(Cat).Assembly.GetTypes();
        }

        /// <summary>
        /// Find list of public properties
        /// </summary>
        [TestMethod]
        public void TestMethodListOfProps()
        {
            foreach (var type in typeof(Cat).Assembly.GetTypes())
            {
                var properties = type.GetProperties();
            }
        }

        /// <summary>
        /// Find all classes implements an interface
        /// </summary>
        [TestMethod]
        public void TestMethodInterfaceImplemensClasses()
        {
            var interfaceClassType = typeof(IDog);
            var classesList = new List<object> { new Cat(), new Dog(), new CatDog() };
            var answerList = new List<object>();
            foreach (var tempObject in classesList)
            {
                var typeInterfase = tempObject.GetType().GetInterfaces().FirstOrDefault(x => x == interfaceClassType);
                if (typeInterfase != null)
                {
                    answerList.Add(typeInterfase);
                }
            }
        }

        /// <summary>
        /// Find all classes inherits the abstract class
        /// </summary>
        [TestMethod]
        public void TestMethodInheritsOfAbstractClass()
        {
            var abstractClassType = typeof(ACat);
            var classesList = new List<object> { new Cat(), new Dog(), new CatDog() };
            var answerList = new List<object>();
            foreach (var tempObject in classesList)
            {
                var baseType = tempObject.GetType().BaseType;
                if (baseType != null && baseType.Name == abstractClassType.Name)
                {
                    answerList.Add(tempObject);
                }
            }
        }
    }
}
