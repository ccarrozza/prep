namespace prep.infrastructure.filtering
{
    public interface IMatchA<Item>
    {
        bool matches(Item item);
    }
}