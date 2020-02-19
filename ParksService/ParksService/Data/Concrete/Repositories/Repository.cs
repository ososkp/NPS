using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using ParksService.Helpers;

namespace ParksService.Data.Concrete.Repositories
{
    public abstract class Repository<T>
    {
        protected readonly string FilePath;
        private IEnumerable<T> data;

        protected Repository(IHostingEnvironment env, string fileName)
        {
            FilePath = env.WebRootPath + fileName;
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            if (data.IsNullOrEmpty())
            {
                using var reader = new StreamReader(FilePath);
                var json = reader.ReadToEnd();

                data = json.IsNullOrEmpty() ?
                    new List<T>()
                    : JsonConvert.DeserializeObject<IEnumerable<T>>(json);

            }
            return data;
        }

        public void WriteData(IEnumerable<T> data)
        {
            using var file = File.CreateText(FilePath);
            var serializer = new JsonSerializer();
            serializer.Serialize(file, data);
        }
    }
}
