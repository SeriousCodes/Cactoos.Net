﻿
using System.IO;

namespace Cactoos.IO
{
    /// <summary>
    /// Input with null check.
    /// </summary>
    public class NotNullInput : IInput
    {
        readonly IInput _source;

        /// <summary>
        /// Initializes a new instance of <see cref="NotNullInput"/>.
        /// </summary>
        /// <param name="source">The input.</param>
        public NotNullInput(IInput source)
        {
            _source = source;
        }

        /// <summary>
        /// Get stream value.
        /// </summary>
        /// <returns>The stream.</returns>
        public Stream Stream()
        {
            return (_source ?? throw new System.Exception("NULL instead of a valid input")).Stream();
        }
    }
}
