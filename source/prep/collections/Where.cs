namespace prep.collections
{
    public class Where<ItemToFilter>
    {
        public static ProductionStudioAccessor has_a(ProductionStudioAccessor accessor)
        {
            return accessor;
        }
    }

    public delegate ProductionStudio ProductionStudioAccessor(Movie movie);
}