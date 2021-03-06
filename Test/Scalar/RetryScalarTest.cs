﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cactoos.Scalar;

using static System.Functional.Func;

namespace Test.Scalar
{
    [TestClass]
    public class RetryScalarTest
    {
        [TestMethod]
        public void should_retry()
        {
            int i = 0;
            var scalar =
                new Retry<Unit>(
                    new FuncOf<Unit>(
                        fun(() =>
                        {
                            if (i < 2)
                            {
                                i++;
                                throw new NotFiniteNumberException(i.ToString());
                            }
                        })),
                    3);
            scalar.Value();
            Assert.AreEqual(2, scalar.Errors().Length);
        }

        [TestMethod]
        public void should_fail()
        {
            int i = 0;
            var scalar =
                new Retry<Unit>(
                    new FuncOf<Unit>(
                        fun(() =>
                        {
                            throw new NotFiniteNumberException(i.ToString());
                        })),
                    1);
            Assert.ThrowsException<NotFiniteNumberException>(() => scalar.Value());
        }
    }
}
