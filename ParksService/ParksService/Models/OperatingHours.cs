using System.Collections.Generic;

namespace ParksService.Models
{
    public class OperatingHours
    {
		public string Name { get; set; }
		public string Description { get; set; }
		public WeeklyHours StandardHours { get; set; }
		public List<HoursExceptions> Exceptions { get; set; }
	}
}
