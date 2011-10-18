using System;

namespace prep.infrastructure.filtering
{
    public class ComparableCriteriaFactory<ItemToFilter, PropertyType> where PropertyType : IComparable<PropertyType>
    {
        Func<ItemToFilter, PropertyType> accessor;

        private readonly CriteriaFactory<ItemToFilter, PropertyType> criteriaFactory; 

        public ComparableCriteriaFactory(Func<ItemToFilter, PropertyType> accessor)
        {
            this.accessor = accessor;
            criteriaFactory = new CriteriaFactory<ItemToFilter, PropertyType>(accessor);
        }

        public IMatchA<ItemToFilter> greater_than(PropertyType value)
        {
            return new AnonymousMatch<ItemToFilter>(x => accessor(x).CompareTo(value) > 0);
        }

        public IMatchA<ItemToFilter> equal_to(PropertyType value)
        {
            return criteriaFactory.equal_to(value);
        } 

        public IMatchA<ItemToFilter> equal_to_any(params PropertyType[] values)
        {
            return criteriaFactory.equal_to_any(values);
        } 

        public IMatchA<ItemToFilter> not_equal_to(PropertyType value)
        {
            return criteriaFactory.not_equal_to(value);
        } 
    }
}