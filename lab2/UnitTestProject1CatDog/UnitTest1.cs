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
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

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
            var sbAnswer = new StringBuilder();
            sbAnswer.Append("ACat");
            sbAnswer.Append("AlternativeName");
            sbAnswer.Append("Cat");
            sbAnswer.Append("IDog");
            sbAnswer.Append("CatDog");
            sbAnswer.Append("Dog");
            sbAnswer.Append("Program");

            var sb = new StringBuilder();
            var types = typeof(Cat).Assembly.GetTypes();
            foreach (var type in types)
            {
                sb.Append(type.Name);
            }

            Assert.AreEqual(sbAnswer.ToString(), sb.ToString());
        }

        /// <summary>
        /// Find list of public properties
        /// </summary>
        [TestMethod]
        public void TestMethodListOfProps()
        {
            var sbAnswer = new StringBuilder();
            sbAnswer.Append("Meowing");
            sbAnswer.Append("Scratching");
            sbAnswer.Append("Name");
            sbAnswer.Append("TypeId");
            sbAnswer.Append("IsSleeping");
            sbAnswer.Append("Meowing");
            sbAnswer.Append("Scratching");
            sbAnswer.Append("Tension");
            sbAnswer.Append("Meowing");
            sbAnswer.Append("Scratching");
            sbAnswer.Append("IsSleeping");
            var sb = new StringBuilder();
            foreach (var type in typeof(Cat).Assembly.GetTypes())
            {
                var properties = type.GetProperties();
                foreach (var propertyInfo in properties)
                {
                    sb.Append(propertyInfo.Name);
                }
            }

            Assert.AreEqual(sbAnswer.ToString(), sb.ToString());
        }

        /// <summary>
        /// Find all classes implements an interface
        /// </summary>
        [TestMethod]
        public void TestMethodInterfaceImplemensClasses()
        {
            var sbAnswer = new StringBuilder();
            sbAnswer.Append("Dog");
            sbAnswer.Append("CatDog");

            var sb = new StringBuilder();
            var interfaceClassType = typeof(IDog);
            var classesList = new List<object> { new Cat(), new Dog(), new CatDog() };
            foreach (var tempObject in classesList)
            {
                var typeInterfase = tempObject.GetType().GetInterface(interfaceClassType.Name);
                if (typeInterfase != null)
                {
                    sb.Append(tempObject.GetType().Name);
                }
            }
            Assert.AreEqual(sbAnswer.ToString(), sb.ToString());
        }

        /// <summary>
        /// Find all classes inherits the abstract class
        /// </summary>
        [TestMethod]
        public void TestMethodInheritsOfAbstractClass()
        {
            var sbAnswer = new StringBuilder();
            sbAnswer.Append("Cat");
            sbAnswer.Append("CatDog");

            var sb = new StringBuilder();
            var abstractClassType = typeof(ACat);
            var classesList = new List<object> { new Cat(), new Dog(), new CatDog() };
            foreach (var tempObject in classesList)
            {
                var baseType = tempObject.GetType().BaseType;
                if (baseType != null && baseType.Name == abstractClassType.Name)
                {
                    sb.Append(tempObject.GetType().Name);
                }
            }

            Assert.AreEqual(sbAnswer.ToString(), sb.ToString());
        }

        /// <summary>
        /// The test method create object by the attribute.
        /// </summary>
        [TestMethod]
        public void TestMethodCreateObject()
        {
            var answer = "CatDog";
            var tempAnswer = string.Empty;
            const string AttributeName = "wofmeow";
            var types = typeof(Cat).Assembly.GetTypes();
            foreach (var type in types)
            {
                var alternativeName = (AlternativeName)type.GetCustomAttribute(typeof(AlternativeName));
                if (alternativeName != null && alternativeName.Name == AttributeName)
                    {
                        var newInstance = Activator.CreateInstance(type);
                        tempAnswer = newInstance.GetType().Name;
                    Assert.IsNotNull(newInstance);
                    }
            }
            Assert.AreEqual(answer, tempAnswer);
        }
    }
}
