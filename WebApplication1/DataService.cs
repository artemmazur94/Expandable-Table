using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DataService
    {
        private readonly DataRepository _repository;

        public DataService(DataRepository repository)
        {
            _repository = repository;
        }

        public void Add(SomeModel model)
        {
            _repository.Add(model);
        }

        public List<SomeModel> GetAllModels()
        {
            return _repository.GetAllModels();
        } 
    }
}