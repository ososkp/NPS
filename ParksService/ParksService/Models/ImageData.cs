using System;

namespace ParksService.Models
{
    public class ImageData
    {
		public string Credit { get; set; }
		public string AltText { get; set; }
		public string Title { get; set; }
		public Guid Id { get; set; }
		public string Caption { get; set; }
		public string Url { get; set; }
	}
}
