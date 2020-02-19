using System.Collections.Generic;
using System.Linq;

namespace ParksService.Helpers
{
    public static class ListExtensions
    {
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
	    {
			return enumerable == null || !enumerable.Any();
	    }
    }
}
