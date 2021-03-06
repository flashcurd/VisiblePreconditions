﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace VisiblePreconditions.Framework.Tests
{
    [TestFixture]
    public class PreconditionTests
    {
        [Test]
        public void Precondition_TypeCastsAndEvaluatesCorrectly()
        {
            Precondition<int, ConditionTests.AlwaysSucceedsValidator> precondition = 5;

            Assert.AreEqual(5, precondition.Value);
        }

        [Test]
        public void Precondition_UsableOnDelegates()
        {
            Func<Precondition<int, ConditionTests.AlwaysSucceedsValidator>, Precondition<int, ConditionTests.AlwaysSucceedsValidator>, int> func =
                (x, y) => x.Value + y.Value;

            Assert.AreEqual(11, func(5, 6));
        }
    }
}
