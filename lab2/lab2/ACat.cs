// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ACat.cs" company=";lk">
//   sdf
// </copyright>
// <summary>
//   Defines the ACat type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab2
{
    /// <summary>
    /// The abstract class cat.
    /// </summary>
    [AlternativeName(Name = "imeow")]
    public abstract class ACat
    {
        /// <summary>
        /// Gets or sets a value indicating whether meowing.
        /// </summary>
        public bool Meowing { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether scratching.
        /// </summary>
        public bool Scratching { get; set; }
    }
}
