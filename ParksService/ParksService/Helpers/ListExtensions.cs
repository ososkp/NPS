using System.Collections.Generic;
using System.Linq;

namespace ParksService.Helpers
{
    public static class ListExtensions
    {/// <summary>
	 /// Checks if an IEnumerable is null or empty
	 /// </summary>
	 /// <typeparam name="T"></typeparam>
	 /// <param name="enumerable"></param>
	 /// <returns>Boolean</returns>
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
	    {
		    switch (enumerable)
		    {
			    case null:
				    return true;
			    case ICollection<T> collection:
				    return collection.Count < 1;
		    }

		    return !enumerable.Any();
	    }
    }
}
