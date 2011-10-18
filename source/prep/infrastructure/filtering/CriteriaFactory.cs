using System;
using System.Collections.Generic;

namespace prep.infrastructure.filtering
{
    public class CriteriaFactory<ItemToFilter, PropertyType> : ICreateMatchers<ItemToFilter, PropertyType>
    {
        Func<ItemToFilter, PropertyType> accessor;

        public CriteriaFactory(Func<ItemToFilter, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public IMatchA<ItemToFilter> equal_to(PropertyType value)
        {
            return equal_to_any(value);
        }

        public IMatchA<ItemToFilter> equal_to_any(params PropertyType[] values)
        {
            return new AnonymousMatch<ItemToFilter>(x => new List<PropertyType>(values).Contains(accessor(x)));
        }

        public IMatchA<ItemToFilter> not_equal_to(PropertyType value)
        {
            return equal_to(value).not();
        }
    }
}