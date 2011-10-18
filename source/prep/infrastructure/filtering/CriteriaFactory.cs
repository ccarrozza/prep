using System;

namespace prep.infrastructure.filtering
{
    public class CriteriaFactory<ItemToFilter, PropertyType>
    {
        Func<ItemToFilter, PropertyType> accessor;

        public CriteriaFactory(Func<ItemToFilter, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public IMatchA<ItemToFilter> equal_to(PropertyType value)
        {
            return new AnonymousMatch<ItemToFilter>(x => accessor(x).Equals(value));
        }

        public IMatchA<ItemToFilter> equal_to_any(params PropertyType[] values)
        {
           return new AnonymousMatch<ItemToFilter>(x =>
              {
                  foreach (var value in values)
                  {
                      if (accessor(x).Equals(value)) return true;
                  }
                  return false;
              }             
            );
        }
    }
}