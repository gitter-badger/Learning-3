using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Learning
{
    public class DecisionVariable<TSample, TValue>
    {
        public DecisionVariable(Expression<Func<TSample, TValue>> property, params TValue[] rangeValues)
        {
            Property = property;
            Range = new List<TValue>(rangeValues);
        }

        public Expression<Func<TSample, TValue>> Property { get; }

        public IList<TValue> Range { get; }
    }
}