using System;

namespace prep.infrastructure.filtering
{
    public class Where<ItemToFilter>
    {
        public static CriteriaFactory<ItemToFilter, PropertyType> has_a<PropertyType>(Func<ItemToFilter, PropertyType> accessor)
        {
            return new CriteriaFactory<ItemToFilter, PropertyType>(accessor);
        }
    }
}