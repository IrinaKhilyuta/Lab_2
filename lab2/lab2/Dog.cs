// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dog.cs" company="gg">
//   ll
// </copyright>
// <summary>
//   The dog.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Lab2
{
    /// <summary>
    /// The dog.
    /// </summary>
    [AlternativeName(Name = "wof")]
    public class Dog : IDog
    {
        /// <summary>
        /// sleep or awake
        /// </summary>
        public bool IsSleeping { get; set; }
        
        /// <summary>
        /// The wofing.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool Wofing()
        {
            return true;
        }
    }
}
