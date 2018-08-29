using System;

namespace ParksService.Helpers
{
    public static class StringExtensions
    {/// <summary>
	/// Removes last X characters from a string.
	/// </summary>
	/// <param name="input"></param>
	/// <param name="startIndex"></param>
	/// <param name="amountToRemove"></param>
	/// <returns></returns>
	    public static string RemoveLastCharacter(this string input, int startIndex, int amountToRemove)
	    {
		    if (string.IsNullOrWhiteSpace(input))
		    {
			    throw new ArgumentException(nameof(input));
		    }

		    if (amountToRemove > input.Length)
		    {
			    throw new ArgumentOutOfRangeException(nameof(amountToRemove));
		    }

		    return input.Substring(startIndex, input.Length - amountToRemove);
	    }
    }
}
