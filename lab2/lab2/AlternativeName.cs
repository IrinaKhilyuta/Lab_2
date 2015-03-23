// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlternativeName.cs" company="ss">
//   ss
// </copyright>
// <summary>
//   Defines the AlternativeName type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Lab2
{
    /// <summary>
    /// The alternative name of class.
    /// </summary>
    public class AlternativeName : Attribute
    {
        public string Name { get; set; }
    }
}
