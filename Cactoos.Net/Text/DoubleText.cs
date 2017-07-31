﻿using Cactoos.Scalar;

namespace Cactoos.Text
{
    public class DoubleText : IText
    {
        private IScalar<double> _source;

        public DoubleText(IScalar<double> source)
        {
            _source = source;
        }

        public DoubleText(double source) : this(new ValueScalar<double>(source))
        {

        }

        public string String()
        {
            return _source.Value().ToString();
        }
    }
}
