namespace prep.infrastructure.filtering
{
    public class NegatingMatcher<ItemToMatch> : IMatchA<ItemToMatch>
    {
        IMatchA<ItemToMatch> original;

        public NegatingMatcher(IMatchA<ItemToMatch> original)
        {
            this.original = original;
        }

        public bool matches(ItemToMatch item)
        {
            return ! original.matches(item);
        }
    }
}