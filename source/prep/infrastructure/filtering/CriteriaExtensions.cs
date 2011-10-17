namespace prep.infrastructure.filtering
{
    public static class CriteriaExtensions
    {
        public static IMatchA<ItemToMatch> or<ItemToMatch>(this IMatchA<ItemToMatch> left, IMatchA<ItemToMatch> right)
        {
            return new OrMatch<ItemToMatch>(left, right);
        }
    }
}