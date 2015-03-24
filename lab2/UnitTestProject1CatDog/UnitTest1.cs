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
            var sb = new StringBuilder();
            var types = typeof(Cat).Assembly.GetTypes();
            sb.Append(Environment.NewLine);
            foreach (var type in types)
            {
                sb.Append(type.Name + Environment.NewLine);
            }

            Assert.Fail(sb.ToString());
        }

        /// <summary>
        /// Find list of public properties
        /// </summary>
        [TestMethod]
        public void TestMethodListOfProps()
        {
            var sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            foreach (var type in typeof(Cat).Assembly.GetTypes())
            {
                var properties = type.GetProperties();
                sb.Append(Environment.NewLine + type.Name + Environment.NewLine);
                foreach (var propertyInfo in properties)
                {
                    sb.Append(propertyInfo.Name + Environment.NewLine);
                }
            }

            Assert.Fail(sb.ToString());
        }

        /// <summary>
        /// Find all classes implements an interface
        /// </summary>
        [TestMethod]
        public void TestMethodInterfaceImplemensClasses()
        {
            var sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            var interfaceClassType = typeof(IDog);
            var classesList = new List<object> { new Cat(), new Dog(), new CatDog() };
            foreach (var tempObject in classesList)
            {
                var typeInterfase = tempObject.GetType().GetInterfaces().FirstOrDefault(x => x == interfaceClassType);
                if (typeInterfase != null)
                {
                    sb.Append(tempObject.GetType().Name + " ");
                }
            }

            Assert.Fail(sb.ToString());
        }

        /// <summary>
        /// Find all classes inherits the abstract class
        /// </summary>
        [TestMethod]
        public void TestMethodInheritsOfAbstractClass()
        {
            var sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            var abstractClassType = typeof(ACat);
            var classesList = new List<object> { new Cat(), new Dog(), new CatDog() };
            foreach (var tempObject in classesList)
            {
                var baseType = tempObject.GetType().BaseType;
                if (baseType != null && baseType.Name == abstractClassType.Name)
                {
                    sb.Append(tempObject.GetType().Name + " ");
                }
            }

            Assert.Fail(sb.ToString());
        }
    }
}
