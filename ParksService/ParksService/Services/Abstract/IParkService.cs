﻿using System;
using System.Collections.Generic;
using ParksService.Models;

namespace ParksService.Services.Abstract
{
	public interface IParkService
	{
		Park GetParkById(Guid id);
		IEnumerable<Park> GetAll();
		IEnumerable<Park> GetParksByFullState(string state);
		IEnumerable<Park> GetParksByState(string state);
		IEnumerable<Park> GetParksByDesignation(string designation);
		IEnumerable<Park> RepopulateParksList(IEnumerable<Park> data);
		void WriteParks(IEnumerable<Park> data);
	}
}