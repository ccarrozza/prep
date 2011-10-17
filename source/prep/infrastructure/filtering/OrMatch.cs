namespace prep.infrastructure.filtering
{
    public class OrMatch<ItemToMatch> : BinaryMatch<ItemToMatch>
    {
        public OrMatch(IMatchA<ItemToMatch> left_side, IMatchA<ItemToMatch> right_side) : base(left_side, right_side)
        {
        }

        public override bool matches(ItemToMatch item)
        {
            return left_side.matches(item) || right_side.matches(item);
        }
    }
}