﻿// --------------------------------------------------------------------------------------------------------------------
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
    [AlternativeName(Name = "animal's sound")]
    public class AlternativeName : Attribute
    {
        /// <summary>
        /// Gets or sets the alternative name.
        /// </summary>
        public string Name { get; set; }
    }
}
