using System.Collections.Generic;

namespace prep.infrastructure
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
        {
            foreach (var item in items) yield return item;
        }

        public static IEnumerable<ItemToMatch> all_items_matching<ItemToMatch >(this IEnumerable<ItemToMatch> items, Condition<ItemToMatch> condition)
        {
            foreach (var item_to_match in items) if(condition(item_to_match)) yield return item_to_match;
        }
    }
}