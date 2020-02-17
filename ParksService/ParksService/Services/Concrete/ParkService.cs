using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using ParksService.Data.Abstract;
using ParksService.Helpers;
using ParksService.Models;
using ParksService.Services.Abstract;

namespace ParksService.Services.Concrete
{
    public class ParkService : ServiceBase, IParkService
    {
        public ParkService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Park> GetAll()
        {
            return _unitOfWork.ParkRepository.GetAll();
        }

        public Park GetParkById(Guid id)
        {
            return _unitOfWork.ParkRepository.Find(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Park> GetParksByFullState(string state)
        {
            var fullStateDictionary = ParkServiceHelper
                .GetStateDictionary()
                .ToDictionary(kp => kp.Value, kp => kp.Key);

            return _unitOfWork.ParkRepository.Find(p => p.States == fullStateDictionary[state]);
        }

        public IEnumerable<Park> GetParksByState(string state)
        {
            return _unitOfWork.ParkRepository.Find(p => p.States == state);
        }

        public IEnumerable<Park> GetParksByDesignation(string designation)
        {
            return _unitOfWork.ParkRepository.Find(p => p.Designation == designation);
        }

        public IEnumerable<Park> GetParksByGeneralDesignation(string designation)
        {
            return designation.Equals("historical site")
                ? _unitOfWork.ParkRepository.Find(p =>
                    p.Designation.IndexOf("Historic", StringComparison.OrdinalIgnoreCase) >= 0
                    || p.Designation.IndexOf("Historical", StringComparison.OrdinalIgnoreCase) >= 0
                    || p.Designation.IndexOf("Battlefield", StringComparison.OrdinalIgnoreCase) >= 0
                    || p.Designation.IndexOf("Memorial", StringComparison.OrdinalIgnoreCase) >= 0
                    || p.Designation.IndexOf("Heritage", StringComparison.OrdinalIgnoreCase) >= 0)
                    .OrderBy(p => p.States)
                : _unitOfWork.ParkRepository.Find(p =>
                    p.Designation == designation
                    || (p.Designation.IndexOf(designation.Split()[0], StringComparison.OrdinalIgnoreCase) >= 0
                        && p.Designation.IndexOf(designation.Split()[1], StringComparison.OrdinalIgnoreCase) >= 0))
                    .OrderBy(p => p.States);
        }

        public IEnumerable<Park> RepopulateParksList(IEnumerable<Park> data)
        {
            // Remove errant datapoints where the names are "?????"
            data = data.Where(p => !p.Name.StartsWith("?", StringComparison.Ordinal));

            WriteData(data);
            return GetAll();
        }

        public IEnumerable<Park> RepopulateParksList(IHostingEnvironment env, IEnumerable<Park> data)
        {
            data = data.Where(p => !p.Name.StartsWith("?", StringComparison.Ordinal));

            WriteData(data);
            return GetAll();
        }

        public void WriteData(IEnumerable<Park> data)
        {
            _unitOfWork.ParkRepository.WriteData(data);
        }
    }
}
