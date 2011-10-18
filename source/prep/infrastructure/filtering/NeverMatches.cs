namespace prep.infrastructure.filtering
{
    public class NeverMatches<ItemToMatch> : IMatchA<ItemToMatch>
    {
        public bool matches(ItemToMatch item)
        {
            return false;
        }
    }
}