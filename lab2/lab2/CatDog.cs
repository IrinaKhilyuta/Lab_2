// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CatDog.cs" company="j">
//   k
// </copyright>
// <summary>
//   The catdog.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab2
{
    /// <summary>
    /// The catdog.
    /// </summary>
    [AlternativeName(Name = "wofmeow")]
    public class CatDog : ACat, IDog
    {
        /// <summary>
        /// Gets or sets a value indicating whether tension.
        /// </summary>
        public bool Tension { get; set; }

        /// <summary>
        /// The wofing.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Wofing()
        {
            return false;
        }
    }
}
