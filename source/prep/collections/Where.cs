namespace prep.collections
{
    public class Where<ItemToFilter>
    {
        public delegate ProductionStudio ProductionStudioAccessor(Movie movie);

        public static ProductionStudioAccessor has_a(ProductionStudioAccessor accessor)
        {
            return accessor;
        }
    }
}