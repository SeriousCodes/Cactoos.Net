﻿using System.Globalization;

namespace Cactoos.Scalar
{
    public struct ParsedDouble : IScalar<double>
    {
        private IScalar<string> _source;

        public ParsedDouble(IScalar<string> source)
        {
            _source = source;
        }

        public ParsedDouble(string source) : this(new ValueScalar<string>(source))
        {
            
        }

        public double Value()
        {
            string v = _source.Value();
            return double.Parse(v, CultureInfo.InvariantCulture);
        }
    }
}
