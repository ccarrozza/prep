namespace prep.infrastructure.filtering
{
    public delegate PropertyType PropertyAccessor<in ItemToTarget, out PropertyType>(ItemToTarget movie);
}