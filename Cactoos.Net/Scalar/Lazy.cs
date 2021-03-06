﻿using System;

namespace Cactoos.Scalar
{
    public class LazyScalar<T> : IScalar<T>
    {
        private Lazy<T> _lazy;

        public LazyScalar(Func<T> value)
        {
            _lazy = new Lazy<T>(value);
        }

        public T Value()
        {
            return _lazy.Value;
        }
    }
}
