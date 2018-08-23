using System;
using System.Collections.Generic;

namespace ParksService.Helpers
{
    public static class ParkServiceHelper
    {
	    private static readonly IDictionary<string, string> FullState = new Dictionary<string, string>()
	    {
		    {"AK", "Alaska" },
		    {"AL", "Alabama" },
		    {"AR", "Arkansas" },
		    {"AZ", "Arizona" },
		    {"CA", "California" },
		    {"CO", "Colorado" },
		    {"CT", "Connecticut" },
		    {"DE", "Delaware" },
		    {"FL", "Florida" },
		    {"GA", "Georgia" },
		    {"HI", "Hawaii" },
			{"IA", "Iowa" },
		    {"ID", "Idaho" },
		    {"IL", "Illinois" },
		    {"IN", "Indiana" },
		    {"KS", "Kansas" },
		    {"KY", "Kentucky" },
		    {"LA", "Louisiana" },
			{"MA", "Massachusetts" },
		    {"MD", "Maryland" },
		    {"ME", "Maine" },
		    {"MI", "Michigan" },
		    {"MN", "Minnesota" },
		    {"MO", "Missouri" },
		    {"MS", "Mississippi" },
		    {"MT", "Montana" },
		    {"NC", "North Carolina" },
		    {"ND", "North Dakota" },
		    {"NE", "Nebraska" },
		    {"NH", "New Hampshire" },
		    {"NJ", "New Jersey" },
			{"NM", "New Mexico" },
		    {"NV", "Nevada" },
			{"NY", "New York" },
		    {"OH", "Ohio" },
		    {"OK", "Oklahoma" },
		    {"OR", "Oregon" },
			{"PA", "Pennsylvania" },
		    {"RI", "Rhode Island" },
		    {"SC", "South Carolina" },
		    {"SD", "South Dakota" },
		    {"TE", "Tennessee" },
		    {"TX", "Texas" },
			{"UT", "Utah" },
		    {"VA", "Virginia" },
		    {"VT", "Vermont" },
		    {"WA", "Washington" },
		    {"WI", "Wisconsin" },
		    {"WV", "West Virgina" },
		    {"WY", "Wyoming" },
		    {"DC", "Washington, D.C." },
		    {"WI,MN", "Wisconsin, Minnesota" },
		    {"VI", "U.S. Virgin Islands" }
	    };

		public static string ParseLatitude(string coordinates)
		{
			var index = coordinates.IndexOf(",", StringComparison.Ordinal);

			return coordinates.Substring(4, index - 4);
		}

		public static string ParseLongitude(string coordinates)
		{
			var index = coordinates.IndexOf("g", StringComparison.Ordinal) + 1;
			return coordinates.Substring(index + 1, coordinates.Length - index - 1);
		}

		public static string GetFullState(string state)
		{
			return FullState[state];
		}

	    public static IDictionary<string, string> GetStateDictionary()
	    {
			return FullState;
	    }
	}
}
