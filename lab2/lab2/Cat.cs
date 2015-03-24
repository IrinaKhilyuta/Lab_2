// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cat.cs" company="ll">
//   ll
// </copyright>
// <summary>
//   The cat.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab2
{
    /// <summary>
    /// The cat.
    /// </summary>
    [AlternativeName(Name = "meow")]
    public class Cat : ACat
    {
        /// <summary>
        /// sleep or awake
        /// </summary>
        public bool IsSleeping { get; set; }
    }
}
