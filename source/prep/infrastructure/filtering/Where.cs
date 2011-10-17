namespace prep.infrastructure.filtering
{
    public class Where<ItemToFilter>
    {
        public static PropertyAccessor<ItemToFilter,PropertyType> has_a<PropertyType>(PropertyAccessor<ItemToFilter,PropertyType> accessor)
        {
            return accessor;
        }
    }

    public static class AccessorExtensions
    {
        public static IMatchA<ItemToMatch> equal_to<ItemToMatch,PropertyType>(this PropertyAccessor<ItemToMatch,PropertyType> accessor, PropertyType value)
        {
            return new AnonymousMatch<ItemToMatch>(x => accessor(x).Equals(value));
        }
    }
}