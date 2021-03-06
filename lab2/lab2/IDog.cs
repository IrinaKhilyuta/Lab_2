﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDog.cs" company="lkj">
//   lkj
// </copyright>
// <summary>
//   Defines the IDog type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab2
{
    /// <summary>
    /// The Dog interface.
    /// </summary>
    [AlternativeName(Name = "iwof")]
    public interface IDog
    {
        /// <summary>
        /// Gets or sets a value indicating whether wofing.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Wofing();
    }
}
