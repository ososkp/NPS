using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParksService.Models;

namespace ParksService.Helpers
{
    public static class ParkServiceHelper
    {
		private const int STATE_CODE_LENGTH = 2;
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
		    {"TN", "Tennessee" },
		    {"TX", "Texas" },
			{"UT", "Utah" },
		    {"VA", "Virginia" },
		    {"VT", "Vermont" },
		    {"WA", "Washington" },
		    {"WI", "Wisconsin" },
		    {"WV", "West Virgina" },
		    {"WY", "Wyoming" },
		    {"DC", "Washington, D.C." },
		    {"VI", "U.S. Virgin Islands" },
		    {"MP", "Northern Mariana Islands" },
		    {"AS", "American Samoa" },
		    {"PR", "Puerto Rico" },
		    {"GU", "Guam" }
	    };

	    public static Address MapAddress(Park data)
	    {
		    if (data.Addresses.Count > 0)
			    return data.Addresses[0];

		    return new Address
		    {
			    City = "Nowhere",
			    Line1 = "123 Placeholder Street",
			    Line2 = "",
			    Line3 = "",
			    StateCode = "DC",
			    PostalCode = "00000",
			    Type = "Filler"
		    };
	    }

		public static string GetFullState(string state)
		{
			return state.Length > STATE_CODE_LENGTH
				? ParseMultipleStates(state)
				: FullState[state];
		}

	    public static IDictionary<string, string> GetStateDictionary()
	    {
			return FullState;
	    }

	    private static string ParseMultipleStates(string state)
	    {
		    var states = state.Split(",").ToList();
		    var sb = new StringBuilder();

		    states.ForEach(code => sb.Append(FullState[code] + ", "));
		    return sb.ToString().RemoveLastCharacter(0, 2);
	    }
    }
}
