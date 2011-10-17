namespace prep.infrastructure.filtering
{
    public abstract class BinaryMatch<ItemToMatch> : IMatchA<ItemToMatch>
    {
        protected IMatchA<ItemToMatch> left_side;
        protected IMatchA<ItemToMatch> right_side;

        protected BinaryMatch(IMatchA<ItemToMatch> left_side, IMatchA<ItemToMatch> right_side)
        {
            this.left_side = left_side;
            this.right_side = right_side;
        }

        public abstract bool matches(ItemToMatch item);
    }
}